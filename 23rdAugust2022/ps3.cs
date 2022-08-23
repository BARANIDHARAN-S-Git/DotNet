using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps3
    {
        static void Main(string[] args)
        {
           

            employee emp = new employee();
            Console.WriteLine("Enter Employeenumber");
            emp.employeenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Departmentnumber");
            emp.departmentnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employeename");
            emp.employeename = Console.ReadLine();
            Console.WriteLine("The employee number is :" + emp.Employeenumber);
            Console.WriteLine("The department number is :" + emp.Departmentnumber);
            Console.WriteLine("The department number is :" + emp.Salary);
            Console.WriteLine("The employee name is : " + emp.employeename);






        }



        struct employee
        {
            public int employeenumber;
            public string employeename;
            public int salary;
            public int departmentnumber;

            public int Employeenumber
            {
                get
                {
                    return employeenumber;
                    
                }

                set
                {
                    employeenumber = value;
                    
                }
            }
            public int Departmentnumber
            {
                get
                {
                    
                    return departmentnumber;
                    
                }

                set
                {
                    
                    departmentnumber = value;
                    
                }
            }
            public int Salary
            {
                get
                {
                    
                    return salary;
                }

                set
                {
                    
                    salary = value;
                }
            }
            public String Employeename
            {
                get
                {
                    return employeename;
                }
                set
                {
                    employeename = value;
                }
            }

        }
        

        }

        
        
       
    }


