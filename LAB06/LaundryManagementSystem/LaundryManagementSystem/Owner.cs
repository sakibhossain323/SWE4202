using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    class Owner
    {
        public double Balance { get; set; } = 0;

        public void SetStatus(Order order, OrderStatus status)
        {
            order.Status = status;
            if (status == OrderStatus.Processing) order.Estimated = DateTime.Now.AddDays(7);
            if (status == OrderStatus.Delivered) Balance += order.TotalAmount;
        }
    }
}
