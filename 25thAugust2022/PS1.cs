using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25thaugust2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string path = @"C:\Users\brother\source\repos\25thaugust2022\";
                Console.WriteLine("Enter the file name");
                string fname = Console.ReadLine();


                fname = string.Concat(path, fname);
                Console.WriteLine("Enter any one shown in menu");
                Console.WriteLine("\nmenu  \n1)create \n2)Add  \n3)truncate \n4)Edit");
                int input;
                input = Convert.ToInt32(Console.ReadLine());
                switch (input) {
                    case 1:
                        Console.WriteLine("--------------------------------");  

                        FileStream f = new FileStream(fname, FileMode.Create);
                        StreamWriter s = new StreamWriter(f);

                        
                        s.Close();
                        f.Close();
                        Console.WriteLine("File created successfully...");

                        break;
                    case 2:
                        Console.WriteLine("-----------------");
                        FileStream f1 = new FileStream(fname, FileMode.Append);
                        StreamWriter s1 = new StreamWriter(f1);

                        s1.WriteLine("hi this is append");
                        s1.Close();
                        f1.Close();
                        Console.WriteLine(" -----Append  successfully-----");

                        break;
                    case 3:
                        Console.WriteLine("-----------------------");
                        FileStream fs2 = new FileStream(fname, FileMode.Truncate);
                        StreamWriter ss2 = new StreamWriter(fs2);

                        ss2.WriteLine("hi all this is truncate");
                        ss2.Close();
                        fs2.Close();
                        Console.WriteLine(" ----------Truncate  successfully---------");
                        break;


                    case 4:
                        Console.WriteLine("-----------------");
                        FileStream f3 = new FileStream(fname, FileMode.Append);
                        StreamWriter s3 = new StreamWriter(f3);

                        s3.WriteLine("hi this is Edit");
                        s3.Close();
                        f3.Close();
                        Console.WriteLine(" -----Edit  successfully-----");

                        break;
                }





            }
        }


        }
    }

