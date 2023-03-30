using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal  abstract class Item
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }

        public Item(string iD, string title, string author, string category)
        {
            this.ID = iD;
            this.Title = title;
            this.Author = author;
            this.Category = category;
            this.IsAvailable = true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {this.ID}, Title: {this.Title}, Author: {this.Author}, Category {this.Category}, Available: {this.IsAvailable}");
        }

        public void BorrowItem() { this.IsAvailable = false;}
        public void ReturnItem() { this.IsAvailable = true;} 

    }
}
