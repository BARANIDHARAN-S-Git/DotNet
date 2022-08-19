using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.WriteLine("Enter the str1 and str2");
            str1=Convert.ToString(Console.ReadLine());
            str2 = Convert.ToString(Console.ReadLine());
            if(str1== str2)
            {
                Console.WriteLine("str1 and str2 are equal");
            }
            else
            {
                Console.WriteLine("str1 and str2 are not equal");

            }
            Console.ReadLine();
        }
    }
}
