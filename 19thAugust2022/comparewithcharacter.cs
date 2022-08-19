using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1;
            char ch2;
            Console.WriteLine("Enter the ch1 and ch2");
            ch1 = Convert.ToChar(Console.ReadLine());
            ch2 = Convert.ToChar(Console.ReadLine());
            if (ch1 == ch2)
            {
                Console.WriteLine("ch1 and ch2 are equal");
            }
            else
            {
                Console.WriteLine("ch1 and ch2 are not equal");
            }
            Console.ReadLine();
        }
    }
}
