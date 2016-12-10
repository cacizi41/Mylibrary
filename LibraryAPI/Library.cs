using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryAPI
{
    public enum Rentaltypes
    {
        Book,
        Audio,
        Video
    }
    public static class Library
    /// Everything needs to be static
    {
        #region Properties
        public static string Name { get; set; }

        public static string Address { get; set; }
        /// <summary>
        /// data type: collections of books, list is a collection type
        /// </summary>
        /// public static List<Book> Books { get; set; }
        #endregion


        #region Methods
        public static void AddBook(Book book)
        {
            /// open new connection
            /// using statement closes connection
            using (var model = new LibraryModel())
            {
                model.Books.Add(book);
                model.SaveChanges();
            }
                


        }

        public static List<Book> GetBooks()
        {
            ///connect to db
            using (var model = new LibraryModel())
            {
                var books = model.Books.Include("Author");
                return books.ToList<Book>();
            }
                
        }

        public static int BorrowBook(int id, string emailAddress)
        {
            using (var model = new LibraryModel())
            {
                var account = model.Accounts.Where(a => a.EmailAddress == emailAddress).FirstOrDefault();
                if (account == null)
                {
                    account = new Account();
                    account.EmailAddress = emailAddress;
                    model.Accounts.Add(account);
                    model.SaveChanges();
                }
                var rental = new Rental();
                rental.AccountId = account.AccountId;
                rental.RentalType = Rentaltypes.Book;
                rental.Id = id;
                model.Rentals.Add(rental);
                model.SaveChanges();
                return rental.RentalId;
            }
        }
        #endregion
    }

}
