using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.WriteLine("Enter the number1 and number2");
            number1=Convert.ToInt32(Console.ReadLine());
            number2= Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = number1; i <=number2; i++)
            {
                
                sum += i;

            }
            Console.WriteLine("The sum of all integer between the {0} and {1} is : {2}",number1,number2,sum);
            Console.ReadLine();
        }
    }
}
