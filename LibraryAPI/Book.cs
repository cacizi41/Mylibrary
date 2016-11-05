using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    /// <summary>
    /// XML Definition of Book
    /// </summary>
    public class Book
    {
        #region Properties
        [Key]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int Copies { get; set; }
        #endregion

        #region Methods
        // instance of Book, no parameter passed in
        public void Checkout()
        {
            //Count = Count - 1;
            Count--;
        }

        public void Return()
        {
            Count++;
        }
        #endregion

    }
}
