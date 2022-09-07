using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void printusername(string s);
    public  class PS2
    {
        public void print(string a)
        {
            Console.WriteLine("Hello" +" "+ a);
        }
    }
}
