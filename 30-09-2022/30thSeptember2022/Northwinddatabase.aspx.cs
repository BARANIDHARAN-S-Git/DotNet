using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Provider;
using System.Xml.Linq;


namespace _30thSeptember2022
{
    public partial class Northwinddatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source =LAPTOP-1GKJ0ROI\\SQLEXPRESS02; Initial Catalog = Northwind; Integrated Security = True");
            int ID=Convert.ToInt32(ProductIdTextBox.Text);
            SqlCommand cmd = new SqlCommand("select * from products where ProductID=" + ID,connection);
            connection.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            while(dr.Read())
            {
                TextBox1.Text= dr[0].ToString();
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();
                TextBox4.Text = dr[3].ToString();
                TextBox5.Text = dr[5].ToString();

            }
            connection.Close();

            
        }
    }
}