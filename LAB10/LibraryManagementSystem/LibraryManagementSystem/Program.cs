using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;
            

            while (!exit)
            {
                Console.WriteLine("----- Library Management System -----");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Search Items");
                Console.WriteLine("4. Borrow Item");
                Console.WriteLine("5. Return Item");
                Console.WriteLine("6. Display Available Items");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("----- Add Item -----");

                        Console.Write("Enter Item ID: ");
                        string itemId = Console.ReadLine();
                        Console.Write("Enter Item Title: ");
                        string itemTitle = Console.ReadLine();
                        Console.Write("Enter Item Author: ");
                        string itemAuthor = Console.ReadLine();

                        bool invalidCategory = true;
                        while(invalidCategory)
                        {
                            invalidCategory = false;
                            Console.WriteLine("1. Book");
                            Console.WriteLine("2. DVD");
                            Console.WriteLine("3. CD");
                            Console.WriteLine("Select Item Category:");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Write("Enter Book ISBN: ");
                                    string bookISBN = Console.ReadLine();
                                    Console.Write("Enter Book Number of Pages: ");
                                    int bookNumPages = int.Parse(Console.ReadLine());

                                    Book book = new Book(itemId, itemTitle, itemAuthor, "Book", bookISBN, bookNumPages);
                                    library.AddItem(book);
                                    break;
                                case "2":
                                    Console.Write("Enter DVD Director: ");
                                    string dvdDirector = Console.ReadLine();
                                    Console.Write("Enter DVD Length (minutes): ");
                                    int dvdLength = int.Parse(Console.ReadLine());

                                    DVD dvd = new DVD(itemId, itemTitle, itemAuthor, "DVD", dvdDirector, dvdLength);
                                    library.AddItem(dvd);
                                    break;
                                case "3":
                                    Console.Write("Enter CD Artist: ");
                                    string cdArtist = Console.ReadLine();
                                    Console.Write("Enter CD Number of Tracks: ");
                                    int cdNumTracks = int.Parse(Console.ReadLine());

                                    CD cd = new CD(itemId, itemTitle, itemAuthor, "CD", cdArtist, cdNumTracks);
                                    library.AddItem(cd);
                                    break;
                                default:
                                    Console.WriteLine("Invalid Item Category.");
                                    invalidCategory = true;
                                    break;
                            }
                        }

                        break;
                    case "2":
                        Console.WriteLine("----- Remove Item -----");
                        Console.Write("Enter Item ID: ");
                        string removeItemId = Console.ReadLine();

                        try
                        {
                            Item removeItem = library.FindItem(removeItemId);
                            library.RemoveItem(removeItem);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "3":
                        Console.WriteLine("----- Search Items -----");
                        Console.Write("Enter search query: ");
                        string searchQuery = Console.ReadLine();

                        library.SearchItems(searchQuery);

                        break;
                    case "4":
                        Console.WriteLine("----- Borrow Item -----");
                        Console.Write("Enter Item ID: ");
                        string borrowItemId = Console.ReadLine();

                        try
                        {
                            library.BorrowItem(borrowItemId);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "5":
                        Console.WriteLine("----- Return Item -----");
                        Console.Write("Enter Item ID: ");
                        string returnItemId = Console.ReadLine();

                        try
                        {
                            library.ReturnItem(returnItemId);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "6":
                        Console.WriteLine("----- Available Items -----");
                        library.DisplayAvailableItems();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Exiting Library Management System...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
