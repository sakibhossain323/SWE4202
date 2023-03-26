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

        public static bool IsDistinctUser(string userName)
        {
            foreach (User u in AuthHandler.Users)
            {
                if (userName == u.UserName) throw new Exception("Username already exists");
            }
            return true;
        }

        public static void ValidateName(string name)
        {
            if (name.Length < 1) throw new Exception("Name cannot be empty");
            if (name.Contains(",")) throw new Exception("Name cannot contain comma(,)");
        }

        public static void ValidateUserName(string userName)
        {
            if (userName.Length < 6) throw new Exception("Username must contain at least 6 characters");
            if (userName.Contains(",")) throw new Exception("Username cannot contain comma(,)");
        }

        public static void ValidatePassword(string pass, string repass)
        {
            if (pass.Length < 6) throw new Exception("Password must contain at least 6 characters");
            if (pass.Contains(",")) throw new Exception("Password cannot contain comma(,)");
            if (pass != repass) throw new Exception("Passwords dont match");
            
        }

        public static void ValidateCreds(string name, string uname, string pass, string repass)
        {
            AuthHandler.ValidateName(name);
            AuthHandler.ValidateUserName(uname);
            AuthHandler.ValidatePassword(pass, repass);
            AuthHandler.IsDistinctUser(uname);
        }

        public static void SignUp(string name, string uname, string pass, string repass)
        {
            AuthHandler.ValidateCreds(name, uname, pass, repass);
            string data = uname + "," + pass + "," + name + "\n";
            FileHandler.WriteToFile(data);
        }

    }
}
