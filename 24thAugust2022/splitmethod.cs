using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodelibraray
{
    public class splitmethod
    {
        public static void Split()

        {

            string input = "Welcome to the world of c# Programming";
            string[] separate = { "#" };
            string[] output = input.Split(separate, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in output)
            {
                Console.WriteLine(s);
            }

        }
    }
}
