using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsArtistCollection
    {
        //private data member for the allartists list
        private List<clsArtist> mAllArtists = new List<clsArtist>();

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllArtists.Count;
            }
            set
            {

            }
        }
        public List<clsArtist> AllArtists
        {
            get
            {
                //return the count property of the private list
                return mAllArtists;
            }
            set
            {
                //assign the incoming value to the private data member
                mAllArtists = value;
            }
        }
    }
}
    




