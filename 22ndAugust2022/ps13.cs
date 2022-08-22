using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class ps13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 35, 200, 22, 2244, 213, 111 };
            int number = 100;
            int length = arr.Length;
            int count = 0;
            Console.WriteLine("The number greater than 100 are :");
            for(int i = 0; i < length; i++)
            {
                
                if (arr[i] > 100) {
                    Console.WriteLine(arr[i]);
                    count++;
                }
            }
            Console.WriteLine("The count of the Element greater than 100 is " + count);
        }
    }
}
