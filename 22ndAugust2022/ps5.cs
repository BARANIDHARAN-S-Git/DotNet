using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr=new int[4][];
            jagged_arr[0] = new int[] {40};
            jagged_arr[1] = new int[] {35};
            jagged_arr[2]=new int[] {45};
            jagged_arr[3]=new int[] { 60 };
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                Console.WriteLine("The classroom of the student is" + " " + (i+1) + " " + "floor");

                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.WriteLine("The number of students in the classroom is:"+jagged_arr[i][j]);
                }
            }
            Console.ReadLine();
            
        }
    }
}
