using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s=null;
            if (string.IsNullOrEmpty(s))
            {
                bool output= true;
                Console.WriteLine(output);
            }
            else
            {
                bool output = false;
                Console.WriteLine(false);
            }
        }
    }
}
