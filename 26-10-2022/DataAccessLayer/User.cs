using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class User
    {
        [Key]
        public int UserId { get; set; }

        public string Password { get; set; }

        public string category { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
