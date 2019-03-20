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
        //private data member thisArtist
        clsArtist mThisArtist = new clsArtist(); 

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

        //public constructor for the class
        public clsArtistCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //send the ArtistName parameter to the database
            //DB.AddParameter("@ArtistName", ArtistName);
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblArtist_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByArtistName(string ArtistName)
        {
            //filters the records based on a full or partial Artist Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ArtistName parameter to the database
            DB.AddParameter("@ArtistName", ArtistName);
            //execute the stored procedure
            DB.Execute("sproc_tblArtist_FilterByArtistName");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mArtistList = new List<clsArtist>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsArtist AnArtist = new clsArtist();
                //read in the fields from the current record
                AnArtist.ArtistID = Convert.ToInt32(DB.DataTable.Rows[Index]["ArtistID"]);
                AnArtist.ArtistName = Convert.ToString(DB.DataTable.Rows[Index]["ArtistName"]);
                AnArtist.ArtistGenre = Convert.ToString(DB.DataTable.Rows[Index]["ArtistGenre"]);
                AnArtist.ArtistBio = Convert.ToString(DB.DataTable.Rows[Index]["ArtistBio"]);
                //add the artist to the private data member
                mArtistList.Add(AnArtist);
                //increment the index
                Index++;
            }
        }
    }
}
