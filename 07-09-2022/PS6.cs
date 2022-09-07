using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string concatenate(string s1, string s2);
    public  class PS6
    {
        public string conc(string s1,string s2)
        {
            Console.Write("Concatenation of two string {0} and {1} is : ", s1, s2);
            return string.Concat(s1,s2);
        }
        
    }
}
