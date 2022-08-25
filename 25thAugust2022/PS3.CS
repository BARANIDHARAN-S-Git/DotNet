using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25thaugust2022
{
    internal class PS3
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\brother\source\repos\25thaugust2022");
            DirectoryInfo di = new DirectoryInfo("Results");
            DirectoryInfo dis = di.CreateSubdirectory("Results17-18");
            DirectoryInfo dis1 = di.CreateSubdirectory("Results18-19");
            DirectoryInfo dis2 = di.CreateSubdirectory("Results20-21");


           
            Console.WriteLine("directory and subdirectories created successfully");


            
            
            string docPath = @"C:\Users\brother\source\repos\25thaugust2022\bin\Debug\Results";

            List<string> direc = new List<string>(Directory.EnumerateDirectories(docPath));

            foreach (var d in direc)
            {
                Console.WriteLine("{0}", d.Substring(d.LastIndexOf("\\") + 1));
            }
            Console.WriteLine($"{direc.Count} directories found.");



            string[] fnames = Directory.GetDirectories(@"C:\Users\brother\source\repos\25thaugust2022\bin\Debug\Results");
            Console.WriteLine(fnames[0]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    string s = Console.ReadLine();
                    string p = string.Concat(fnames[i], s);
                    File.Create(@p);

                }
            }

            for (int i = 0; i < 3; i++)
            {
                DirectoryInfo dinfo = new DirectoryInfo(fnames[i]);
                for (int j = 0; j < 12; j++)
                {
                    var m = (Months)j;
                    string b = m.ToString();
                    dinfo.CreateSubdirectory(b);
                    Console.ReadLine();

                }
            }
           
        }
        enum Months
        {
            Jan = 1,
            Feb,
            Mar,
            Apr,
            May,
            June,
            July,
            Aug,
            Sep,
            Oct,
            Nov,
            Dec
        }

        

    }
}

