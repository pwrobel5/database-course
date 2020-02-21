import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.EntityTransaction;
import javax.persistence.Persistence;
import java.util.List;

public class MainJPA {

    public static void generateData(EntityManager em) {

    }
/*
    public static void main(String[] args) {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("DBHibernateConfig");
        EntityManager em = emf.createEntityManager();
        EntityTransaction etx = em.getTransaction();
        etx.begin();

        /*
        Customer customer1 = new Customer("Janusz sp. z.o.o.", "al. Mickiewicza 20a", "30-000", "Kraków", "Polska", 30.3);
        Customer customer2 = new Customer("Andrzej", "Telimeny 25", "36-098", "Kraków", "Polska", 12.3);

        Supplier supplier1 = new Supplier("Dostawca pizzy", "ul. Wileńska 4", "00-304", "Warszawa", "Polska", "12 2345 5678");
        Supplier supplier2 = new Supplier("Dostawca perfum", "ul. Długa 12", "23-567", "Gdańsk", "Polska", "33 2245 6654");

        em.persist(customer1);
        em.persist(customer2);
        em.persist(supplier1);
        em.persist(supplier2);
        */

        /*
        List<Customer> customers = em.createQuery("from Customer").getResultList();
        for(Customer c : customers) {
            System.out.println(c);
        }




        etx.commit();
        em.close();
    }
    */
}
