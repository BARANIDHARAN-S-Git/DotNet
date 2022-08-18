using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float celsius;
            Console.WriteLine("enter the celsius");
            
            celsius= Convert.ToSingle(Console.ReadLine());
            
            float kelvin;
            kelvin= celsius+ 273f;
            float fahrenheit = (1.8f * celsius) + 32;
            Console.WriteLine(kelvin);
            Console.WriteLine(fahrenheit);
        }
    }
}
