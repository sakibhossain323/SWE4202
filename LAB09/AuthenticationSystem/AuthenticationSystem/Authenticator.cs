using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationSystem
{
    static class Authenticator
    {
        private static List<User> _users = new List<User>();
        public static List<User> Users
        {
            get
            {
                _users = FileHandler.GetUserData();
                return _users;
            }
        }

        public static User CurrentUser { get; private set; }

        
        public static void Login(string userName, string password)
        {
            foreach(User u in Users)
            {
                if (userName == u.UserName && password == u.Password)
                {
                    CurrentUser = u;
                    return;
                }
            }
            throw new InvalidUserPassException();
        }

        public static void Logout() 
        { 
            CurrentUser = null;
        }

        public static void SignUp(string name, string uname, string pass, string repass)
        {
            ValidateCreds(name, uname, pass, repass);
            string data = uname + "," + pass + "," + name + "\n";
            FileHandler.WriteToFile(data);
        }

        // Methods to validate sign up credentials

        private static void ValidateCreds(string name, string uname, string pass, string repass)
        {
            ValidateName(name);
            ValidateUserName(uname);
            ValidatePassword(pass, repass);
        }

        private static void ValidateName(string name)
        {
            string credtype = "Name";
            if (name.Length < 1) throw new EmptyCredentialException(credtype);
            if (name.Contains(",")) throw new CredentialContainsCommaException(credtype);
        }

        private static void ValidateUserName(string userName)
        {
            string credtype = "Username";
            if (userName.Length < 6) throw new CredentialLengthException(credtype, 6);
            if (userName.Contains(",")) throw new CredentialContainsCommaException(credtype);
            foreach (User u in Users)
            {
                if (userName == u.UserName) throw new UsernameAlreadyExistsException();
            }
        }

        private static void ValidatePassword(string pass, string repass)
        {
            string credtype = "Password";
            if (pass.Length < 6) throw new CredentialLengthException(credtype, 6);
            if (pass.Contains(",")) throw new CredentialContainsCommaException(credtype);
            if (pass != repass) throw new PasswordsDontMatchException();
            
        }
    }
}
