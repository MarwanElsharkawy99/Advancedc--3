using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancedc__3
{
    public delegate string BookDelegate(Book book);
    public class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book.Title;
        }
        public static string GetAuthor(Book book)
        {
            return string.Join(", ", book.Author);
        }
        public static decimal GetPrice(Book book)
        {
            return book.Price;
        }
        public static void ProcessBooks(List<Book> books, BookDelegate bookDelegate)
        {
            foreach (var book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }

    }
}
