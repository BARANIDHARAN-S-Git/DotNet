using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace CustomerUser
{
    [Serializable()]
    public class User
    {
        public List<Movie> searchedmovie=new List<Movie>();
        public List<Movie> watchedmovie=new List<Movie>();
       // public string searchedmovie { get; set; }
        public int moviesBorrowed = 0;
        public enum UserLevel
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5
        }
        public List<Movie> BorrowedMovies;
        public User()
        {
            this.userLevel = (int)UserLevel.Silver;
            BorrowedMovies = new List<Movie>();

        }

        private int _UserLevel;

        public int userLevel
        {
            get { return _UserLevel; }
            set { _UserLevel = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }




        public void usertoadd(string UserLevel1)
        {
            if (UserLevel1 == "Silver")
            {
                this.userLevel = (int)UserLevel.Silver;
            }
            if (UserLevel1 == "Gold")
            {
                this.userLevel = (int)UserLevel.Gold;
            }
            if (UserLevel1 == "Platinum")
            {
                this.userLevel = (int)UserLevel.Platinum;
            }
           // this._UserName = username;
            //this.Password = password;

            FileStream f = new FileStream("user1.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(f);
                Console.WriteLine("Enter the username");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the userid");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the password");
                string password = Console.ReadLine();
                Console.WriteLine("Enter the userlevel");
                int userlevel = Convert.ToInt32(Console.ReadLine());
                sw.WriteLine(name + " " + id + " " + password + " " + userlevel);
                Console.WriteLine("User Added");

            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                sw.Close();
                f.Close();
            }



        }
        public void Movieborrowed(Movie mov)
        {
            if (mov.Available > 0)
            {
                if (this.moviesBorrowed <= this.userLevel)
                {
                    mov.Available--;
                    this.moviesBorrowed++;
                    BorrowedMovies.Add(mov);
                    this.watchedmovie.Add(mov);
                    foreach(var item in BorrowedMovies)
                    {
                        Console.WriteLine(item.MovieName);
                        Console.WriteLine(item.Language);
                        Console.WriteLine(item.genres);
                    }
                }
                    
                   
                else
                {
                    Console.WriteLine("cannot able to borrow movies");
                }
            }
            else
            {
                Console.WriteLine("movie is not available");
            }
        }
        public void moviereturned(Movie m, int days)
        {
            if (this.BorrowedMovies.Contains(m))
            {

                m.Available++;
                this.moviesBorrowed--;
                BorrowedMovies.Remove(m);

                double gst = 0.18 * m.Cost;
                double br = days * 0.01 * m.Cost;
                double t = gst + br + m.Cost;
                Console.WriteLine($"GST is {gst}");
                Console.WriteLine($"Bluray cost is {br}");
                Console.WriteLine("Total cost is" + " " + t);

            }
            else
            {
                Console.WriteLine("The Borrowed movie and returned movie is not same");
            }
        }
      
       
        public void SearchBylanguageGenre(string language, string genre)
        {
           foreach(var item in Movie.l)
            {
                if(item.Language==language&&item.genres==genre)
                {
                    this.searchedmovie.Add(item);
                    Console.WriteLine(item.MovieName);
                    Console.WriteLine(item.Language);
                    Console.WriteLine(item.genres);
                }
                else
                {
                    Console.WriteLine("Nomatch");
                }
            }
            
            
        }
        public void displayt()
        {
            foreach (var item in this.BorrowedMovies)
            {
                //Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
            }
        }

        public double userid { get; set; }
        public double password { get; set; }
        //bool loginstatus=false;
        public bool loginstatus { get;  set; }
        public void validateUser()
        {
            // User user = new User();
            if (userid == 9999888877 && password == 123456789)
            {
                loginstatus = true;
                Console.WriteLine("Logged in sucessfully");

            }
            else
            {
                loginstatus = false;
                Console.WriteLine("Not Logged in ...");
            }

        }

    }
}
