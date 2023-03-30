using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryException: Exception
    {
        public LibraryException() { }
        public LibraryException(string message) : base(message) { }
    }
}
