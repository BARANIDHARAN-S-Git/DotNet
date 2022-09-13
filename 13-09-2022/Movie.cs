using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usermodule
{
    public class Movie
    {
        public static int countofmovies = 0;
        public Movie()
        {
            this.Available = 10;
        }
        public Movie(string MovieName, string Language, string genre, double Cost)
        {
            this.Available = 10;
            this.MovieName = MovieName;
            this.Language = Language;
            this.genres = genre;
            this.Cost = Cost;
            countofmovies++;
            l.Add(this);
        }
        public static List<Movie> l = new List<Movie>();
        private string _movieName;

        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        private int _availability;

        public int Available
        {
            get { return _availability; }
            set { _availability = value; }
        }
        private string _language;

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        private string _genres;

        public string genres
        {
            get { return _genres; }
            set { _genres = value; }
        }
        private double _cost;

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public void AddMovieDetails(string MovieName, string Language, string genres, double Cost)
        {
          
            this.MovieName = MovieName;
            this.Language = Language;
            this.genres = genres;
            this.Cost = Cost;
            l.Add(this);
            countofmovies++;
        }
        public static void print()
        {
            foreach (var item in l)
            {
                Console.WriteLine(item.MovieName);
            }
        }
    }
}
