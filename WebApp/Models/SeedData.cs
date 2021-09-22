using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public static class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (context.Products.Count() == 0 && context.Suppliers.Count() == 0 && context.Categories.Count() == 0)
            {
                Supplier supplier1 = new Supplier
                {
                    Name = "Splash Dudes",
                    City = "San Jose"
                };

                Supplier supplier2 = new Supplier
                {
                    Name = "Soccer Town",
                    City = "San Francisco"
                };

                Supplier supplier3 = new Supplier
                {
                    Name = "Chess Co",
                    City = "New York"
                };


                Category category1 = new Category { Name = "Watersports" };

                Category category2 = new Category { Name = "Soccer" };

                Category category3 = new Category { Name = "Chess" };

                context.Products.AddRange(
                    new Product {
                        Name = "Kayak",
                        Price = 275,
                        Category = category1,
                        Supplier = supplier1
                    },

                    new Product
                    {
                        Name = "Lifejacket",
                        Price = 48.95m,
                        Category = category1,
                        Supplier = supplier1
                    },

                    new Product
                    {
                        Name = "Soccer Ball",
                        Price = 19.50m,
                        Category = category2,
                        Supplier = supplier2
                    },
                    
                    new Product
                    {
                        Name = "Corner Flags",
                        Price = 34.95m,
                        Category = category2,
                        Supplier = supplier2
                    },
                    
                    new Product
                    {
                        Name = "Stadium",
                        Price = 79500,
                        Category = category2,
                        Supplier = supplier2
                    },
                    
                    new Product
                    {
                        Name = "Thinking Cap",
                        Price = 16,
                        Category = category3,
                        Supplier = supplier3
                    },
                    
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Price = 29.95m,
                        Category = category3,
                        Supplier = supplier3
                    },
                    
                    new Product
                    {
                        Name = "Human Chess Board",
                        Price = 75,
                        Category = category3,
                        Supplier = supplier3
                    },
                    
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Price = 1200,
                        Category = category3,
                        Supplier = supplier3
                    });

                context.SaveChanges();
            }
        }
    }
}
