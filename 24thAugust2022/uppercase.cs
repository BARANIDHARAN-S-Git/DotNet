using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodelibraray
{
    public class uppercase
    {
        public static void uc(string first)
        {
            string input = first;
            string output = input.ToUpper();
            Console.WriteLine(output);
        }
    }
}
