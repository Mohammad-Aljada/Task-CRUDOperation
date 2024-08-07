using Task_CRUDOperation.Context;
using Task_CRUDOperation.Models;

namespace Task_CRUDOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbcontext = new ApplicationDbContext();
            //insert
            /*    Product product1 = new Product() { Name = "Phone", Price = 1200 };
                  Product product2 = new Product() { Name = "laptop", Price = 2000 };
                  Product product3= new Product() { Name = "clothes", Price = 80 };
                  Order order1 = new Order() { Address="Tulkarm", CreatedAt = new DateTime(2024, 6, 7 , 17, 34, 27, 217) };
                  Order order2 = new Order() { Address = "Nablus", CreatedAt = new DateTime(2024, 5, 7 , 12, 30, 20, 212) };
                  Order order3 = new Order() { Address = "Zeita", CreatedAt = new DateTime(2024, 8, 7 , 22, 40, 27, 210) };

                  dbcontext.Products.Add(product1);
                  dbcontext.Products.Add(product2);
                  dbcontext.Products.Add(product3);
                  dbcontext.Orders.Add(order1);
                  dbcontext.Orders.Add(order2);
                  dbcontext.Orders.Add(order3);*/

            //Read=>select
            /*  var products = dbcontext.Products.ToList();

              foreach (var product in products)
              {
                  Console.WriteLine($"productId={product.Id}..productName={product.Name}" +
                      $"..productPrice={product.Price}");  
                  Console.WriteLine("-----------------");
              }
              var orders = dbcontext.Orders.ToList();
              foreach (var order in orders)
              {
                  Console.WriteLine($"orderId={order.Id}..Address={order.Address}..CreatedAt={order.CreatedAt}");
                  Console.WriteLine("-----------------");

              }*/

            //update 
            /* var product = dbcontext.Products.First();
              product.Name = "shoes";

              var order = dbcontext.Orders.First(p => p.Id==2);
              order.CreatedAt = new DateTime(2024, 8, 5, 17, 34, 27, 217);*/

            //delete
           /* var product = dbcontext.Products.First(p => p.Id == 2);
            dbcontext.Products.Remove(product);

            var order = dbcontext.Orders.First(p => p.Id == 3);
            dbcontext.Orders.Remove(order);*/

            dbcontext.SaveChanges();


        }
    }
}
