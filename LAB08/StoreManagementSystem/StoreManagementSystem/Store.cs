using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class Store
    {
        public List<Product> Inventory { get; set; }

        public Store()
        {
            Inventory= new List<Product>();
            Console.WriteLine("---Store has been generated successfully---");
        }

        public Product FindProduct(int id)
        {
            foreach(Product p in Inventory)
            {
                if(p.Id == id) return p;
            }
            return null;
        }

        public void AddProduct(Product p)
        {
            Inventory.Add(p);
            Console.WriteLine("--- Product has been added ---");
            p.Productinfo();
        }
    }
}
