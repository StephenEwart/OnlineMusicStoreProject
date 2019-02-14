using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsArtist
    {
        public clsArtist()
        {
        }

        public string Artist { get; set; }
        public int ArtistNo { get; set; }

        public string Valid(string someArtist)
        {
            string Error = "";
            if (someArtist.Length > 50)
            {
                Error = "The Artist Name cannot be more then 50 characters";
            }
            if (someArtist.Length == 0)
            {
                Error = "The Artist Name may not be blank";
            }
            return Error;
        }
    }
}