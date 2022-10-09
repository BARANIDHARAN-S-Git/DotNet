using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class MemberModel
    {
        [Required()]
        public int Memberid { get; set; }

        [MaxLength(30, ErrorMessage = "Productname cannot be greater than 30 characters")]
        [MinLength(3, ErrorMessage = "Productlength cannot be lesser than 3 character")]
        public string Membername { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime AccountOpenDate { get; set; }
        public int MaximumBooksAllowed { get; set; }

        public double penaltyamount { get; set; }

    }
}