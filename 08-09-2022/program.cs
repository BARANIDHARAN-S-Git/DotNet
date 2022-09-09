using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace _8thSeptember2022
{
    public class program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
              e.EmployeeID = 112;
             e.Employeename = "Buttler";
             e.departmentnumber = 12;
             e.salary = 15000;
             e.mgr = "Axarpatel";


             Employee e1 = new Employee();
             e1.EmployeeID = 113;
             e1.Employeename = "Samcurran";
             e1.departmentnumber = 13;
             e1.salary = 15000;
             e1.mgr = "Hardhikpandya";


             Employee e2 = new Employee();
             e2.EmployeeID = 114;
             e2.Employeename = "KL Rahul";
             e2.departmentnumber = 14;
             e2.salary = 15000;



             Employee e3 = new Employee();
             e3.EmployeeID = 115;
             e3.Employeename = "Rishabhpant";
             e3.departmentnumber = 15;
             e3.salary = 15000;



             Employee e4 = new Employee();
             e4.EmployeeID = 116;
             e4.Employeename = "Bumrah";
             e4.departmentnumber = 16;
             e4.salary = 15000;
             e4.mgr = "Rohithsharma";


             Employee e5 = new Employee();
             e5.EmployeeID = 117;
             e5.Employeename = "ViratKholi";
             e5.departmentnumber = 17;
             e5.salary = 15000;
             e5.mgr = "MS Dhoni";

            Employee e6 = new Employee();
            e6.EmployeeID = 118;
            e6.Employeename = "barath";
            e6.departmentnumber = 18;
            e6.salary = 15000;
            e6.mgr = "basha";
            
            Employee e7 = new Employee();
            e7.EmployeeID = 119;
            e7.Employeename = "arun";
            e7.departmentnumber = 19;
            e7.salary = 15000;
            e7.mgr = "balaji";
            
            Employee e8 = new Employee();
            e8.EmployeeID = 120;
            e8.Employeename = "ajas";
            e8.departmentnumber = 120;
            e8.salary = 15000;
            e8.mgr = "halith";
            
            Employee e9 = new Employee();
            e9.EmployeeID = 121;
            e9.Employeename = "ravi";
            e9.departmentnumber = 21;
            e9.salary = 15000;
            e9.mgr = "baskar";
            
            Employee e10 = new Employee();
            e10.EmployeeID = 122;
            e10.Employeename = "bhuvanesh";
            e10.departmentnumber = 17;
            e10.salary = 15000;
            e10.mgr = "bala";



            Departmet d = new Departmet();
             d.adddeleteupdate(e);
             d.adddeleteupdate(e1);
             d.adddeleteupdate(e2);
            
             d.adddeleteupdate(e3);
             d.adddeleteupdate(e4);
             d.adddeleteupdate(e5);
            d.adddeleteupdate(e6);
            d.adddeleteupdate(e7);
            d.adddeleteupdate(e8);
            d.adddeleteupdate(e9);
            d.adddeleteupdate(e10);

            Console.WriteLine("-------------------");
            Console.WriteLine(" ");
            Console.WriteLine("The Employees are : ");
            
            Print p = new Print(d.Print);
             p.Invoke(d.employee);
            Console.WriteLine("-------------");
           
            Console.WriteLine("Delete By ID");
            d.deletebyid(117);
            d.display();
            
            Console.WriteLine("----------------------------");
            Console.WriteLine("Employees Reporting to their Managers : ");
            d.Reporttomanager(d.employee);
            Console.WriteLine("--------------");

            Console.Write("Login for Employee : ");
            Predicate<Tuple<int, string>> verify = (v1) =>
            {
                if (v1.Item2 == "password")
                {
                    if (d.employee.Count(a => a.EmployeeID == v1.Item1) > 0)
                    {
                        Console.WriteLine("UserId  matched");

                        return true;
                    }
                    else
                    {
                        Console.WriteLine("UserId not  matched");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Password  is Incorrect");
                    return false;
                }


            };

            var ver = Tuple.Create<int, string>(115, "password");
            verify(ver);













        }
    }
}
