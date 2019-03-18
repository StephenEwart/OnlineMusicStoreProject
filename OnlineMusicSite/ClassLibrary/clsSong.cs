using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSong
    {
        public string Song { get; set; }
        public int SongNo { get; set; }

        public bool Valid(string SomeSong)
        {
            throw new NotImplementedException();
        }
    }

    public string Valid(string someSong)
    {
        //if the name of the county is not blank
        if (someSong !== "")
        {
            //return a blank string 
            return "";
        }
        else
        {
            //otherwise return an error message 
            return "The song name may not be blank!";
        }
    }
}
