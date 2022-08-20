using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input;
            Console.WriteLine("Enter the input");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input>100) 
            {
                case true:
                    {
                        Console.WriteLine("The number is greater than 100");
                        break;
                    }
                case false:
                    
                        
                        switch (input == 0)
                        {
                            case true:
                                
                                    Console.WriteLine("The number is zero");
                                     break;
                            case false:
                            {

                                if (input % 2 == 0)
                                {
                                    Console.WriteLine("The number is even");
                                    if (input % 10 == 0)
                                    {
                                        Console.WriteLine("The number is the multiple of 10");
                                        break;
                                    }
                                }
                                else if(input%2!=0)
                                {
                                    Console.WriteLine("The number is odd");
                                }
                                
                                break;
                            }
                        }
                    break;
                
             }

        }
    }
}
