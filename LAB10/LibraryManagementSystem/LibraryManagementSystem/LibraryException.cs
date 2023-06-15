using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class LibraryException: Exception
    {
        public LibraryException(string message) : base(message) 
        {

        }
    }

    class ItemNotFoundException : LibraryException
    {
        public ItemNotFoundException(string id): base($"{id} is not found")
        {

        }
    }

    class ItemNotAvailableException : LibraryException
    {
        public ItemNotAvailableException(string id) : base($"{id} is not available to borrow")
        {

        }
    }

    class ItemNotBorrowedException : LibraryException
    {
        public ItemNotBorrowedException(string id) : base($"{id} is not borrowed yet.")
        {

        }
    }
}
