using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedBLL
{
    public class Course_BAL
    {
       
        private int _courseid;
        public int courseid
        {
            get { return _courseid; }
            set { _courseid = value; }
        }

        private string _coursename;
        public string coursename
        {
            get { return _coursename; }
            set { _coursename = value; }
        }

        private int _depid;
        public int depid
        {
            get { return _depid; }
            set { _depid = value; }
        }


        private int _duration;
        public int duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }




    }
}