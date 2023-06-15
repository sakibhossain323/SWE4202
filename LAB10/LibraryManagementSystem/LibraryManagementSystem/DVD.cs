using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class DVD: Item
    {
        public string Director { get; set; }
        public int Length { get; set; }

        public DVD(string id, string title, string author, string category, string director, int length): base(id, title, author, category)
        {
            Director = director;
            Length = length;
        }
    }
}
