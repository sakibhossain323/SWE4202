using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class EditableFile : File
    {
        public EditableFile(string name, string type, string content)
        {
            Name = name;
            Type = type;
            Content = content;
            Features.Add("Share");
            Features.Add("Update");
            Features.Add("Compress");
            Features.Add("Translate");
        }

        public void SetContent(string newContent) { Content = newContent; }
    }
}
