using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _6thOctober2022.Models
{
    public class ProductModel
    {
        [Required()]
        public int productid { get; set; }

        [MaxLength(30,ErrorMessage ="Productname cannot be greater than 30 characters")]
        [MinLength(4,ErrorMessage ="Productlength cannot be lesser than 3 character")]
        public string productname { get; set; }

        public double price { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Mfgdate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Expdate { get; set; }
    }   

}