using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter the number1 and number2");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = number1; i <= number2; i++)
            {
                if (i % 9 == 0)
                {
                    
                    Console.Write(i);
                    Console.WriteLine();
                    sum += i;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("the sum of all integer between {0} and {1} which are divisble by 9 is : {2}",number1,number2,sum);
            Console.ReadLine();
        }
    }
}
