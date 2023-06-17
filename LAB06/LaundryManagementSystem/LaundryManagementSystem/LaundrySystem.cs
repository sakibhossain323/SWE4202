using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    class LaundrySystem
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public Owner Owner = new Owner();

        public User FindUser(int id)
        {
            foreach(User u in Users)
            {
                if (u.ID == id) return u;
            }
            throw new UserNotFoundException();
        }

        public void CreateUser(int id, string name, string address)
        {
            try
            {
                FindUser(id);
                throw new UserAlreadyExistsException();
            }
            catch (UserNotFoundException)
            {
                Users.Add(new User(id, name, address));
            }
        }

        public Order FindOrder(int orderId)
        {
            foreach(Order order in Orders)
            {
                if (order.ID == orderId) return order;
            }

            throw new OrderNotFoundException();
        }

        public int PlaceOrder(int userID, List<OrderItem> items)
        {
            User user = FindUser(userID);
            Order order = new Order(user, items);
            Orders.Add(order);
            return order.ID;
        }
    }
}
