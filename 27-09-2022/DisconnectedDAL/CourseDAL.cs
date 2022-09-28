using DisconnectedBLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_DAL
{
    public class courseDAL
    { 
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public courseDAL()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSCnStr"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from course", cn);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "course");
            DataTable dt_empdata = ds.Tables["course"];
            return dt_empdata;
        }

     


       public bool Updatecourse(int courseid, Course_BAL course)
        {
            DataTable dt_exam = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);


            drow["courseid"] = course.courseid;
            drow["coursename"] = course.coursename;
            drow["depid"] = course.depid;
            drow["duration"] = course.duration;
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;



        }
     

        public bool Deletecourse(int courseid)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["course"].Rows.Find(courseid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }

        
        public bool InsertCourse(Course_BAL course)
        {
            DataTable dt_exam = Connect();

            DataRow drow = ds.Tables["course"].NewRow();
            
            drow["courseid"] = course.courseid;
            drow["coursename"] = course.coursename;
            drow["depid"] = course.depid;
            drow["duration"] = course.duration;

            ds.Tables["course"].Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["course"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;




        }

        


    }
}