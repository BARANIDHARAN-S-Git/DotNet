using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30thAugust2022
{
    internal class Quicksort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Enter the Element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your entered input is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
           
            QuickSort(arr, 0, arr.Length - 1);
            int n = arr.Length;
            PrintsortedArray(arr, n);
            Console.Read();
        }

        private static void PrintsortedArray(int[] arr, int n)
        {
            Console.WriteLine("------------sorted-------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int p = makePart(arr, start, end);
                QuickSort(arr, start, p - 1);
                QuickSort(arr, p + 1, end);

            }

        }

        private static int makePart(int[] arr, int start, int end)
        {
           
            int pivot = arr[end];
            int i = (start - 1);
            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;

                }
            }
            int temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return (i + 1);
        }
    }
}
