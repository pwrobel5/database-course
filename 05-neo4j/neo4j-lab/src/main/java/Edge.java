import java.util.Objects;

public class Edge implements Comparable<Edge> {
    private Node start;
    private Node stop;
    private int cost;

    public Edge(Node start, Node stop, int cost) {
        this.start = start;
        this.stop = stop;
        this.cost = cost;

        start.addEdge(this);
    }

    public Node getStart() {
        return start;
    }

    public Node getStop() {
        return stop;
    }

    public int getCost() {
        return cost;
    }

    @Override
    public int compareTo(Edge o) {
        return this.cost - o.getCost();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Edge edge = (Edge) o;
        return cost == edge.cost &&
                start.equals(edge.start) &&
                stop.equals(edge.stop);
    }

    @Override
    public int hashCode() {
        return Objects.hash(start, stop, cost);
    }
}
