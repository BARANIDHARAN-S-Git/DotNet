using DisconnectedBLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_DAL
{
    public class BookDAL
    { 
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public BookDAL()
        {
            ds = new DataSet();
             cn = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryCnStr"].ConnectionString);
        }

        private  DataTable Connect()
        {
            da = new SqlDataAdapter("select * from Book", cn);

          
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Book");
            DataTable dt_empdata = ds.Tables["Book"];
            return dt_empdata;
        }

        public int RowCountBook()
        {
            DataTable dt_Bookdata=Connect();
            int Bookcnt = dt_Bookdata.Rows.Count;
            return Bookcnt;



        }


        public bool UpdateBook(int Book_No, Book_BAL Book)
        {
            DataTable dt_empdata = Connect();
            DataRow drow=ds.Tables["Book"].Rows.Find(Book_No);


            drow["Book_No"] = Book.Book_No;
            drow["Book_Name"] = Book.Book_Name;
            drow["Author"] = Book.Author;
           // drow["cost"] = Book.Cost;
            drow["category"] = Book.Category;

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Book"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;



        }
        public Book_BAL FindBook(int Book_No)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Book"].Rows.Find(Book_No);
            Book_BAL Book = new Book_BAL();
            Book.Book_No = Convert.ToInt32(drow["Book_No"]);
            Book.Book_Name = drow["Book_Name"].ToString();
            Book.Author= drow["Author"].ToString();
           // Book.Cost = Convert.ToInt32(drow["cost"]);
            Book.Category = drow["category"].ToString();
            return Book;



        }


        public List<Book_BAL> ShowAllBooks()
        {
            DataTable dt_Bookdata = Connect();
            List<Book_BAL> emplist = new List<Book_BAL>();
            for (int i = 0; i < dt_Bookdata.Rows.Count; i++)
            {
                DataRow drow=dt_Bookdata.Rows[i];
                Book_BAL Book = new Book_BAL();
                Book.Book_No = Convert.ToInt32(drow["Book_No"]);
                Book.Book_Name = drow["Book_Name"].ToString();
                Book.Author = drow["Author"].ToString();
                //Book.Cost = Convert.ToInt32(drow["cost"]);
                Book.Category = drow["category"].ToString();

                emplist.Add(Book);

            }
            return emplist;


        }


        public bool DeleteBook(int Book_No)
        {

            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["Book"].Rows.Find(Book_No);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["Book"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }


        public bool InsertBook(Book_BAL Book)
        {
            DataTable dt_empdata = Connect();

            DataRow drow=ds.Tables["Book"].NewRow();
            drow["Book_No"] = Book.Book_No;
            drow["Book_Name"] = Book.Book_Name;
            drow["Author"] = Book.Author;
            //drow["cost"] = Book.Cost;
            drow["category"] = Book.Category;


            ds.Tables["Book"].Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i=da.Update(ds.Tables["Book"]);
            bool status = false;
            if (i==1)
            {
                status = true;
            }
            return status;



        
        }



    }
}