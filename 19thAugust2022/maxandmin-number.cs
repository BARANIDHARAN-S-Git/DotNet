using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no1, no2;
            Console.WriteLine("enter the no1 and no2");
            no1=Convert.ToInt32(Console.ReadLine());
            no2=Convert.ToInt32(Console.ReadLine());
            if (no1 > no2) {
                Console.WriteLine(no1 + "is no1 and it is maximum number");
                Console.WriteLine(no2 + "is no2 and it is minimum number");

            }
            else
            {
                Console.WriteLine(no2 + "is no2 and it is maximum number");
                Console.WriteLine(no1 + "is no1 and it is minimum number");

            }
        }
    }
}
