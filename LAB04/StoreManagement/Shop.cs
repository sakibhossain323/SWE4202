using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class Shop
    {
        private readonly int _id;
        private readonly string _name, _address;
        private readonly List<Product> _products = new List<Product>();
        public Shop(int id, string name, string address)
        {
            this._id = id;
            this._name = name;
            this._address = address;
        }

        public int Id
        {
            get { return _id; }
        }

        public string Name
        {  
            get { return _name; }
        }

        public List<Product> ProductList 
        { 
            get { return _products; }
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public bool IsNewProduct(int id)
        {
            bool found = true;
            foreach(Product product in _products)
            {
                if(product.Id == id)
                {
                    found = false; 
                    break;
                }
            }

            return found;
        }
    }
}
