using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    abstract class File
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public string Content { get; protected set; }
        public List<string> Features { get; protected set; } = new List<string>();
       
        public double FileSize 
        {
            get { return (2 * Content.Length) / 1024.0; }
        }

    }
}
