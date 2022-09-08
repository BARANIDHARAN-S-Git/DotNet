using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public  class Employee
    {

        private int _employeeid;

        public int EmployeeID
        {
            get { return _employeeid; }
            set
            {
                _employeeid = value;
            }
        }

        private string _employeename;

        public string Employeename

        {
            get { return _employeename; }
            set { _employeename = value; }
        }

        private int _deptno;

        public int departmentnumber
        {
            get { return _deptno; }
            set { _deptno = value; }
        }

        private double _salary;

        public double salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
            }
        }

        private string _mgr;

        public string mgr
        {
            get { return _mgr; }
            set { _mgr = value; }
        }




        
    }
}
