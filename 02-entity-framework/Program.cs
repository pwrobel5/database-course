using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            // punkt I
            /*
            Console.WriteLine("Type Category name:");
            String name = Console.ReadLine();

            Category category = new Category();
            category.Name = name;

            ProdContext prodContext = new ProdContext();
            prodContext.Categories.Add(category);

            prodContext.SaveChanges();

            var query = from c in prodContext.Categories
                        orderby c.Name descending
                        select c.Name;

            Console.WriteLine("Available categories:");
            foreach(var cat in query)
            {
                Console.WriteLine(cat);
            }

            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
            */

            // punkt IV
            /*
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
            */


            // punkt V
            // deferred query execution
            /*
            using(ProdContext prodContext = new ProdContext())
            {
                IQueryable<String> categoryNames = prodContext.Categories.Select(c => c.Name);

                Console.WriteLine("Category names:");

                foreach(String categoryName in categoryNames)
                {
                    Console.WriteLine(categoryName);
                }
                Console.ReadLine();
            }
            */

            // immediate query execution
            /*
            using (ProdContext prodContext = new ProdContext())
            {
                List<String> categoryNames = prodContext.Categories.Select(c => c.Name).ToList();

                Console.WriteLine("Category names:");

                foreach (String categoryName in categoryNames)
                {
                    Console.WriteLine(categoryName);
                }
                Console.ReadLine();
            }
            */

            // query based syntax - categories and products (join, lazy loading)
            /*
            using (ProdContext prodContext = new ProdContext())
            {
                IQueryable<Category> categories = prodContext.Categories;
                IQueryable<Product> products = prodContext.Products;

                var query =                    
                    from category in categories
                    join product in products
                    on category.CategoryID equals product.CategoryID
                    select new
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.Name,
                        CategoryDescription = category.Description,
                        ProductID = product.ProductID,
                        ProductName = product.Name,
                        UnitsInStock = product.UnitsInStock,
                        UnitPrice = product.UnitPrice
                    };

                foreach (var category in query)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t\t\t{3}\t{4}\t{5}\t{6}",
                        category.CategoryID,
                        category.CategoryName,
                        category.CategoryDescription,
                        category.ProductID,
                        category.ProductName,
                        category.UnitsInStock,
                        category.UnitPrice
                        );
                }
                Console.Read();
            }
            */

            // method based syntax (navigation property, eager loading)
            /*
            using (ProdContext prodContext = new ProdContext())
            {
                var categoryQuery = prodContext.Categories.Include("Product").Select(cat => new
                {
                    CategoryID = cat.CategoryID,
                    CategoryName = cat.Name,
                    CategoryDescription = cat.Description,
                    CategoryProducts = cat.Products
                });

                foreach (var category in categoryQuery)
                {
                    Console.WriteLine("{0}\t{1}\t{2}",
                        category.CategoryID,
                        category.CategoryName,
                        category.CategoryDescription
                        );
                    foreach (Product product in category.CategoryProducts)
                    {
                        Console.WriteLine("\t\t\t\t{0}\t{1}\t{2}\t{3}",
                            product.ProductID,
                            product.Name,
                            product.UnitsInStock,
                            product.UnitPrice);
                    }
                }
                Console.Read();
            }
            */

            // products number
            // query based syntax (lazy loading)
            /*
            using (ProdContext prodContext = new ProdContext())
            {
                var query = from category in prodContext.Categories
                            select new
                            {
                                CategoryID = category.CategoryID,
                                Name = category.Name,
                                Description = category.Description,
                                ProdCount = category.Products.Count()
                            };

                foreach (var category in query)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                        category.CategoryID,
                        category.Name,
                        category.Description,
                        category.ProdCount);
                }
                Console.Read();
            }
            */
            // method based syntax (navigation property, lazy loading)
            /*
            using (ProdContext prodContext = new ProdContext())
            {
                var categoryQuery = prodContext.Categories.Include("Product").Select(cat => new
                {
                    CategoryID = cat.CategoryID,
                    CategoryName = cat.Name,
                    CategoryDescription = cat.Description,
                    CategoryProducts = cat.Products
                });

                foreach (var category in categoryQuery)
                {
                    int productsCount = 0;
                    foreach (Product product in category.CategoryProducts)
                    {
                        productsCount++;
                    }

                    Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                        category.CategoryID,
                        category.CategoryName,
                        category.CategoryDescription,
                        productsCount);
                }

                Console.Read();
            }
            */

            // VI punkt
            ChooseCustomer initialForm = new ChooseCustomer();
            initialForm.ShowDialog();
        }
    }
}
