using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _3rdOctober2022
{
    public partial class AvailabeandUserBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string connection = @"Data Source=LAPTOP-1GKJ0ROI\SQLEXPRESS02;Initial Catalog=LibrarySystem;Integrated Security=True";
        protected void Button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection s=new SqlConnection(connection))
            {
                s.Open();
                SqlDataAdapter sd = new SqlDataAdapter("select * from Book", connection);
                DataTable dtable=new DataTable();
                sd.Fill(dtable);
                AvailableBooks.DataSource= dtable;
                AvailableBooks.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection s = new SqlConnection(connection))
            {
                s.Open();
                SqlDataAdapter sd = new SqlDataAdapter("select * from Issue", connection);
                DataTable dtable = new DataTable();
                sd.Fill(dtable);
                UserBooks.DataSource = dtable;
                UserBooks.DataBind();
            }

        }
    }
}