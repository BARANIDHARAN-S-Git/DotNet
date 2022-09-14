using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usermodule
{
   public  class User
    {
        
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
           this._UserName = UserName;
            this.Password = Password;
            
           
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
        public void SearchByLanguage(string language)
        {
            foreach (var item in Movie.l)
            {
                if (item.Language == language)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void SearchByGenre(string genre)
        {
            foreach (var item in Movie.l)
            {
                if (item.genres == genre)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void ShowMyList()
        {
            foreach (var item in this.BorrowedMovies)
            {
                Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
            }
        }
    }
}
