import javax.persistence.*;
import java.util.HashSet;
import java.util.Objects;
import java.util.Set;

@Entity
@Table(name = "Invoices")
public class Invoice {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int invoiceNumber;
    private int quantity;
    @ManyToMany(cascade = {CascadeType.PERSIST})
    private Set<Product> products;

    public Invoice() {
    }

    public Invoice(int quantity) {
        this.quantity = quantity;
        this.products = new HashSet<>();
    }

    public Set<Product> getProducts() {
        return products;
    }

    public void addProduct(Product product, int quantity) {
        this.products.add(product);
        this.quantity += quantity;
        product.decreaseUnitsOnStock(quantity);
    }

    public int getInvoiceNumber() {
        return invoiceNumber;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    @Override
    public String toString() {
        return "Invoice " + invoiceNumber + ", total quantity: " + quantity;
    }
}
