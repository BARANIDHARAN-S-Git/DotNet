using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void lengthdelegate(string s);
    public class PS1
    {
        public void length(string s)
        {
          
            int a = s.Length;

            Console.WriteLine("The length of the string ({0}) is : {1} ",s,a);
        }

    }
}
