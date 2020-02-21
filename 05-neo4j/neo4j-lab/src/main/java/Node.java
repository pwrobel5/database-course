import java.util.HashSet;
import java.util.Objects;
import java.util.Set;

public class Node {
    private String label;
    private Set<Edge> neighbours;

    public Node(String label) {
        this.label = label;
        this.neighbours = new HashSet<>();
    }

    public String getLabel() {
        return label;
    }

    public Set<Edge> getNeighbours() {
        return neighbours;
    }

    public void addEdge(Edge edge) {
        this.neighbours.add(edge);
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Node node = (Node) o;
        return label.equals(node.label);
    }

    @Override
    public int hashCode() {
        return Objects.hash(label);
    }
}
