using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class ps15
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the n");
            n=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] a = new int[n];
            Console.WriteLine("Enter the {0} Elements",n);
            for(int i = 0; i < n; i++)
            {
                a[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The first repeating element and the idex :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                
                if(count > 2 || count==2)
                {
                    Console.WriteLine("The Index is :"+(i + 1) +" "+"Elemenet is : " + a[i]);
                    break;

                }
                count = 0;
            }


        }
    }
}
