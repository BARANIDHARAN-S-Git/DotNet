using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _19thOctober2022
{
    
    public class StudentEnrollment
    {
        public bool Fees(Student s,Enrollment e)
        {
            bool a = false;
            
            if (e.Fees > 0 )
            {
                a = true;
                return a;
            }
            return a;
        }
        
    }
}
