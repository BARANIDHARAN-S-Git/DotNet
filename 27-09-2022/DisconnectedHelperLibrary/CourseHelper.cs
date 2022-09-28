using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disconnected_DAL;
using DisconnectedBLL;
namespace HelperLibrary
{
    public class CourseHelper
    {
        courseDAL dal = null;
        public CourseHelper()
        {
            dal = new courseDAL();
        }


        public bool AddCourse(Course_BAL course)
        {
            return dal.InsertCourse(course);
        }
       

        public bool Removecourse(int courseid)
        {
            return dal.Deletecourse(courseid);
        }



        public bool Editcourse(int courseid, Course_BAL course)
        {
            return dal.Updatecourse(courseid, course);
        }

        
       
    }
}