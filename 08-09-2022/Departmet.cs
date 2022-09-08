using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
     public delegate void Adddeleteupdate(Employee emp);
     public delegate void Print(List<Employee> emp);
    public delegate void updatedeleteById(int emp);


    public class Departmet
    {
        public static event Adddeleteupdate Addemp;
        public static event Adddeleteupdate Deleteemp;
        public static event Adddeleteupdate UpdateEmp;
        public static event updatedeleteById removebyid;
        

        public int emplyeecount = 0;
        public List<Employee> employee = new List<Employee>();

        private int _deptno;
        public int departmentnumber
        {
            get
            {
                return _deptno;
            }
            set
            {
                _deptno = value;
            }
        }

        private int _dname;

        public int departmentname
        {
            get
            {
                return _dname;
            }
            set { _dname = value; }
        }

        private string _location;

        public string location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        public void Reporttomanager(List<Employee> emplist)
        {
            Func<List<Employee>, List<Employee>> reporttomanager = (a) => a.FindAll(emp => emp.mgr != null).ToList();
            var result = reporttomanager(emplist);
            foreach (var item in result)
            {
                Console.WriteLine(item.Employeename);

            }

        }
        public void Print(List<Employee> emp)
        {
            if (emp != null)
            {
                foreach (var item in emp)
                {

                    Console.WriteLine(item.Employeename);
                }

            }
            else
            {
                Console.WriteLine("The List is Empty");
            }
        }
        public void display()
        {
            if (employee != null)
            {
                foreach (var item in employee)
                {

                    Console.WriteLine(item.Employeename);
                }

            }
            else
            {
                Console.WriteLine("The List is Empty");
            }

        }
        public void deletebyid(int emp)
        {
            removebyid = deleteid;
            removebyid(emp);
        }
      



        public void adddeleteupdate(Employee emp)
        {
            Addemp = Addemployee;
            Deleteemp = Deleteemployee;
            UpdateEmp = Updateemployee;
            Console.WriteLine("Enter any one form menu shown below : ");
            Console.WriteLine(" ");
            Console.WriteLine("\nMenu: \n1)Add \n2)Delete \n3)update");
            int no = Convert.ToInt32(Console.ReadLine());
            switch (no)
            {
                case 1:
                    if (emplyeecount < 10)
                    {
                        emplyeecount++;
                        Addemp(emp);

                        break;

                    }
                    else
                    {


                        Console.WriteLine("You have exceeded the Limit, No of employee in each department must not exceed 10");

                    }
                    break;
                case 2:
                    if (emplyeecount != 0)
                    {
                        emplyeecount--;
                        Deleteemp(emp);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It's an Empty List");

                    }
                    break;
                case 3:
                    UpdateEmp(emp);
                    break;

            }
        }

        public void Addemployee(Employee emp)
        {

            Adddeleteupdate a = new Adddeleteupdate(add);
            a.Invoke(emp);

        }
        public void add(Employee emp)
        {
            employee.Add(emp);


            Console.WriteLine("Employee Adedd Successfully");
            Console.WriteLine(" ");
        }
        public void Deleteemployee(Employee e)
        {

            Adddeleteupdate d = new Adddeleteupdate(delete);
            d.Invoke(e);
        }
        public void delete(Employee e)
        {
            employee.RemoveAll(a => a.EmployeeID == e.EmployeeID);
            Console.WriteLine("Employee Removed successfuly");
            Console.WriteLine(" ");
        }

        public void Updateemployee(Employee e)
        {
            Adddeleteupdate u = new Adddeleteupdate(update);
            u.Invoke(e);
        }

        public void update(Employee e)
        {
            employee.Remove(e);
            Employee a = new Employee();

            a.EmployeeID = 118;
            a.Employeename = "Alen";
            a.departmentnumber = 18;
            a.salary = 15000;
            a.mgr = "Ganguly";
            employee.Add(a);
            Console.WriteLine("Updated Sucessfully");
            Console.WriteLine(" ");


        }
        public void deleteid(int emp)
        {
            updatedeleteById g = new updatedeleteById(deletebid);
            g.Invoke(emp);
        }
        private void deletebid(int emp)
        {
            employee.RemoveAll(e => e.EmployeeID == emp);
            Console.WriteLine("Employee removed successfully");
        }

       

    }
}
