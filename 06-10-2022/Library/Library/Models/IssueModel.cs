using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class IssueModel
    {
        [Required()]
        public int Lib_Issue_Id { get; set; }
      
        public int Book_No{ get; set; }

        public int Member_Id { get; set; }

       
    }
}