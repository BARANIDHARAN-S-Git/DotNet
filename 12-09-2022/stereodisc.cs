using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _12thSeptember2022
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class stereodisc : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        //readonly string positionalString;

        // This is a positional argument
        public stereodisc(string sngname,string language,string lyric)
        {
            //this.positionalString = positionalString;

            // TODO: Implement code here
            this.songname = sngname;
            this.songlanguage = language;
            this.songlyrics = lyric;
            //throw new NotImplementedException();
        }

        //public string PositionalString
        //{
        //    get { return positionalString; }
        //}

        // This is a named argument
        public string  songname { get; set; }
        public string songlanguage { get; set; }

        public string songlyrics { get; set; }
    }
}
