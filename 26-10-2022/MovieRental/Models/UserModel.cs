using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class UserModel
    {
        [Required]
        public int UserId { get; set; }

        public string Password { get; set; }

        public string category { get; set; }

        public virtual ICollection<MovieModel> Movies { get; set; }
    }
}