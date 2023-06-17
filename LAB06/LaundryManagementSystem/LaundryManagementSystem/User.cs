using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public User(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }
    }
}
