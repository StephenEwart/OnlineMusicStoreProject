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
        //private data member for the allartists list
        private List<clsArtist> mArtistList = new List<clsArtist>();

        public List<clsArtist> ArtistList
        {
            get
            {
                //return the private data
                return mArtistList;
            }
            set
            {
                //set the private data
                mArtistList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mArtistList.Count;
            }
            set
            {
                
            }
        }

<<<<<<< HEAD
        //public property for thisArtist
        public clsArtist ThisArtist
        {
            get
            {
                //return the private data
                return mThisArtist;
            }
            set
            {
                //set the private data
                mThisArtist = value;
            }
        }

        public int Add()
        {
            //adds the new record to the database based on the values of thisArtist
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ArtistName", mThisArtist.ArtistName);
            DB.AddParameter("@ArtistGenre", mThisArtist.ArtistGenre);
            DB.AddParameter("@ArtistBio", mThisArtist.ArtistBio);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblArtist_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisArtist
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ArtistID", mThisArtist.ArtistID);
            //execute the stored procedure
            DB.Execute("sproc_tblArtist_Delete");
        }

        public void Update()
        {
            //upate an existing record based on the values of thisArtist
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ArtistID", mThisArtist.ArtistID);
            DB.AddParameter("@ArtistName", mThisArtist.ArtistName);
            DB.AddParameter("@ArtistGenre", mThisArtist.ArtistGenre);
            DB.AddParameter("@ArtistBio", mThisArtist.ArtistBio);
            //exeute the stored procedure
            DB.Execute("sproc_tblArtist_Update");
        }

=======
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        //public constructor for the class
        public clsArtistCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
<<<<<<< HEAD
            //send the ArtistName parameter to the database
            //DB.AddParameter("@ArtistName", ArtistName);
=======
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
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
                AnArtist.Artist = DB.DataTable.Rows[Index]["ArtistName"].ToString();
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
