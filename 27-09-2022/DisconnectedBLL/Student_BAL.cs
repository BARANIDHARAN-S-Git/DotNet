using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedBLL
{
    public class Student_BAL
    {
        private int _studid;
        public int Studid
        {
            get { return _studid; }
            set
            {
                _studid = value;
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        private int _crsid;
        public int Crsid
        {
            set { _crsid = value; }
            get { return _crsid; }
        }
    }
}
