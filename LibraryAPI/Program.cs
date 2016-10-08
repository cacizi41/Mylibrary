using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            /// create a variable
            book.Title = "Intro to C#";
            book.ISBN = 123456;
            book.Price = 12.34M;
            book.Count = 5;
            book.PublishedYear = new DateTime(2010, 1, 1);

            Library.AddBook(book);

            book = new Book();
            /// reuse a variable
            book.Title = "Intro to Python";
            book.ISBN = 223456;
            book.Price = 22.89M;
            book.Count = 2;
            book.PublishedYear = new DateTime(2012, 6, 1);

            Library.AddBook(book);

            Library.PrintBooks();
        }
    }
}
