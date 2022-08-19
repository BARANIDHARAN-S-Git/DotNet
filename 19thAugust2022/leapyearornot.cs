using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year to find leap year or not");
            year=Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year%4==0 || year%100==0)
            {
                Console.WriteLine(year + "is the leap year");
            }
            else
            {
                Console.WriteLine(year + "is not a leap year");
            }
        }
    }
}
