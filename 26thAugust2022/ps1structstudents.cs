using System;
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
}
