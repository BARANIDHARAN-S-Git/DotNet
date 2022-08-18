using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstno = 5;
            int secondno=6;
            swapbyvalue(firstno, secondno);
            swapbyreference(ref firstno, ref secondno);
            
        }
        static void swapbyvalue(int firstno,int secondno)
        {

            int thirdno = firstno;
            firstno = secondno;
            secondno = thirdno;
            Console.WriteLine("firstno:" + firstno);
            Console.WriteLine("secondno:" + secondno);

        }
        static void swapbyreference(ref int firstno,ref  int secondno)
        {

            int thirdno = firstno;
            firstno = secondno;
            secondno = thirdno;
            Console.WriteLine("firstno:" + firstno);
            Console.WriteLine("secondno:" + secondno);

        }
    }
}
