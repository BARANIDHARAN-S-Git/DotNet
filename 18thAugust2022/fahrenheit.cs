using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            Console.WriteLine("enter the celsius");
            celsius=Convert.ToInt32(Console.ReadLine());
            float fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("the fahrenheit is"+" "+ fahrenheit);
        }
    }
}
