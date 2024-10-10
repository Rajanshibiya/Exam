using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRebtalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {     BookManager maneger = new BookManager();
            int choice;
            do
            {
                Console.WriteLine("Book Rental Management System:");
                Console.WriteLine("1.Add All Book");
                Console.WriteLine("2.View All Books");
                Console.WriteLine("3.Update a Book");
                Console.WriteLine("4.Delete a Book");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Choose an option:");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        break;

                    case 2:
                        BookManager.ReadBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID to update:");
                        var bookIdToUpdate = int.Parse(Console.ReadLine());
                        Console.write

                }
            }

        }


            static void AddBook(BookManager booKManeger)
            {
            Console.WriteLine("Enter Movie Id: ");
            var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Title:");
                var title = Console.ReadLine();
                Console.WriteLine("Enter Author:");
                var author = Console.ReadLine();
                Console.WriteLine("Enter Rental Price:");
                var rentalPrice = decimal.Parse(Console.ReadLine());
            bookManager.createBook(id,title, author, rentalPrice);
            }
    
            
       
          
        
        
    }
}
