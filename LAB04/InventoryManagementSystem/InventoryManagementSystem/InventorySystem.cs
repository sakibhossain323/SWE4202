using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class InventorySystem
    {
        public List<Shop> Shops { get; set; } = new List<Shop>();

        public InventorySystem()
        {

        }

        public Shop FindShop(int id)
        {
            foreach (Shop shop in Shops)
            {
                if (shop.Id == id) return shop;
            }
            throw new ShopNotFoundException(id);
        }

        public void AddShop(int id, string name, string address)
        {
            try
            {
                FindShop(id);
                throw new ShopAlreadyExistsException(id);
            }
            catch (ShopNotFoundException)
            {
                Shop shop = new Shop(id, name, address);
                Shops.Add(shop);
            }
        }

        public void AddProduct(int shopId, int productId, string productName, double price, int quantity)
        {
            Shop shop = FindShop(shopId);
            shop.AddProduct(productId, productName, price, quantity);
        }
    }
}
