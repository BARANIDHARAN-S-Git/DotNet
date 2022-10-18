using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{
    public  class Login
    {
        public  bool result(string userid,string password)
        {
            bool a = false;
            if(userid=="testuser_1"&&password== "Test@123")
            {
                a=true;
                return a;
            }
            return a;
        }
    }
}
