using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float usdollar;
            Console.WriteLine("enter th us dollar");
            usdollar=Convert.ToSingle(Console.ReadLine());
            float IndianRupee = usdollar * 79.60f;
            Console.WriteLine("The IndianRupee is"+" "+IndianRupee);
        }
    }
}
