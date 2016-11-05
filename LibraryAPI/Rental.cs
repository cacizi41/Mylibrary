﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }

        public Rentaltypes RentalTypes { get; set; }

        public int Id { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
