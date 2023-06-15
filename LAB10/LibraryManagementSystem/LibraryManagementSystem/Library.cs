using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Library
    {
        public List<Item> Items { get; set; } = new List<Item>();

        public Item FindItem(string itemID)
        {
            foreach(Item item in this.Items)
            {
                if (itemID == item.ID) return item;
            }

            throw new ItemNotFoundException(itemID);
        }
        
        public void AddItem(Item item)
        {
            Items.Add(item);
            Console.WriteLine($"{item.ID} Added Successfully");
        }
        
        public void RemoveItem(Item item)
        {
            Items.Remove(item);
            Console.WriteLine($"{item.ID} Removed Successfully");
        }

        public void SearchItems(string query)
        {
            int matchCount = 0;
            foreach(Item item in Items)
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
            Item item = FindItem(itemID);
            if (!item.IsAvailable) throw new ItemNotAvailableException(itemID);
            item.BorrowItem();
            Console.WriteLine($"{item.ID} Borrowed Successfully");
        }

        public void ReturnItem(string itemID)
        {
            Item item = FindItem(itemID);
            if (item.IsAvailable) throw new ItemNotBorrowedException(itemID);
            item.ReturnItem();
            Console.WriteLine($"{item.ID} Returned Successfully");
        }

        public void DisplayAvailableItems()
        {
            foreach(Item item in Items)
            {
                if (item.IsAvailable) item.DisplayDetails();
            }
        }

    }
}
