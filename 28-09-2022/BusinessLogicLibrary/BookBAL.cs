using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class BookBAL
    {
        public int Book_No { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }

        public Nullable<decimal> cost { get; set; }
        public string category { get; set; }
    }
}
