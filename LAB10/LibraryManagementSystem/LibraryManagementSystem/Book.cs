﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Book: Item
    {
        public string ISBN { get; set; }
        public int NumPages { get; set; }
        public Book(string id, string title, string author, string category, string isbn, int numPages) : base(id, title, author, category)
        {
            ISBN= isbn;
            NumPages = numPages;
        }
    }
}
