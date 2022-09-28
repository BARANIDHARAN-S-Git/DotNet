using Disconnected_DAL;
using DisconnectedBLL;
using DisconnectedDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedHelperLibrary
{
    public class StudentHelper
    {
        StudentDAL dal = null;
        public StudentHelper()
        {
            dal = new StudentDAL();
        }


        public bool Addstudent(Student_BAL student)
        {
            return dal.Insertstudent(student);
        }


        public bool Removestudent(int studentid)
        {
            return dal.Deletestudent(studentid);
        }



        public bool Editstudent(int studentid, Student_BAL student)
        {
            return dal.Updatestudent(studentid, student);
        }

    }
}
