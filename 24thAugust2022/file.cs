using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReusableCodelibraray
{
    public class file
    {
        public static void fl()
        {
            string path = @"C:\Users\brother\source\repos\firstFile.txt";
            File.Create(path);
        }
    }
}
