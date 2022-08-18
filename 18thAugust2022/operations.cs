using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        { int firstno, secondno;
            Console.WriteLine("enter first and second no");
            firstno = Convert.ToInt32(Console.ReadLine());
            secondno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstno + secondno);
            Console.WriteLine(firstno - secondno);
            Console.WriteLine(firstno * secondno);
            Console.WriteLine(firstno / secondno);
            Console.WriteLine(firstno % secondno);
        }
    }
}
