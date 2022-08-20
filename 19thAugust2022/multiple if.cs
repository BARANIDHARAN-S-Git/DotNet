using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter the input");
            input=Convert.ToInt32(Console.ReadLine());
            if (input<100)
            {
                if (input % 2 != 0)
                {
                    Console.WriteLine("The number is odd and the number is : " + input);

                }
                else if (input % 2 == 0 &input!=0)
                {
                    Console.WriteLine("The number is even and the number is :" + input);

                    if (input % 10 == 0 &input!=0)
                    {
                        Console.WriteLine("The number is multiple of 10 and the number is :" + input);

                    }
                }

                else if (input == 0)
                {
                    Console.WriteLine("The number is Zero");
                }




            }
            else
            {
                if (input > 100)
                {
                    Console.WriteLine("The number is greater than 100 and the number is : "+ input);
                }

            }
        }
    }
}
