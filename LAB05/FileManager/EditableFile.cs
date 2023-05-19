using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class EditableFile: FileManager.File
    {
        public EditableFile(string name, string type, string content)
        {
            this.name = name;
            this.type = type;
            this.content = content;
            this.features.Add("Share");
            this.features.Add("Update");
            this.features.Add("Compress");
            this.features.Add("Translate");
        }

        public void SetContent(string content)
        {
            this.content = content;
        }
    }
}
