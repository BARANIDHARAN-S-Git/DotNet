using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodelibraray
{
    public class Dayproperties
    {
        public static void dp()
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            Console.WriteLine("The year is : " + d.Year);
            Console.WriteLine("The month is : " + d.Month);
            Console.WriteLine("The day is : " + d.Day);
            Console.WriteLine("The hour is : " + d.Hour);
            Console.WriteLine("The minute is : " + d.Minute);
            Console.WriteLine("The second is : " + d.Second);
            Console.WriteLine("The millisecond is : " + d.Millisecond);
            Console.ReadLine();

        }
    }
}
