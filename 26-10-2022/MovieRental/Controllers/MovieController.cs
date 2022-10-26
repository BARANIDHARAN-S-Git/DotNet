using BusinessLogicLayer;
using DataAccessLayer;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;


namespace MovieRental.Controllers
{
    public class MovieController : ApiController
    {
        MovieRentalBLL a = null;
        public MovieController()
        {
            a = new MovieRentalBLL();
        }




         [Route("GetMovie")]
        public List<Movie> Get()
        {
            List<Movie> m = new List<Movie>();
            var g = this.a.ShowMovieList();
            foreach (var item in g)
            {
                m.Add(

                      new Movie() { MovieId = item.MovieId, MovieName = item.MovieName, Language = item.Language,Genre=item.Genre,rating=item.rating,availability=item.availability }
                  );
            }
            return m;
        }


        [Route("AddMovie")]
        public void Post([FromBody] MovieModel Moviedata)
        {
            Movie mo = new Movie();

            mo.MovieId = Moviedata.MovieId;
            mo.MovieName = Moviedata.MovieName;
            mo.Language = Moviedata.Language;
            mo.Genre = Moviedata.Genre;
            mo.rating = Moviedata.rating;
            mo.availability = Moviedata.availability;


            a.AddMovie(mo);
        }

        [Route("EditMovie/{id}")]
        public void Put(int id, [FromBody] MovieModel Moviedata)
        {

            Movie mo = new Movie();

            mo.MovieId = Moviedata.MovieId;
            mo.MovieName = Moviedata.MovieName;
            mo.Language = Moviedata.Language;
            mo.Genre = Moviedata.Genre;
            mo.rating = Moviedata.rating;
            mo.availability = Moviedata.availability;
            a.EditMovie(id, mo);
        }

        [Route("RemoveMovie/{id}")]
        public void Delete(int id)
        {
            a.RemoveMovie(id);
        }
    }
}