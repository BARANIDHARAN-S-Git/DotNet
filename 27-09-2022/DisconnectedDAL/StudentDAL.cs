using DisconnectedBLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedDAL
{
    public class StudentDAL
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public StudentDAL()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSCnStr"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from student", cn);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "student");
            DataTable dt_empdata = ds.Tables["student"];
            return dt_empdata;
        }




        public bool Updatestudent(int studentid, Student_BAL student)
        {
            DataTable dt_exam = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studentid);


            drow["studid"] = student.Studid;
            drow["name"] = student.Name;
            drow["crsid"] = student.Crsid;
            
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;



        }


        public bool Deletestudent(int stuid)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(stuid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }


        public bool Insertstudent(Student_BAL student)
        {
            DataTable dt_exam = Connect();

            DataRow drow = ds.Tables["student"].NewRow();

            drow["studid"] = student.Studid;
            drow["name"] = student.Name;
            drow["crsid"] = student.Crsid;

            ds.Tables["student"].Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;




        }




    }
}
