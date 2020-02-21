import javax.persistence.*;
import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

public class MainApp {
    public static Customer loggedUser;
    public static EntityManager em;

    public static void generateData() {
        EntityTransaction etx = em.getTransaction();
        etx.begin();

        Product product1 = new Product("Zapałki", 12);
        Product product2 = new Product("Cebula", 145);
        Product product3 = new Product("Michałki", 1234);

        em.persist(product1);
        em.persist(product2);
        em.persist(product3);

        etx.commit();
    }

    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("DBHibernateConfig");
        em = emf.createEntityManager();

        //generateData();

        Scanner inputScanner = new Scanner(System.in);
        Logger logger = new Logger(em, inputScanner);
        loggedUser = logger.loginCompany();

        Menu menu;

        menu = new Menu("Hello customer");
        menu.addOption("show orders", MainApp::listOrders);
        menu.addOption("make new order", MainApp::makeNewOrder);
        menu.addOption("exit", x -> System.exit(0));
        menu.display();

        em.close();
    }

    public static void listOrders(Scanner scanner) {
        for (Invoice currentInvoice : loggedUser.getInvoices()) {
            System.out.println("Order number: " + currentInvoice.getInvoiceNumber());
            System.out.printf("Quantity: " + currentInvoice.getQuantity());
            for (Product invoiceProduct : currentInvoice.getProducts()) {
                System.out.printf("\t%s\n", invoiceProduct.getProductName());
            }
        }
    }

    public static void listProducts() {
        TypedQuery<Product> query = em.createQuery("from Product", Product.class);
        List<Product> products = query.getResultList();

        System.out.printf("ID\t\tNAME\t\tUNITS ON STOCK\n");
        for (Product currentProduct : products) {
            System.out.printf("%d\t\t%s\t\t%d\n", currentProduct.getProductID(), currentProduct.getProductName(), currentProduct.getUnitsOnStock());
        }
    }

    public static void makeNewOrder(Scanner scanner) {
        Invoice newInvoice = new Invoice(0);
        listProducts();
        boolean continueReading = true;

        EntityTransaction etx = em.getTransaction();
        etx.begin();

        while (continueReading) {
            System.out.print("Enter product number: ");
            Integer productNumber = Integer.parseInt(scanner.nextLine());
            System.out.print("Enter quantity: ");
            Integer quantity = Integer.parseInt(scanner.nextLine());

            Product orderedProduct = em.find(Product.class, productNumber);
            if (quantity <= orderedProduct.getUnitsOnStock()) {
                newInvoice.addProduct(orderedProduct, quantity);
            } else {
                System.out.println("Given number is bigger than units on stock number!");
            }

            System.out.println("End order? (Y/N)");
            String response = scanner.nextLine().toLowerCase();

            if (response.equals("y")) {
                continueReading = false;
            }
        }

        em.persist(newInvoice);
        loggedUser.addInvoice(newInvoice);

        etx.commit();
    }
}
