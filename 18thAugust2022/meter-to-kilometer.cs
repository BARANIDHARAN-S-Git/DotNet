using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meter;
            Console.WriteLine("enter the meter");
            meter=Convert.ToInt32(Console.ReadLine());
            float kilometer;
            kilometer = meter / 1000f;
            Console.WriteLine("the kilometer is"+kilometer);
            Console.WriteLine("the meter is" + kilometer * 1000);


        }
    }
}
