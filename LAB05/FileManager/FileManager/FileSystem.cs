using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class FileSystem
    {
        public List<File> Files { get; private set; } = new List<File>();
        public File SelectedFile { get; private set; }

        public FileSystem()
        {
            
        }

        public File FindFile(string name)
        {
            foreach (File file in Files)
            {
                if (name == file.Name) return file;
            }

            throw new FileNotFoundException(name);
        }

        public void AddFile(string name, string type, string content)
        {
            try
            {
                File file = FindFile(name);
                throw new FileAlreadyExistsException(name);
            }
            catch (FileNotFoundException)
            {
                File newfile;
                if (type == "Editable") newfile = new EditableFile(name, type, content);
                else newfile = new ReadOnlyFile(name, type, content);
                Files.Add(newfile);
            }
        }

        public void RemoveFile(string name)
        {
            File file = FindFile(name);
            Files.Remove(file);
        }

        public void UpdateFile(string name)
        {
            File file = FindFile(name);
            if (file.Type == "Read-Only") throw new ReadOnlyFileException(name);
            SelectedFile = file;
        }

        public void SaveContent(string newContent)
        {
            if (SelectedFile == null) throw new FileNotSelectedException();
            EditableFile file = (EditableFile)SelectedFile;
            file.SetContent(newContent);
            SelectedFile = null;
        }
    }
}
