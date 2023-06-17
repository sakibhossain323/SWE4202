using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    class Order
    {
        private static int _nextID = 1;

        public int ID { get; }
        public User OrderBy { get; }
        public List<OrderItem> Items { get; } = new List<OrderItem>();
        public OrderStatus Status { get; set; }
        public DateTime Estimated { get; set; }
        public double TotalAmount { get; } = 0;
        

        public Order(User orderBy, List<OrderItem> items)
        {
            ID = _nextID++;
            OrderBy = orderBy;
            Items = items;
            Status = OrderStatus.Pending;
            foreach (OrderItem i in items) TotalAmount += i.Amount;
        }
    }
}
