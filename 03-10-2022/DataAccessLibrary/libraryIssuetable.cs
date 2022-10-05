using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using System.Runtime.InteropServices;


namespace DataAccessLibrary
{
    public class libraryIssuetable
    { 



        

        public bool  issuetable(string lib_Issue_Id,string Book_No)
        {
            bool result = false;
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection("Data Source =LAPTOP-1GKJ0ROI\\SQLEXPRESS02; Initial Catalog = LibrarySystem; Integrated Security = True");
            SqlDataAdapter s = new SqlDataAdapter("select * from Issue", connection);
            s.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            s.Fill(ds, "Issue");
            DataTable dt = ds.Tables["Issue"];
            DataRow dr = dt.NewRow();
            dr["Lib_Issue_id"]=lib_Issue_Id;
            dr["Book_No"] = Book_No;
            dr["IssueDate"] = DateTime.Now;
            ds.Tables["Issue"].Rows.Add(dr);
            SqlCommandBuilder c = new SqlCommandBuilder(s);
            int i = s.Update(ds.Tables["Issue"]);
            if(i>0)
            {
                result = true;
            }
            
            return result;

            
        }

    }
}
