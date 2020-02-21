import javax.persistence.EntityManager;
import javax.persistence.EntityTransaction;
import javax.persistence.TypedQuery;
import java.util.List;
import java.util.Scanner;

public class Logger {
    private EntityManager em;
    private Scanner scanner;

    public Logger(EntityManager em, Scanner scanner) {
        this.em = em;
        this.scanner = scanner;
    }

    public Customer loginCompany() {
        System.out.println("Hello to Java Hibernate App.");
        System.out.printf("\tL - log in as an existing user\n\tR - create new account\n");
        System.out.printf("\tAny other key - exit\n");
        System.out.print("Response: ");
        String resp = scanner.nextLine().toLowerCase();

        if (resp.equals("l")) {
            return authenticateUser();
        } else if (resp.equals("r")) {
            return createNewUser();
        } else {
            return null;
        }
    }

    private Customer authenticateUser() {
        System.out.print("\tCompany name: ");
        String companyName = scanner.nextLine();

        TypedQuery<Customer> companyQuery = em.createQuery("from Customer as customer where customer.companyName = :compName", Customer.class);
        companyQuery.setParameter("compName", companyName);

        List<Customer> result = companyQuery.getResultList();
        if (result.size() != 1) {
            System.out.println("Authentication failed");
            System.exit(1);
        }

        System.out.println("Authentication successfull");
        return result.get(0);

    }

    private Customer createNewUser() {
        System.out.print("Enter company name: ");
        String companyName = scanner.nextLine();

        TypedQuery<Customer> companyQuery = em.createQuery("from Customer as company where company.companyName = :compName", Customer.class);
        companyQuery.setParameter("compName", companyName);

        List<Customer> result = companyQuery.getResultList();
        if (result.size() != 0) {
            System.out.println("Company with this name already exists!");
            System.exit(1);
        }

        System.out.print("Company street: ");
        String street = scanner.nextLine();
        System.out.print("Company postal code: ");
        String postalCode = scanner.nextLine();
        System.out.print("Company city: ");
        String city = scanner.nextLine();
        System.out.print("Company country: ");
        String country = scanner.nextLine();

        Customer registrationResult = new Customer(companyName, street, postalCode, city, country, 0.0);

        EntityTransaction etx = em.getTransaction();
        etx.begin();
        em.persist(registrationResult);
        etx.commit();
        ;

        return registrationResult;
    }
}
