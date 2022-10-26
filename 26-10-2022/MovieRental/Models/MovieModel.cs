using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class MovieModel
    {
        [Required]
        public int MovieId { get; set; }

        [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
        [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
        public string MovieName { get; set; }

        public string Language { get; set; }

        public string Genre { get; set; }

        public float rating { get; set; }

        public int availability { get; set; }

        public virtual ICollection<UserModel> Users { get; set; }
    }
}