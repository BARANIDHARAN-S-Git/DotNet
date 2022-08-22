using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static int possibleways(int[] S, int m, int n)
        {
            if (n == 0)
                return 1;


            if (n < 0)
                return 0;

            if (m <= 0)
                return 0;


            return possibleways(S, m - 1, n) +
                possibleways(S, m, n - S[m - 1]);
        }
        public static void Main()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("s [] = ");
            int[] s = new int[n];
            var stringArray = Console.ReadLine().Split(' ');
            for (var i = 0; i < m; i++)
            {
                s[i] = int.Parse(stringArray[i]);
            }
            Console.WriteLine("Output = {0}", possibleways(s, m, n));
            Console.ReadLine();
        }
    }
}
