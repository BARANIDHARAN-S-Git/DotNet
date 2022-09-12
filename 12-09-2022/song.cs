using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _12thSeptember2022
{
    public class song
    {
        
        
        [stereodisc("munbavaa","Tamil","Munbaevaaenanbaevaapopoovaya")]
        public string singer { get; set; }

        [stereodisc("kanazhaga", "Tamil", "kanazhagapechazhaga")]
        public int nooftimessongslistened { get; set; }

        [stereodisc("uyireh", "Tamil", "uyirinuyireh")]
        public song()
        {

        }
        [stereodisc("kanuvugal", "Tamil", "kanavaekanavae")]
        public song(string s, int n)
        {
            singer = s;
            nooftimessongslistened = n;

        }
    }
}







