using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using HelperLibrary;
using DisconnectedBLL;
using DisconnectedHelperLibrary;

namespace DisconnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Employee Management System");
            Console.WriteLine("--------------------------------");
            CourseHelper helper = new CourseHelper();
            StudentHelper studentHelper = new StudentHelper();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add New course  2.update course  3.Delete course  4. Add New student ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Course_BAL course = new Course_BAL();
            Student_BAL student = new Student_BAL();

            switch (userchoice)
            {
                case 1:

                    Console.WriteLine("Enter courseid");
                    course.courseid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter coursename");
                    course.coursename =Console.ReadLine();
                    Console.WriteLine("Enter depid");
                    course.depid=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter duration");
                    course.duration = Convert.ToInt32(Console.ReadLine());

                    bool queryStatus = helper.AddCourse(course);
                    if (queryStatus)
                    {
                        Console.WriteLine("course added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter courseid");
                    int courseid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter new courseid");
                    course.courseid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter coursename");
                    course.coursename = Console.ReadLine();
                    Console.WriteLine("Enter depid");
                    course.depid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter duration");
                    course.duration = Convert.ToInt32(Console.ReadLine());

                    queryStatus = helper.Editcourse(courseid, course);
                    if (queryStatus)
                    {
                        Console.WriteLine("Course updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
               
                case 3:
                    Console.WriteLine("enter  course id");
                    course.courseid = Convert.ToInt32(Console.ReadLine());
                    queryStatus = helper.Removecourse(course.courseid);
                    if (queryStatus)
                    {
                        Console.WriteLine("course Deleted successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }


                    break;
                case 4:
                    
                    Console.WriteLine("Enter studid");
                    student.Studid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter studentname");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("Enter crsid");
                    student.Crsid = Convert.ToInt32(Console.ReadLine());
                    

                    bool queryStatus1 = studentHelper.Addstudent(student);
                    if (queryStatus1)
                    {
                        Console.WriteLine("Student added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
               

                   
            }
            Console.ReadKey();

            

        }
    }
}