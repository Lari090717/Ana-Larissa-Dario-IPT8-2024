﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bookonomie.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [ForeignKey("Book")]
        public int fk_BookId { get; set; }
        public Book Book { get; set; }
    }
}
