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
            Console.WriteLine("----Store has been generated successfully!----");
        }

        public Product FindProduct(int id)
        {
            foreach(Product p in this.Inventory)
            {
                if(p.Id == id) return p;
            }
            return null;
        }

        public void AddProduct(Product p)
        {
            Inventory.Add(p);
            Console.WriteLine("----Product has been added!----");
            p.ShowProductInfo();
        }

        public void AddExistingProduct(Product p, int amt)
        {
            p.Curlevel += amt;
            Console.WriteLine($"----Added {amt} pieces of {p.Name}----");
        }

        public void ShowStoreDetails()
        {
            Console.WriteLine("----Inventory Details----");
            foreach (Product p in this.Inventory) p.ShowProductInfo();
        }
    }
}
