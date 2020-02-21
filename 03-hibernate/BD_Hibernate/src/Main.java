import org.hibernate.*;
import org.hibernate.query.Query;
import org.hibernate.cfg.Configuration;

import javax.persistence.metamodel.EntityType;

import java.util.Map;
import java.util.Scanner;

public class Main {
    private static final SessionFactory ourSessionFactory;

    static {
        try {
            Configuration configuration = new Configuration();
            configuration.configure();

            ourSessionFactory = configuration.buildSessionFactory();
        } catch (Throwable ex) {
            throw new ExceptionInInitializerError(ex);
        }
    }

    public static Session getSession() throws HibernateException {
        return ourSessionFactory.openSession();
    }
/*
    public static void main(final String[] arg) {
        final Session session = getSession();
        Transaction tx = session.beginTransaction();

        Product sampleProduct = session.get(Product.class, 2);
        System.out.println("Extracted product: " + sampleProduct);
        System.out.println("Product category: " + sampleProduct.getCategory());

        tx.commit();
        session.close();
    }
 */
}