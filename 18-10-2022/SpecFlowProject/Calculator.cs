using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    public  class Calculator
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public int Subtract(int i, int j)
        {
            return i - j;
        }
        public int Multiply(int i, int j)
        {
            return i * j;
        }
        public int Divide(int i, int j)
        {
            return j != 0 ? i / j : 0;
        }
        public int Sqrt(int i)
        {
            return i != 0 ? (int)Math.Sqrt(i) : 0;
        }
    }
}
