using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 0,j=25; i <= 25 & j>=0; i++, j--)
            {
                if (i > j)
                {
                    Console.WriteLine("Crossed over");
                    break;

                }
                else
                {
                    Console.Write("i = "+i +"   ");
                    Console.WriteLine("j = "+j+ "  ");
                }

            }
        }
    }
}
