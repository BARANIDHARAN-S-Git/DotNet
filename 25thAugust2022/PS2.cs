using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25thaugust2022
{
    internal class PS2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any one in menu shown below");
            Console.WriteLine("\nMenu \n1)create a file \n2)Copy that file to a same folder with different filename \n3)Copy that file to a different folder as well \n4)Move the file \n5)Delete a file  \n6)Find the extension of the file \n7) Find the creation date time of the file  \n8)Find the Directory of the file");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:

                    string path = @"C:\Users\brother\Desktop\demo\";
                    Console.WriteLine("Enter the file name");
                    string fname = Console.ReadLine();
                    fname = string.Concat(path, fname);

                    File.Create(fname);
                    Console.WriteLine("File created successfully...");
                    break;

                case 2:
                    Console.WriteLine("-------------");
                    Console.WriteLine("The copy the file to a same folder with differnet file name");
                    string path1 = @"C:\Users\brother\Desktop\demo\";
                    Console.WriteLine("Enter the file name");
                    string fname1 = Console.ReadLine();
                    fname = string.Concat(path1, fname1);
                    File.Copy(@"C:\Users\brother\Desktop\demo\new.txt", path1+fname1);
                    Console.WriteLine("file copied successful");
                    break;


                case 3:
                    Console.WriteLine("-------------");
                    Console.WriteLine(" Copy that file to a different folder");
                    File.Copy(@"C:\Users\brother\Desktop\demo\new.txt", @"C:\Users\brother\Desktop\practice\demo.txt");
                    Console.WriteLine("file copied to different folder successfully");
                    break;





                case 4:
                    Console.WriteLine("-------------");
                    Console.WriteLine("To move the file");
                    File.Move(@"C:\Users\brother\Desktop\demo\new.txt", @"C:\Users\brother\Desktop\practice\newone.txt");
                    Console.WriteLine("file moved successfully");
                    break;

                case 5:

                    Console.WriteLine("-------------");
                    Console.WriteLine("To delete the file");
                    string path2 = @"C:\Users\brother\Desktop\demo\";
                    Console.WriteLine("Enter the file name");
                    string fname2 = Console.ReadLine();
                    fname2=String.Concat(path2, fname2);    
                    File.Delete(fname2);
                    Console.WriteLine("The file deleted successfully");

                    break;

                case 6:

                    Console.WriteLine("-------------");
                    Console.WriteLine("  the extension of the file");
                    string path3 = @"C:\Users\brother\Desktop\demo\";
                    Console.WriteLine("Enter the file name");
                    string fname3 = Console.ReadLine();
                    fname2 = String.Concat(path3, fname3);
                    FileInfo f=new FileInfo(fname2);
                    Console.WriteLine("The extension of the file is : " + f.Extension);
                    break;
                case 7:
                    Console.WriteLine("-------------");
                    Console.WriteLine("  the creation  time of the file");
                    string path4 = @"C:\Users\brother\Desktop\demo\";
                    Console.WriteLine("Enter the file name");
                    string fname4 = Console.ReadLine();
                    fname2 = String.Concat(path4, fname4);
                    FileInfo f1 = new FileInfo(fname4);
                    Console.WriteLine("The creation time is : "+f1.CreationTime);

                    break;
                case 8:
                    Console.WriteLine("-------------");
                    Console.WriteLine("the Directory of the file");
                    string path5 = @"C:\Users\brother\Desktop\demo\";
                    Console.WriteLine("Enter the file name");
                    string fname5 = Console.ReadLine();
                    fname5 = String.Concat(path5, fname5);
                    FileInfo f2 = new FileInfo(fname5);
                    Console.WriteLine("The directory of the filr is : " + f2.Directory);

                    break;


            }
            Console.ReadLine();


        }
    }
}
