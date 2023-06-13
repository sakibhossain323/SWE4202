using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class InventoryItem
    {
        public Product Product { get; set; }
        private int _stock = 0;

        public InventoryItem(Product p, int quantity)
        {
            Product = p;
            Stock = quantity;
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value < 0) throw new StockOutException();
                _stock = value;
            }
        }
    }
}
