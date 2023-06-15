using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    abstract class Item
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }

        public Item(string id, string title, string author, string category)
        {
            ID = id;
            Title = title;
            Author = author;
            Category = category;
            IsAvailable = true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {ID}, Title: {Title}, Author: {Author}, Category {Category}, Available: {IsAvailable}");
        }

        public void BorrowItem() { IsAvailable = false;}
        public void ReturnItem() { IsAvailable = true;} 

    }
}
