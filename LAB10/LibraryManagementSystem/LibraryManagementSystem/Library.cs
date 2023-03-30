using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        public List<Item> Items { get; set; } = new List<Item>();

        public Item FindItem(string itemID)
        {
            foreach(Item item in this.Items)
            {
                if (itemID == item.ID) return item;
            }

            throw new LibraryException("Item not found");
        }
        
        public void RemoveItem(Item item)
        {
            this.Items.Remove(item);
        }

        public void SearchItem(string query)
        {
            int matchCount = 0;
            foreach(Item item in this.Items)
            {
                if(item.Title == query || item.Author == query || item.Category == query)
                {
                    item.DisplayDetails();
                    matchCount++;
                }
            }

            Console.WriteLine($"{matchCount} matche(s) found");
        }

        public void BorrowItem(string itemID)
        {
            Item item = this.FindItem(itemID);
            if (!item.IsAvailable) throw new LibraryException("This item is not available");
            item.IsAvailable = false;
        }

        public void ReturnItem(string itemID)
        {
            Item item = this.FindItem(itemID);
            if (item.IsAvailable) throw new LibraryException("This item is not borrowed yet");
            item.IsAvailable = true;
        }

        public void DisplayAvailableItems()
        {
            foreach(Item item in this.Items)
            {
                if (item.IsAvailable) item.DisplayDetails();
            }
        }

    }
}
