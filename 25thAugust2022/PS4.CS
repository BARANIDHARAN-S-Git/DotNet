using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25thaugust2022
{
    internal class PS4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("C drive info");
            DriveInfo info = new DriveInfo("C");
            Console.WriteLine(info.Name);
            Console.WriteLine(info.TotalSize);
            Console.WriteLine(info.DriveType);
            Console.WriteLine(info.DriveFormat);
            Console.WriteLine("----------------------------");
            Console.WriteLine("List All Available Disk Drives");
            DriveInfo[] dinfo = DriveInfo.GetDrives();
            foreach (var item in dinfo)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.TotalSize);
                Console.WriteLine(item.DriveType);
                Console.WriteLine(item.DriveFormat);
                
            }
        }
    }
}
