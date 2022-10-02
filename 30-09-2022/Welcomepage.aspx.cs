using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30thSeptember2022
{
    public partial class Welcomepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string str1 = Request.Cookies["MyCookoie"]["Value1"];
                string str2 = Request.Cookies["MyCookoie"]["Value2"];
                string str3 = Request.Cookies["MyCookoie"]["Value3"];
                string str4 = Request.Cookies["MyCookoie"]["Value4"];
                string str5 = Request.Cookies["MyCookoie"]["Value5"];
                Response.Write("CustomerFirstName : " + str1);
                Response.Write("CustomerLastName : " + str2);
                Response.Write("DateOfBirth : " + str3);
                Response.Write("City : " + str4);
                Response.Write("State : " + str5);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string str1 = Request.Cookies["MyCookoie"]["Value1"];
            string str2 = Request.Cookies["MyCookoie"]["Value2"];
            string str3 = Request.Cookies["MyCookoie"]["Value3"];
            string str4 = Request.Cookies["MyCookoie"]["Value4"];
            string str5 = Request.Cookies["MyCookoie"]["Value5"];
           
            Response.Write("Welcome" +" "+str1 + " " + str2);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str1 = Request.Cookies["MyCookoie"]["Value1"];
            string str2 = Request.Cookies["MyCookoie"]["Value2"];
            string str3 = Request.Cookies["MyCookoie"]["Value3"];
            string str4 = Request.Cookies["MyCookoie"]["Value4"];
            string str5 = Request.Cookies["MyCookoie"]["Value5"];
            Response.Write("CustomerFirstName : " + str1);
            Response.Write("CustomerLastName : " + str2);
            Response.Write("DateOfBirth : " + str3);
            Response.Write("City : " + str4);
            Response.Write("State : " + str5);
           

        }
    }
}