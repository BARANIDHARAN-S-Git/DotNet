using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class MovieRentalBLL
    {
        MovieRentalMethod dal;
        public MovieRentalBLL()
        {
            dal = new MovieRentalMethod();
        }
        public List<User> ShowUserList()
        {
            return dal.ShowallUser();
        }

        public List<Movie> ShowMovieList()
        {
            return dal.ShowallMovie();
        }

        public void AddUser(User user)
        {
            dal.InsertUser(user);

        }
        public void AddMovie(Movie movie)
        {
            dal.InsertMovie(movie);

        }



        public void EditMovie(int id, Movie movie)
        {
            dal.UpdateMovie(id, movie);
        }

        public void EditUser(int id, User user)
        {
            dal.UpdateUser(id, user);
        }

        public void RemoveMovie(int id)
        {
            dal.DeleteMovie(id);
        }

        public void RemoveUser(int id)
        {
            dal.DeleteUser(id);
        }
       

    }
}
