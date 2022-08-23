using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps4
    {
        static void Main(string[] args)
        {
            employee e=new employee();
            e.acceptdata(101, "Alex", 12000, 3);
            e.display();
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
