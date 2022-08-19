using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("Enter the number1 and number2");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2= Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine(number1 + "it is number1 which is the biggest number");
            }
            else
            {
                Console.WriteLine(number2 + " it is number2 which is the biggest number");
            }
            
        }
    }
}
