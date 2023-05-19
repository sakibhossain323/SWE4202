using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class ReadOnlyFile: FileManager.File
    {
        public ReadOnlyFile(string name, string type, string content)
        {
            this.name = name;
            this.type = type;
            this.content = content;
            this.features.Add("Share");
            this.features.Add("Print");
            this.features.Add("Archive");
        }

    }
}
