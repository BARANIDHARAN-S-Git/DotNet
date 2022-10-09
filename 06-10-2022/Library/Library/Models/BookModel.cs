using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookModel
    {
        [Required()]
        public int Book_No { get; set; }
        [MaxLength(30, ErrorMessage = "Productname cannot be greater than 30 characters")]
        [MinLength(3, ErrorMessage = "Productlength cannot be lesser than 3 character")]
        public string Book_Name { get; set; }

        public string Authorname { get; set; }

        public int price { get; set; }
    }
}