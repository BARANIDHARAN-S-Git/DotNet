using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLibrary;
namespace _3rdOctober2022
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            libraryIssuetable l = new libraryIssuetable();
            String Book_No = BookNumberDropDownList.SelectedValue;
            string lib_Issue_id = LibraryIssueIdTextBox.Text; 
            bool result = l.issuetable(lib_Issue_id,Book_No);
            if (result)
            {
                Response.Write("Book is available and it is Issued Successfully");
                Response.Redirect("~/AvailabelandUserBooks.aspx");

            }
            else
            {
                Response.Write("Error Occured");
            }

        }

       
    }
}