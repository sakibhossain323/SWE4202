using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    class OrderItem
    {
        public ClothType Type { get;}
        public int Quantity { get; }
        public Task Todo { get; }
        public double Amount { get; }

        public OrderItem(ClothType type, int quantity, Task todo)
        {
            Type = type;
            Quantity = quantity;
            Todo = todo;
            Amount = Utility.Cost[type][todo] * quantity;
        }
    }
}
