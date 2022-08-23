using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class ps9
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            Console.WriteLine("Enter Employeenumber");
            emp.employeenumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Departmentnumber");
            emp.departmentnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employeename");
            emp.employeename = Console.ReadLine();

            Console.WriteLine(" If the value 404 shows in the output  for employeenumber and departmentnumbr means you have entered a invalid input or input is 0 ,else You have given the correct input,Thank you");
            Console.WriteLine("The employee number is :" + emp.Employeenumber);
            Console.WriteLine("The department number is :" + emp.Departmentnumber);
            Console.WriteLine("The department number is :" + emp.Salary);
            if (string.IsNullOrEmpty(emp.employeename))
            {
                Console.WriteLine("is null or empty");
            }
            else
            {
                Console.WriteLine("The employee name is : " + emp.employeename);
            }
           
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
                    if (employeenumber != 0) { return employeenumber; }
                    else
                    {
                        return 404;
                    }
                    

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
                    if (departmentnumber != 0) { return employeenumber; }
                    else
                    {
                        return 404;
                    }
                   

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
                    
                        Console.WriteLine("error");
                    
                        employeename = value;
                    
                    
                }
            }

        }


    }
}
