using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    class FileSystemException : Exception
    {
        public FileSystemException(string msg): base(msg)
        {

        }
    }

    class FileNotFoundException : FileSystemException
    {
        public FileNotFoundException(string name): base($"\"{name}\" doesn't exist!")
        {

        }
    }

    class FileAlreadyExistsException : FileSystemException
    {
        public FileAlreadyExistsException(string name): base($"\"{name}\" already exists!")
        {

        }
    }

    class ReadOnlyFileException : FileSystemException
    {
        public ReadOnlyFileException(string name): base($"\"{name}\" is a Read-Only file!")
        {

        }
    }

    class FileNotSelectedException : FileSystemException
    {
        public FileNotSelectedException(): base("No file was selected!")
        {

        }
    }
}
