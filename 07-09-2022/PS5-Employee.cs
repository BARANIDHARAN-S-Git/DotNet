using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void jyear(); 
    public class PS5_Employee
    {

        public int year;

        public int joiningyear
        {
            get { return year; }
            set { year = value; }
        }

        DateTime d = DateTime.Now;
        public void yearofservice()
        {
            int a = d.Year-this.year;
            Console.WriteLine("The Year Of Service is : " + a);
        }
    }
}
