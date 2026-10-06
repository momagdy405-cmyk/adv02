using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv02
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
        public double Price { get; set; }
        public int Stock { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Category} - {Price} EGP  stock({Stock})";
        }




        public List<Product> searchproduct(List<Product> li, Func<Product, bool> f)
        {
            List<Product> l = new();
            foreach(var item in li)
            {
                if (f(item))
                {
                    l.Add(item);
                }
               
            }
            return l;
        }
        public void printproduct(List<Product> l, Action<Product> at)
        {
            foreach(var item in l)
            {
                at(item);
            }
        }
        public List<string> transformproducts(List<Product>list,Func<Product,string>fu)
        {
            List<string> l = new();
            foreach(var item in list)
            {
               l.Add( fu(item));
            }
            return l;
        }

        public List<Product> filterproducts(List<Product> list, Predicate<Product> pr)
        {
            List<Product> l0 = new();
            foreach (var item in list)
            {
                if (pr(item))
                {
                    l0.Add(item);
                }
            }
            return l0;
        }



    }
}
