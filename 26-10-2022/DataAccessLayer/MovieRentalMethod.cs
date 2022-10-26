using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MovieRentalMethod
    {
        MyContext Context = null;
        public MovieRentalMethod()
        {
            Context = new MyContext();
        }

        public List<Movie> ShowallMovie()
        {
            return Context.MovieTable.ToList();

        }

        public List<User> ShowallUser()
        {
            return Context.UserTable.ToList();

        }

        public void InsertMovie(Movie movie)
        {


            Context.MovieTable.Add(movie);
            Context.SaveChanges();

        }
        public void InsertUser(User user)
        {


            Context.UserTable.Add(user);
            Context.SaveChanges();

        }


        public void UpdateMovie(int id, Movie movie)
        {
            var a = Context.MovieTable.ToList().Find(b => b.MovieId == id);
            Context.MovieTable.Remove(a);
            Context.MovieTable.Add(movie);
            Context.SaveChanges();

        }
        public void UpdateUser(int id, User user)
        {
            var r = Context.UserTable.ToList().Find(a => a.UserId == id);
            Context.UserTable.Remove(r);
            Context.UserTable.Add(user);
            Context.SaveChanges();

        }

        public void DeleteMovie(int id)
        {
            var d = Context.MovieTable.ToList().Find(c => c.MovieId == id);
            Context.MovieTable.Remove(d);
            Context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var e = Context.UserTable.ToList().Find(d => d.UserId == id);
            Context.UserTable.Remove(e);
            Context.SaveChanges();
        }

        

    }
}
