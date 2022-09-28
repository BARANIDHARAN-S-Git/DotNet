using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrarydemo
{
    public class MemberBAL
    {

        public int Memberid { get; set; }
        public string Membername { get; set; }
        public DateTime AccountOpenDate { get; set; }
        public int MaximumBooksAllowed { get; set; }
        public int PenaltyAmount { get; set; }
    }
}
