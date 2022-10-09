using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using _7thOctober2022.Models;

using Microsoft.Ajax.Utilities;

namespace _7thOctober2022.DAL
{
    public class MemberDAL
    {

        string constring = ConfigurationManager.ConnectionStrings["LibraryCn"].ToString();
        public List<MemberModel> GetAllMembers()
        {


            List<MemberModel> MemberList = new List<MemberModel>();
            using (SqlConnection connection = new SqlConnection(constring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "sp_GetAllMembers";
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtMembers = new DataTable();

                //connection.Open();
                sqlda.Fill(dtMembers);
                //connection.Close();
                foreach (DataRow dr in dtMembers.Rows)
                {
                    MemberList.Add(new MemberModel
                    {
                        Member_Id = Convert.ToInt32(dr["Member_Id"]),
                        Member_Name = dr["Member_Name"].ToString(),
                        AccountOpenedDate = Convert.ToDateTime(dr["Acc_open_date"]),
                        MaximumBooksAllowed = Convert.ToInt32(dr["Max_Books_Allowd"]),
                       

                    });



                }
            }
            return MemberList;



        } 
        
        public bool InsertMember(MemberModel Member)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                SqlCommand command = new SqlCommand("sp_InsertMember", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Member_Id", Member.Member_Id);
                command.Parameters.AddWithValue("@Member_Name",Member.Member_Name);
                command.Parameters.AddWithValue("@Acc_Open_Date", Member.AccountOpenedDate);
                command.Parameters.AddWithValue("@Max_Books_Allowd", Member.MaximumBooksAllowed);
                connection.Open();
                id = command.ExecuteNonQuery();
                connection.Close();
               
            }
            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<MemberModel> GetMembersById(int id)
        {


            List<MemberModel> MemberList = new List<MemberModel>();
            using (SqlConnection connection = new SqlConnection(constring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_GetMembersById";
                command.Parameters.AddWithValue("@Member_Id", id);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable dtMembers = new DataTable();

                connection.Open();
                sqlda.Fill(dtMembers);
                connection.Close();
                foreach (DataRow dr in dtMembers.Rows)
                {
                    MemberList.Add(new MemberModel
                    {
                        Member_Id = Convert.ToInt32(dr["Member_Id"]),
                        Member_Name = dr["Member_Name"].ToString(),
                        AccountOpenedDate = Convert.ToDateTime(dr["Acc_open_date"]),
                        MaximumBooksAllowed = Convert.ToInt32(dr["Max_Books_Allowd"]),


                    });



                }
            }
            return MemberList;



        }

        public bool UpdateMember(MemberModel Member)
        {
            int i = 0;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                SqlCommand command = new SqlCommand("sp_UpdateMember", connection);
                command.CommandType = CommandType.StoredProcedure;
                 command.Parameters.AddWithValue("@Member_Id", Member.Member_Id);
                command.Parameters.AddWithValue("@Member_Name", Member.Member_Name);
                command.Parameters.AddWithValue("@Acc_Open_Date", Member.AccountOpenedDate);
                command.Parameters.AddWithValue("@Max_Books_Allowd", Member.MaximumBooksAllowed);
                connection.Open();
                i = command.ExecuteNonQuery();
                connection.Close();

            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string deleteproduct(int Member_Id)
        {
            string result = "";
             using(SqlConnection connection = new SqlConnection(constring))
             {
                 SqlCommand command= new SqlCommand("sp_deleteMember", connection);
                 command.CommandType=CommandType.StoredProcedure;
                 command.Parameters.AddWithValue("@Member_Id",Member_Id);
                 command.Parameters.Add("@OUTPUTMESSAGE", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                 connection.Open();
                 command.ExecuteNonQuery();
                 result = command.Parameters["@OUTPUTMESSAGE"].Value.ToString();
                 connection.Close();
             }
             return result;

            
        }


    }
}