using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter the first,second and third");
            x=Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z= Convert.ToInt32(Console.ReadLine());
            int first = (x + y)*z;
            int second = (x * y) +(y * z);
            Console.WriteLine("The result of the specified numbers (x+y).z is "+ first);
            Console.WriteLine("The result of the specified numbers x.y+y.z is "+ second);
        }
    }
}
