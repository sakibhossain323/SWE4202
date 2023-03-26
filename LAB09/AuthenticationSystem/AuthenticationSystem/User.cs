using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationSystem
{
    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password, string name)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;
        }
    }
}
