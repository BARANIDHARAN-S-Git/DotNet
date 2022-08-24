using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodelibraray
{
    public class indexofmethod
    {
        public static void iom(string first)
        {
            int index = first.IndexOf('a');
            int index1 = first.IndexOf('n');
            Console.WriteLine("The indexof {0} in {1} is : {2}", 'a', first, index);
            Console.WriteLine("The indexof {0} in {1} is : {2}", 'n', first, index1);

        }
    }
}

