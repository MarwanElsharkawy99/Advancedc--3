using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancedc__3
{
    public class Book
    {
        public String ISBN { get; set; }
        public String Title { get; set; }
        public String[] Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }  

        public Book(String isbn, String title, String[] author, DateTime publicationDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
        }
        public override string ToString()
        {
            return "ISBN: " + ISBN + "\nTitle: " + Title + "\nAuthor: " + string.Join(", ", Author) + "\nPublication Date: " + PublicationDate + "\nPrice: " + Price;
        }


    }
}
