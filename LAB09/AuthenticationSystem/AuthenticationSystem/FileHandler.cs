using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationSystem
{
    internal static class FileHandler
    {
        
        public static readonly string _curDir = Directory.GetCurrentDirectory();
        public static readonly string _path = _curDir + "\\Records.txt";

        

        private static string[] ReadFile()
        {
            try { return File.ReadAllLines(_path); }
            catch (FileNotFoundException)
            {
                File.CreateText(_path).Close();
                return new string[0];
            }
            catch (Exception exc) { throw exc; }
        }

        public static List<User> GetUserData()
        {
            string[] lines = ReadFile();
            var users = new List<User>();
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Count() != 3) throw new Exception("Records are corrupted");
                var user = new User(data[0], data[1], data[2]);
                users.Add(user);
            }
            return users;
        }

        public static void WriteToFile(string data)
        {
            File.AppendAllText(_path, data);
        }
    }
}
