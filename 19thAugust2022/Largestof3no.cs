using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,number2,number3;
            Console.WriteLine("enter the number1,number2,number3");
            number1=Convert.ToInt32(Console.ReadLine());
            number2=Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine("The number 1 that is " + number1 +" " + "the largest number");
                }
                else
                {
                    Console.WriteLine("The number 3 that is " + number3 +" "+ "the largest number");
                }
            }
            else if(number2>number3)
            {
                Console.WriteLine("The number 2 that is " + number2+ " " + "the largest number");

            }
            else
            {
                Console.WriteLine("The number 3 that is " + number3 + " "+ "the largest number");
            }
        }
    }
}
