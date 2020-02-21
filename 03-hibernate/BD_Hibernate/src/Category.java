import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Entity
@Table(name = "Categories")
public class Category {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int categoryID;
    private String categoryName;
    @OneToMany(mappedBy = "category")
    private Set<Product> products;

    public Category() {
    }

    public Category(String categoryName) {
        this.categoryName = categoryName;
        this.products = new HashSet<>();
    }

    public void addProduct(Product product) {
        this.products.add(product);
        product.setCategory(this);
    }

    public Set<Product> getProducts() {
        return products;
    }

    public String getCategoryName() {
        return categoryName;
    }

    @Override
    public String toString() {
        return categoryID + ": " + categoryName;
    }
}
