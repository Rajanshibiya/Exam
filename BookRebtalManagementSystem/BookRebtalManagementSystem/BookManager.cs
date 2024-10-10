using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRebtalManagementSystem
{
    internal class BookManager
    {
        private List<Book> books = new List<Book>();
        private int nextId = 1;

        public void createBook(int id, string title, string author, decimal price)
        {
            var book = new Book();
          
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }
        public void RentalBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }
            Console.WriteLine("Books available:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void UpdateBook(int bookId, string newTitle,string newAuthor,decimal newRentalPrice)
        {
            var book=books.FirstOrDefault(b=>b.BookId == bookId);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}
