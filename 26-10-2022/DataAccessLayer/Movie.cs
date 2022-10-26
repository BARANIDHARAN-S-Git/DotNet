using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [MaxLength(30, ErrorMessage = "Not allowed above 30 chars")]
        [MinLength(3, ErrorMessage = "Not allowed below 3 chars")]
        public string MovieName { get; set; }   

        public string Language { get; set; }

        public string Genre { get; set; }

        public float rating { get; set; }

        public int availability { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }

    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }

        public virtual DbSet<Movie> MovieTable { get; set; }

        public virtual DbSet<User> UserTable { get; set; }

    }
}
