
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class CD: Item
    {
        public string Artist { get; set; }
        public int  NumTracks { get; set; }

        public CD(string id, string title, string author, string category, string artist, int numTracks) :base(id, title, author, category)
        {
            Artist = artist;
            NumTracks = numTracks;
        }
    }
}
