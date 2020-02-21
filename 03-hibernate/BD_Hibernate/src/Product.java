import javax.persistence.*;
import java.util.HashSet;
import java.util.Objects;
import java.util.Set;

@Entity
@Table(name = "Products")
public class Product {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int productID;
    private String productName;
    private int unitsOnStock;
    @ManyToOne
    @JoinColumn(name = "SUPPLIER_FK")
    private Supplier supplier;
    @ManyToOne
    @JoinColumn(name = "CATEGORY_FK")
    private Category category;
    @ManyToMany(mappedBy = "products", cascade = CascadeType.PERSIST)
    private Set<Invoice> invoices;

    public Product() {
    }

    public Product(String productName, int unitsOnStock) {
        this.productName = productName;
        this.unitsOnStock = unitsOnStock;
        this.invoices = new HashSet<>();
    }

    public void setSupplier(Supplier supplier) {
        this.supplier = supplier;
        this.supplier.getSuppliedProducts().add(this);
    }

    public void setCategory(Category category) {
        this.category = category;
        this.category.getProducts().add(this);
    }

    public String getProductName() {
        return productName;
    }

    public Category getCategory() {
        return category;
    }

    public Set<Invoice> getInvoices() {
        return invoices;
    }

    public void decreaseUnitsOnStock(int quantity) {
        this.unitsOnStock -= quantity;
    }

    public void addInvoice(Invoice invoice, int quantity) {
        this.invoices.add(invoice);
        this.decreaseUnitsOnStock(quantity);
        invoice.setQuantity(quantity);
    }

    public int getProductID() {
        return productID;
    }

    public int getUnitsOnStock() {
        return unitsOnStock;
    }

    @Override
    public String toString() {
        return productID + ": " + productName + ", unitsOnStock: " + unitsOnStock;
    }
}
