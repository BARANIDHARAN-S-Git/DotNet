using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30thSeptember2022
{
    public partial class Signuppage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignupButton_Click(object sender, EventArgs e)
        {
           
            HttpCookie cookie= new HttpCookie("MyCookoie");
            cookie["Value1"] = customerfirstnametextbox.Text;
            cookie["Value2"] = CustomerLastnameTextBox.Text;
            cookie["Value3"]=DateOfBirthTextBox.Text;
            cookie["Value4"] = CityTextBox.Text;
            cookie["Value5"] = StateTextBox.Text;
            cookie.Expires = DateTime.Now.AddSeconds(20);
            Response.Cookies.Add(cookie);

            Response.Redirect("Welcomepage.aspx");

        }

        protected void Calendarid_SelectionChanged(object sender, EventArgs e)
        {
            DateOfBirthTextBox.Text = Calendarid.SelectedDate.ToLongDateString();

        }
    }
}