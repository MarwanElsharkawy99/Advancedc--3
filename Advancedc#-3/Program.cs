using Advancedc__3;

internal class Program
{
    private static void Main(string[] args)
    {
        #region question 1
        //    List<Book> books = new List<Book>
        //    {
        //        new Book("978-0-306-40615-7", "The C Programming Language", new string[] { "Brian W. Kernighan", "Dennis M. Ritchie" }, new DateTime(1978, 2, 22), 9.99m),
        //        new Book("978-0-07-180799-2", "C# 5.0 in a Nutshell", new string[] { "Joseph Albahari", "Ben Albahari" }, new DateTime(2012, 6, 9), 34.99m),
        //        new Book("978-0-13-110362-7", "The C++ Programming Language", new string[] { "Bjarne Stroustrup" }, new DateTime(1985, 10, 19), 39.99m),
        //        new Book("978-0-321-56384-2", "The C++ Standard Library", new string[] { "Nicolai M. Josuttis" }, new DateTime(1999, 10, 20), 39.99m),
        //        new Book("978-0-321-63568-7", "C++ Primer", new string[] { "Stanley B. Lippman", "Josée Lajoie", "Barbara E. Moo" }, new DateTime(2012, 8, 16), 49.99m),
        //        new Book("978-0-321-99278-9", "Effective C++", new string[] { "Scott Meyers" }, new DateTime(2005, 5, 22), 39.99m),
        //        new Book("978-0-321-33487-9", "Effective Modern C++", new string[] { "Scott Meyers" }, new DateTime(2014, 12, 5), 49.99m),
        //        new Book("978-0-321-25619-2", "More Effective C++", new string[] { "Scott Meyers" }, new DateTime(1996, 6, 18), 39.99m)




        //};


        //    BookFunctions.ProcessBooks(books, BookFunctions.GetTitle);
        //    Console.WriteLine();
        //    BookFunctions.ProcessBooks(books, BookFunctions.GetAuthor);
        //    Console.WriteLine();
        //    BookFunctions.ProcessBooks(books, delegate (Book book) { return book.ISBN; });
        //    Console.WriteLine();
        //    BookFunctions.ProcessBooks(books, book => book.PublicationDate.ToString("yyyy-MM-dd"));

        #endregion
        #region Question2
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        CustomList<int> num = new CustomList<int>( list);
     
        Console.WriteLine(num.Exists(x => x == 3));
        Console.WriteLine(num.Find(x => x == 5));
        Console.WriteLine(num.FindIndex(x => x == 3));
        Console.WriteLine(num.FindAll(x => x > 2));
        num.ForEach(x => Console.WriteLine(x));

        #endregion


    }
}