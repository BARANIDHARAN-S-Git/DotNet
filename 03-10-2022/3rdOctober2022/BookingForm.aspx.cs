using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Provider;
using System.Xml.Linq;


namespace _3rdOctober2022
{
    public partial class BookingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userid=UserIdTextBox.Text;
            string password=PasswodTextBox.Text;
            Session["username"] = userid;
            Session["password"] = password;
            
            if(userid!=null )
            {
                if(password!=null )
                {
                    Response.Write("Login Successfully");
                    

                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDBCnString"].ConnectionString);
                    
                    SqlCommand cmd = new SqlCommand("Insert into logindetails(userid,password) values(@userid,@password)", connection);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("Password", password);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Response.Redirect("~/Userlogin.aspx");
                }
                else
                {
                    Response.Write("Password Incorrect");
                }
            }
            else
            {
                Response.Write("UserId Incorrect");
            }

        }
    }
}