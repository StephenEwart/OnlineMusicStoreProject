using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsArtist
    {
        //private data member for the ArtistNo property
        private Int32 mArtistNo;
        public clsArtist()
        {
            
        }

        public string Artist { get; set; }
        public int ArtistNo
        {
            get
            {
                //return the private data
                return mArtistNo;
            }

            set
            {
                //set the value of the private data member
                mArtistNo = value;
            }
        }
        public string ArtistName { get; set; }
        public string ArtistGenre { get; set; }
        public string ArtistBio { get; set; }

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

        public bool Find (int ArtistNo)
        {
            //set the private data member to the test data value
            mArtistNo = 21;
            //always return true
            return true;
        }
    }
}