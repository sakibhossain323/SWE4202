using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationSystem
{
    internal static class AuthHandler
    {
        private static List<User> _users = new List<User>();
        public static List<User> Users
        {
            get
            {
                _users = _users = FileHandler.GetUserData();
                return _users;
            }
        }

        public static User Login(string userName, string password)
        {
            foreach(User u in AuthHandler.Users)
            {
                if (userName == u.UserName && password == u.Password) return u;
            }
            throw new Exception("Invalid username or password");
        }
        
        

    }
}
