using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3rdOctober2022
{
    public partial class Userlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome" + Session["username"].ToString());
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BookRequest.aspx");
        }
    }
}