using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace usermodule
{
   public  class User
    {
        
        public int moviesBorrowed = 0;
        public static event Func<string, bool> permission;
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
        private int _Userid;

        public int Userid
        {
            get { return _Userid; }
            set { _Userid = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

      
       

        public void AddUser( string UserLevel1)
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
         
           
        }
        public void basedonlanguage(string language)
        {
            foreach (var item in Movie.l)
            {
                if (item.Language == language)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void basedongenre(string genre)
        {
            foreach (var item in Movie.l)
            {
                if (item.genres == genre)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void display()
        {
            foreach (var item in this.BorrowedMovies)
            {
                Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
            }
        }
        public void Movieborrowed(Movie mov)
        {
            bool response = permission(mov.MovieName);
            if (response)
            {
                if (mov.Available > 0)
                {
                    if (this.moviesBorrowed <= this.userLevel)
                    {
                        mov.Available--;
                        this.moviesBorrowed++;
                        BorrowedMovies.Add(mov);
                    }
                    else
                    {
                        Console.WriteLine("cannot able to borrow movies");
                    }
                }
                else
                {
                    Console.WriteLine("mivie is not available");
                }
            }
            else
            {
                Console.WriteLine("Admin didn't give permission");
            }
        }
        public void RetrunMovie(Movie m, int days)
        {
            if (this.BorrowedMovies.Contains(m))
            {

                m.Available++;
                this.moviesBorrowed--;
                BorrowedMovies.Remove(m);
                
                double gst = 0.18 * m.Cost;
                double br =days* 0.01 * m.Cost;
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
       
    }
}
