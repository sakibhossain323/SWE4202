using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class InventoryException: Exception
    {
        public InventoryException(string msg): base(msg)
        {

        }
    }

    class StockOutException : InventoryException
    {
        public StockOutException() : base("Not enough stock")
        {

        }
    }

    class ProductNotFoundException : InventoryException
    {
        public ProductNotFoundException(int id) : base($"Any product of ID:{id} wasn't found")
        {

        }
    }

    class ShopNotFoundException : InventoryException
    {
        public ShopNotFoundException(int id) : base($"Any shop of ID:{id} wasn't found")
        {

        }
    }

    class ShopAlreadyExistsException : InventoryException
    {
        public ShopAlreadyExistsException(int id) : base($"A shop with ID:{id} already exists")
        {

        }
    }
}
