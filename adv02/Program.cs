using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace adv02
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                   new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                   new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                   new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                   new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                   new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                   new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                   new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                   new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                   new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                   new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };
            Product p = new Product();
            List<Product> res= p.searchproduct(catalog, x => x.Category == "Electronics");
            Console.WriteLine("Electronics");
            foreach (var item in res)
            {
               
                Console.WriteLine(item);
               
            }
            Console.WriteLine("-----------------------------------");
            List<Product> l = p.searchproduct(catalog, x => x.Price<50);
            Console.WriteLine("products under 50$");
            foreach (var item in l)
            {
               
                Console.WriteLine(item);
              
            }
            Console.WriteLine("-----------------------------------");
            List<Product> l2 = p.searchproduct(catalog, x => x.Stock>0);
            Console.WriteLine(" found products");
            foreach (var item in l2)
            {
               
                Console.WriteLine(item);
              
            }
            Console.WriteLine("-----------------------------------");
            List<Product> l3 = p.searchproduct(catalog, x => x.Category=="Clothing" && x.Price<100);
            Console.WriteLine("clothing under100$");
            foreach (var item in l3)
            {
               
                Console.WriteLine(item);
               
            }
            Console.WriteLine("-----------------------------------");

            Product p1 = new Product();
             p.printproduct(catalog, x => Console.WriteLine($" {x.Name}-{x.Price}"));
             p.printproduct(catalog, x => Console.WriteLine($"[{x.Category}] {x.Name}|{x.Price}|{x.Stock}"));
            Console.WriteLine("-----------------------------------");

            Product p2 = new Product();
            List<string> lis = p2.transformproducts(catalog, x => $"{x.Category}({x.Price})");
            List<string>li=p2.transformproducts(catalog,x=>x.Price>100 ?$"{x.Name}:Expensive":$"{x.Name}:affordable");
            foreach (var item in lis)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine("-----------------------------------");

            foreach (var item in li)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine("-----------------------------------");
            Product p3= new Product();
            List<Product> listt = p3.filterproducts(catalog, x =>x.Stock<20);
                 foreach (var item in listt)
            {

                Console.WriteLine($"[LOW STOCK]{item.Name}:only{item.Stock}left");

            }
            Console.WriteLine("-----------------------------------");

        }
    }
}
