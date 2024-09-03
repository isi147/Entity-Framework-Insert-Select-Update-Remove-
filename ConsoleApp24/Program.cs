using ConsoleApp24.Context;
using ConsoleApp24.Entities;

namespace ConsoleApp24
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            MarketDbContext dbContext = new();
            //Product product1 = new Product()
            //{
            //    Name = "alpen gold",
            //    Price = 2.3f,
            //    InsertionDate = DateTime.Now,
            //};
            //await dbContext.Products.AddAsync(product1);

            //Product product2 = new Product()
            //{
            //    Name = "alpen gold",
            //    Price = 2.3f,
            //    InsertionDate = DateTime.Now,
            //};
            //await dbContext.Products.AddAsync(product2); ;

            //Product product3 = new Product()
            //{
            //    Name = "alpen gold",
            //    Price = 2.3f,
            //    InsertionDate = DateTime.Now,
            //};
            //await dbContext.Products.AddAsync(product3);
            //await dbContext.SaveChangesAsync();



            //var product = dbContext.Products.FirstOrDefault(p=>p.Id==2);
            //product.Name = "Nestle";
            //product.UpdatedDate = DateTime.Now;

            //await dbContext.SaveChangesAsync();


            //Category category = new Category()
            //{
            //    Name = "Wirniyyat",
            //    InsertionDate = DateTime.Now,
            //    Products = new List<Product>()
            //    {
            //        new Product()
            //        {
            //             Name = "Milka",
            //             Price = 10,
            //             InsertionDate= DateTime.Now,
            //        },
            //        new Product()
            //        {
            //             Name = "Alpen Gold",
            //             Price = 3.4f,
            //             InsertionDate= DateTime.Now,
            //        },
            //        new Product()
            //        {
            //             Name = "Kinder",
            //             Price = 7.8f,
            //             InsertionDate= DateTime.Now,
            //        },
            //    }
            //};
            //await dbContext.Categories.AddAsync(category);


            //Product product1 = new Product()
            //{
            //    Name = "Gunebaxan yagi (tebii)",
            //    Price = 50,
            //    InsertionDate = DateTime.Now,
            //    Category = new Category()
            //    {
            //        Name = "Tebii mehsullar",
            //        InsertionDate = DateTime.Now
            //    }
            //};

            //await dbContext.Products.AddAsync(product1);
            //await dbContext.SaveChangesAsync();
        }
    }
}
