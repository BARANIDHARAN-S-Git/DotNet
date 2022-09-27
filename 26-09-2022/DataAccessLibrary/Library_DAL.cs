using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;

namespace DataAccessLibrary
{
    public class Library_DAL
    {
        public bool InserBook(Library_BLL Library)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Book(Book_No,Book_Name,Author,cost,category) values(@Book_No,@Book_Name,@Author,@cost,@category)", cn);
            cmdInsert.Parameters.AddWithValue("@Book_No", Library.Book_No);
            cmdInsert.Parameters.AddWithValue("@Book_Name", Library.Book_Name);
            cmdInsert.Parameters.AddWithValue("@Author", Library.Author);
            cmdInsert.Parameters.AddWithValue("@Cost", Library.Cost);
            cmdInsert.Parameters.AddWithValue("@Category", Library.Category);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;


        }
        public bool InsertMember(Library_BLL Library)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Member(Member_Id,Member_Name,Acc_Open_Date,Max_Books_Allowd,penalty_Amount) values(@Member_Id,@Member_Name,@Acc_Open_Date,@Max_Books_Allowd,@Penalty_Amount)", cn);
            cmdInsert.Parameters.AddWithValue("@Member_Id", Library.Memberid);
            cmdInsert.Parameters.AddWithValue("@Member_Name", Library.Membername);
            cmdInsert.Parameters.AddWithValue("@Acc_Open_Date", Library.Accounropendate);
            cmdInsert.Parameters.AddWithValue("@Max_Books_Allowd", Library.MaximumBookAllowed);
            cmdInsert.Parameters.AddWithValue("@Penalty_Amount", Library.Penaltyamount);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;


        }
        public bool Updatememberdetails(Library_BLL Library)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].[UpdateMember]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_memberid", Library.Memberid);
            cmdUpdate.Parameters.AddWithValue("@p_membername", Library.Membername);
            cmdUpdate.Parameters.AddWithValue("@p_accopendate", Library.Accounropendate);
            cmdUpdate.Parameters.AddWithValue("@p_maxbooksallowed", Library.MaximumBookAllowed);
            cmdUpdate.Parameters.AddWithValue("@p_penaltyamount", Library.Penaltyamount);
            cn.Open();
            int i = cmdUpdate.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;

        }
    }

}