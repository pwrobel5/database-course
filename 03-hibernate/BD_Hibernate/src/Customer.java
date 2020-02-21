import javax.persistence.*;
import java.util.Set;

@Entity
@DiscriminatorValue(value = "C")
public class Customer extends Company {
    private double discount;
    @OneToMany
    @JoinColumn(name = "customer_FK")
    private Set<Invoice> invoices;

    public Customer() {
        super();
    }

    public Customer(String companyName, String street, String postalCode, String city, String country, double discount) {
        super(companyName, street, postalCode, city, country);

        this.discount = discount;
    }

    public double getDiscount() {
        return discount;
    }

    public void setDiscount(double discount) {
        this.discount = discount;
    }

    public Set<Invoice> getInvoices() {
        return invoices;
    }

    public void addInvoice(Invoice invoice) {
        this.invoices.add(invoice);
    }

    @Override
    public String toString() {
        return super.toString()
                + ", discount: " + discount;
    }
}
