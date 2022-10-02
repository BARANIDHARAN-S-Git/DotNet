using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30thSeptember2022
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbutton_Click(object sender, EventArgs e)
        {
            if(useridtextbox!=null && useridtextbox.Text=="Baranidharan")
            {
                if(passwordtextbox!=null && passwordtextbox.Text=="Baranidharan@123")
                {
                    Response.Write("Login Successfully");
                    
                }

                else
                {
                    Response.Write("Password is Not Valid");
                }
            }
            else
            {
                Response.Write("UserId is Not Valid");
            }


        }
    }
}