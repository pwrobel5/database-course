import javax.persistence.*;

@Entity
@Table(name = "Companies")
@Inheritance(strategy = InheritanceType.SINGLE_TABLE)
public abstract class Company {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int companyID;
    private String companyName;
    private String street;
    private String postalCode;
    private String city;
    private String country;

    public Company() {
    }

    public Company(String companyName, String street, String postalCode, String city, String country) {
        this.companyName = companyName;
        this.street = street;
        this.postalCode = postalCode;
        this.city = city;
        this.country = country;
    }

    public int getCompanyID() {
        return companyID;
    }

    @Override
    public String toString() {
        return "Company name: " + companyName
                + ", address: "
                + street + " " + postalCode
                + " " + city + ", " + country;
    }
}
