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

        

        public static string[] ReadFromFile()
        {

            Console.WriteLine(FileHandler.Path);

            if (File.Exists(FileHandler.Path))
            {
                var lines = File.ReadAllLines(FileHandler.Path);
                Console.WriteLine(lines);
                return lines;
            }
            else throw new Exception("File Not Found");
            
        }

        public static void WriteToFile()
        {

        }
    }
}
