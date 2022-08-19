using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Physics, Chemistry, Maths;
            Console.WriteLine("Enter the physics mark");
            Physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry mark");
            Chemistry=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maths mark");
            Maths=Convert.ToInt32(Console.ReadLine());
            int totalmarks;
            totalmarks=Physics+Chemistry+Maths;
            Console.WriteLine("The total marks obtained in the three subjects is" + totalmarks);
            float percentage;
            percentage = totalmarks / 100;
            if (percentage < 35)
            {
                Console.WriteLine("Sorry,It's Fail percentage");
            }
            else if(percentage>35 & percentage<45) {
                Console.WriteLine("It's Third Rank");

            }
            else if(percentage>45 & percentage < 60)
            {
                Console.WriteLine("It's Second Rank");
            }
            else
            {
                Console.WriteLine("It's First Rank");
            }

        }
    }
}
