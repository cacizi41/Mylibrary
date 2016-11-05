using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnntotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Author
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        #endregion
    }
}
