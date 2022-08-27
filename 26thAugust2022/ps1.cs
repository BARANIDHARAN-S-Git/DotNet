using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26thAugust2022
{


    public struct Students
    {
        public int Id;
        public string Name;
        public int Age;
        public int Standard;


        public void setstudentsdetails(int id, string name, int age, int standard)
        {
            Id = id;
            Name = name;
            Age = age;
            Standard = standard;

        }
        public void displaystudentsdetails()
        {
            Console.WriteLine("The students details");
            Console.WriteLine("The id is : " + Id);
            Console.WriteLine("The Name of the student is : " + Name);
            Console.WriteLine("The Age of the student is : " + Age);
            Console.WriteLine("The standard of the student is : " + Standard);
            Console.WriteLine("--------------------");


        }
    }
    internal class ps1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of student details to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            Students[] stud=new Students[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the id of the student");
                stud[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Naame of the student");
                stud[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the Age of the student");
                stud[i].Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the standard of the student");
                stud[i].Standard = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------");
               

            }

            for(int i = 0; i < n; i++)
            {
                stud[i].displaystudentsdetails();
            }
            Console.ReadLine();

            
        }

        
    }
}
