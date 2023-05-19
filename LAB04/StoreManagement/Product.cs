using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    internal class Product
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _price;
        private int _quantity;

        public Product(int id, string name, double price, int quantity)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._quantity = quantity;
        }

        public int Id 
        { 
            get { return _id;}
        }

        public string Name
        {
            get { return _name;}
        }

        public double Price
        {
            get { return _price;}
        }

        public int Quantity
        {
            get { return _quantity;}
        }

        public void IncreaseQuantity(int quantity)
        {
            this._quantity += quantity;
        }
    }
}
