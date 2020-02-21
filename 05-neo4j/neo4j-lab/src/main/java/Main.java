import java.sql.*;
import java.util.LinkedList;
import java.util.List;
import java.util.PriorityQueue;

public class Main {

    static Connection connection;

    public static void main(String[] args) {
        try {
            connection = DriverManager.getConnection("jdbc:neo4j:http://localhost:7474", "neo4j", "password");

            List<Node> nodes = new LinkedList<>();
            readNodes(nodes);
            readEdges(nodes);

            int indexOfA = nodes.indexOf(new Node("A"));
            Node startingNode = nodes.get(indexOfA);
            nodes.remove(startingNode);

            PriorityQueue<Edge> edgesQueue = new PriorityQueue<>(startingNode.getNeighbours());
            while(!nodes.isEmpty()) {
                Edge nextEdge = edgesQueue.poll();
                if(nodes.contains(nextEdge.getStop())) {
                    Node stopNode = nextEdge.getStop();
                    nodes.remove(stopNode);
                    edgesQueue.addAll(stopNode.getNeighbours());
                    markEdge(nextEdge);
                }
            }

            connection.close();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public static void markEdge(Edge edge) throws SQLException {
        String query = String.format("MATCH (a:Elem)-[r:CONN]->(b:Elem) WHERE a.label = '%s' AND b.label = '%s' SET r.mst = 1",
                edge.getStart().getLabel(), edge.getStop().getLabel());
        Statement statement = connection.createStatement();
        statement.execute(query);
    }

    public static void readNodes(List<Node> nodes) throws SQLException {
        String query = "MATCH (e:Elem) RETURN e.label";
        PreparedStatement statement = connection.prepareStatement(query);
        ResultSet rs = statement.executeQuery();

        while(rs.next()) {
            nodes.add(new Node(rs.getString("e.label")));
        }
    }

    public static void readEdges(List<Node> nodes) throws SQLException {
        String query = "match (a:Elem)-[r:CONN]->(b:Elem) return a.label, b.label, r.cost";
        PreparedStatement statement = connection.prepareStatement(query);
        ResultSet rs = statement.executeQuery();

        while(rs.next()) {
            int startIndex = nodes.indexOf(new Node(rs.getString("a.label")));
            Node start = nodes.get(startIndex);

            int stopIndex = nodes.indexOf(new Node(rs.getString("b.label")));
            Node stop = nodes.get(stopIndex);

            Edge edge = new Edge(start, stop, rs.getInt("r.cost"));
        }
    }

    public static void exampleMatch() throws SQLException {
        String query = "MATCH (m:Movie) where m.title contains 'You' return m.title";
        PreparedStatement statement = connection.prepareStatement(query);
        ResultSet rs = statement.executeQuery();
        while(rs.next()){
            System.out.println("Movie: " + rs.getString("m.title"));
        }

        statement.close();
        rs.close();
    }
}
