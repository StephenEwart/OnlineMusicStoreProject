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

              //public constructor for the class
        public clsArtistCollection()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //set the artist to "Drake"
            AnArtist.Artist = "Drake";
            //add the artist to the private list of artists
            mAllArtists.Add(AnArtist);
            //re initialise the AnArtist object to accept a new item
            AnArtist = new clsArtist();
            //set the artist to Taylor Swift
            AnArtist.Artist = "Taylor Swift";
            //add the second artist to the private list of artists
            mAllArtists.Add(AnArtist);
            //the private list now contains two artists
        }
    }
}

    




