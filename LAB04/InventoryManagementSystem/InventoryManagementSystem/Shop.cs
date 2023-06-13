using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<InventoryItem> Inventory { get; private set; } = new List<InventoryItem>();
        public Shop(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

        public InventoryItem FindProduct(int id)
        {
            foreach (InventoryItem item in Inventory)
            {
                if (item.Product.Id == id) return item;
            }
            throw new ProductNotFoundException(id);
        }

        public void AddProduct(int id, string name, double price, int quantity)
        {

            try
            {
                InventoryItem item = FindProduct(id);
                item.Stock += quantity;
            }
            catch (ProductNotFoundException)
            {
                Product p = new Product(id, name, price);
                InventoryItem item = new InventoryItem(p, quantity);
                Inventory.Add(item);
            }
        }
    }
}
