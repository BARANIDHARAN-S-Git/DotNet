using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            number=Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            int rem;
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("The number in the reverse order is : "+reverse);
            Console.ReadLine();
        }
    }
}
