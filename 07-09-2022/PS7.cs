using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string  uppercase(string s);
    public class PS7
    {
        public   string upper(string s)
        {
            Console.Write("First character of the string to uppercase is : ");
            return char.ToUpper(s[0]) + s.Substring(1);


        }

    }
}
