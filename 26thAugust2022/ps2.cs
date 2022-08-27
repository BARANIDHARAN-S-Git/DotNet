using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26thAugust2022
{
    internal class ps2
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of student details to enter");
            n = Convert.ToInt32(Console.ReadLine());
            studentdetails[] sdet = new studentdetails[n];
            for (int i = 0; i < sdet.Length; i++)
            {
                
                sdet[i] = new studentdetails();

                Console.WriteLine("Enter the id : ");
                sdet[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the  Name: ");
                sdet[i].name = Console.ReadLine();
                Console.WriteLine("Enter th Age: ");
                sdet[i].age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The student details you entered are : ");
            foreach (var item in sdet)
            {
                
                Console.WriteLine(item.Id);
                Console.WriteLine(item.name);
                Console.WriteLine(item.age);
                Console.WriteLine("--------------");


            }

            Console.ReadLine();



        }
    }

   

}
