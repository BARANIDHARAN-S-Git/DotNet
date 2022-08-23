using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps5
    {
        static void Main(string[] args)
        {
            employee[] empdet = new employee[4];
            for(int i = 0; i < 4; i++)
            {
                empdet[i] = new employee();
                Console.WriteLine("Enter the Employeenumber");
                int Employeenumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employeename");
                string  Employeename=Console.ReadLine();
                Console.WriteLine("Enter the Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Departmentnumber");
                int Departmentnumber = Convert.ToInt32(Console.ReadLine());
                empdet[i].acceptdata(Employeenumber, Employeename, salary, Departmentnumber);
            }

            for(int i = 0; i < 4; i++)
            {
                empdet[i].display();
                Console.WriteLine(" ");
            }
        }
        struct employee
        {
            public int employeenumber;
            public string employeename;
            public int salary;
            public int departmentnumber;

            public void acceptdata(int employeenumber, string employeename, int salary, int departmentnumber)
            {
                this.employeenumber = employeenumber;
                this.employeename = employeename;
                this.salary = salary;
                this.departmentnumber = departmentnumber;

            }
            public void display()
            {
                Console.WriteLine("Employeenumber : " + employeenumber);
                Console.WriteLine("Employeename : " + employeename);
                Console.WriteLine("Salary : " + salary);
                Console.WriteLine("Departmentnumber : " + departmentnumber);

            }
        }
    }
}
