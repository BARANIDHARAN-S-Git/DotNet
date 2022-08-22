using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class ps12
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the n-Size of array");
            n=Convert.ToInt32(Console.ReadLine());
            
            int[]array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the array- {0}",i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {


                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
                Console.WriteLine("The maximum Element in an array is :" + max);
                Console.WriteLine("The minimum Element in array is :" + min);
                Console.ReadLine();
            
        }
    }
}
