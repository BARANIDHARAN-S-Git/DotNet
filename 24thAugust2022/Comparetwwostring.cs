using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodelibraray
{
    public class Comparetwwostring
    {
        public static void twostring(string first, string second)
        {
            int len1 = first.Length;
            int len2 = second.Length;
            if (len1 == len2)
            {
                Console.WriteLine("Both the string first and second are same length");
            }
            else if (len1 > len2)
            {
                Console.WriteLine("The first string length is larger then the second string length");

            }
            else if (len2 > len1)
            {
                Console.WriteLine("The second string length is larger then the first string length");

            }

        }
    }
}
