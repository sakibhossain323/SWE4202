using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class ReadOnlyFile : File
    {
        public ReadOnlyFile(string name, string type, string content)
        {
            Name = name;
            Type = type;
            Content = content;
            Features.Add("Share");
            Features.Add("Print");
            Features.Add("Archive");
        }

    }
}
