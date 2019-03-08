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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblArtist_SelectAll");
            //get the count of records 
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the artist class
                clsArtist AnArtist = new clsArtist();
                //get the artist name
                AnArtist.Artist = DB.DataTable.Rows[Index]["Artist"].ToString();
                //get the primary key
                AnArtist.ArtistID = Convert.ToInt32(DB.DataTable.Rows[Index]["ArtistID"]);
                //add the artist to the private data member
                mAllArtists.Add(AnArtist);
                //increment the index
                Index++;
            }
        }
    }
}
