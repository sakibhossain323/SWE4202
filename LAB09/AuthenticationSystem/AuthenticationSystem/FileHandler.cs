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
        
        public static readonly string _curDir = System.IO.Directory.GetCurrentDirectory();
        public static readonly string Path = _curDir + "\\Records.txt";

        

        public static string[] ReadFile()
        {
            try { return File.ReadAllLines(FileHandler.Path); }
            catch (FileNotFoundException)
            {
                File.CreateText(FileHandler.Path).Close();
                return new string[0];
            }
            catch (Exception exc) { throw exc; }
        }

        public static List<User> GetUserData()
        {
            string[] lines = FileHandler.ReadFile();
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
            File.AppendAllText(FileHandler.Path, data);
        }
    }
}
