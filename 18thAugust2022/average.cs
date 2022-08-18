using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstno, secondno, thirdno, fourthno;
            Console.WriteLine("enter the firstno,secondno,thirdno,fourthno");
            firstno =Convert.ToInt32(Console.ReadLine());
            secondno = Convert.ToInt32(Console.ReadLine());
            thirdno = Convert.ToInt32(Console.ReadLine());
            fourthno = Convert.ToInt32(Console.ReadLine());
            float sum=firstno + secondno + thirdno + fourthno;
            float answer = sum / 4;
            Console.WriteLine(answer);
        }
    }
}
