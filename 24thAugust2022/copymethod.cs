using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodelibraray
{
    public class copymethod
    {
        public static void Cm(string first)
        {
            string str1 = first;
            string str2 = "";
            str2 = string.Copy(str1);

            Console.WriteLine("The first input is :" + str1);
            Console.WriteLine("The second one copied from first is : " + str2);

        }
    }
}
