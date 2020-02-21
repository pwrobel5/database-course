import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;

@Entity
@DiscriminatorValue(value = "S")
public class Supplier extends Company {
    private String bankAccountNumber;
    @OneToMany(mappedBy = "supplier")
    private Set<Product> suppliedProducts;

    public Supplier() {
        super();
    }

    public Supplier(String companyName, String street, String postalCode, String city, String country, String bankAccountNumber) {
        super(companyName, street, postalCode, city, country);

        this.bankAccountNumber = bankAccountNumber;
        this.suppliedProducts = new HashSet<>();
    }

    public void addProductToList(Product addedProduct) {
        this.suppliedProducts.add(addedProduct);
        addedProduct.setSupplier(this);
    }

    public Set<Product> getSuppliedProducts() {
        return suppliedProducts;
    }

    @Override
    public String toString() {
        return super.toString()
                + ", bank account number: " + bankAccountNumber;
    }
}
