using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using System.Net.Http;
using MovieRental.Models;


namespace MovieRental.Controllers
{
    public class UserController : ApiController
    {
        MovieRentalBLL b = null;
        public UserController()
        {
            b = new MovieRentalBLL();
        }




        [Route("GetUser")]
        public List<User> Get()
        {
            List<User> m = new List<User>();
            var s = b.ShowUserList();
            foreach (var item in s)
            {
                m.Add(

                      new User() { UserId = item.UserId, Password = item.Password, category = item.category}
                  );
            }
            return m;
        }

      

       [Route("AddUser")]
        public void Post([FromBody] UserModel Userdata)
        {
            User u = new User();

            u.UserId = Userdata.UserId;
            u.Password = Userdata.Password;
            u.category = Userdata.category;
          

            this.b.AddUser(u);
        }

        [Route("EditUser/{id}")]
        public void Put(int id, [FromBody] UserModel Userdata)
        {
            User u = new User();

            u.UserId = Userdata.UserId;
            u.Password = Userdata.Password;
            u.category = Userdata.category;
            this.b.EditUser(id, u);
        }

        [Route("RemoveUser/{id}")]
        public void Delete(int id)
        {
            b.RemoveUser(id);
        }

    }
}