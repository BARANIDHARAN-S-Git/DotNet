using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 100;
            string input = "";
           
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter any one shown in menu");
                Console.WriteLine("Menu: \n 1)HIT \n 2)MISS");
                input=Console.ReadLine();
                if (input == "HIT" || input=="hit")
                {
                    points += 10;
                    

                }
                else if (input == "MISS" ||input=="miss")
                {
                    points -= 20;
                    
                }
                else
                {
                    Console.WriteLine("You have not entered hit or miss,please enter valid option shown in menu");
                }
                
            }
            Console.WriteLine("Points = " + points);
            Console.ReadLine();




        }
    }
}
