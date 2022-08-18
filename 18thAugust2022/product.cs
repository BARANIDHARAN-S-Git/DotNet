using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstno, secondno, thirdno, output;
            Console.WriteLine("enter a,b,c");
            firstno=Convert.ToInt32(Console.ReadLine());
            secondno = Convert.ToInt32(Console.ReadLine());
            thirdno = Convert.ToInt32(Console.ReadLine());
            output = firstno * secondno * thirdno;
            Console.WriteLine(output);

        }
    }
}
