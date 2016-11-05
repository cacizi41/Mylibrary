﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Media
    {
        #region Properties
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Gernre { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int Copies { get; set; }
        #endregion
    }
}
