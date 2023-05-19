using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal abstract class File
    {
        protected string name, type, content;
        protected readonly List<string> features = new List<string>();

        public List<string> Features { get { return features; } }

        
        public string Name { get { return name; } }
        public string Type { get { return type; } }
        public string Content { get { return content; } }
        

        public double GetFileSize()
        {
            return (2*this.content.Length)/1024.0;
        }

    }
}
