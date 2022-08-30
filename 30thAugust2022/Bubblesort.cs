using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30thAugust2022
{
    internal class Bubblesort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your entered input is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            bubbleSort(arr);
            Console.Read();
        }
        static void bubbleSort(int[] arr)
        {

            int temp;
            for (int i = 0; i < (arr.Length) - 1; i++)
            {
                for (int j = 0; j < (arr.Length - 1) - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("------------Sorted------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }

    }
}
