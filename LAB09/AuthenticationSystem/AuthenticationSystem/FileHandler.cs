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
        public static readonly string Path = _curDir.Substring(0, _curDir.Length - "bin\\Debug".Length) + "DB.txt";

        

        public static string[] ReadFile()
        {

            Console.WriteLine(FileHandler.Path);

            if (File.Exists(FileHandler.Path))
            {
                var lines = File.ReadAllLines(FileHandler.Path);
                return lines;
            }
            else throw new Exception("File Not Found");
            
        }

        public static List<User> GetUserData()
        {
            string[] lines = FileHandler.ReadFile();
            var users = new List<User>();
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Count() != 3) throw new Exception("Corrupted User Data");
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
