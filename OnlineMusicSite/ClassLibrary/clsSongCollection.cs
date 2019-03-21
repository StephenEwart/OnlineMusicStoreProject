using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSongCollection
    {
        //private data member for the allSongs list 
        private List<clsSong> mAllSongs = new List<clsSong>();
        //private data member for the allSongs list
        private List<clsSong> mSongList = new List<clsSong>();
        //private data member thisSong
        clsSong mThisSong = new clsSong();

        public List<clsSong> SongList
        {
            get
            {
                //return the private data
                return mSongList;
            }
            set
            {
                //set the private data 
                mSongList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count property of the private list 
                return mSongList.Count;
            }
            set
            {

            }
        }


        //public property for thisSong 
        public clsSong ThisSong
        {
            get
            {
                //return the private data 
                return mThisSong;
            }
            set
            {
                //set the private data
                mThisSong = value;
            }
        }

        public object SongName { get; private set; }

        public int Add()
        {
            //adds the new record to the database based on the values of thisSong
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SongName", mThisSong.SongName);
            DB.AddParameter("@SongArtist", mThisSong.SongArtist);
            DB.AddParameter("@SongAlbum", mThisSong.SongAlbum);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSong_Insert");
        }

        public void sortSongList()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            //deletes the record added by thisSong
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SongID", mThisSong.SongID);
            //execute the stored procedure 
            DB.Execute("sproc_tblSong_Delete");
        }

        public void Update()
        {
            //update an existing record based on the value of thisSong
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SongID", mThisSong.SongID);
            DB.AddParameter("@SongName", mThisSong.SongName);
            DB.AddParameter("@SongArtist", mThisSong.SongArtist);
            DB.AddParameter("@SongAlbum", mThisSong.SongAlbum);
            //execute the stored procedure
            DB.Execute("sproc_tblSong_Update");
        }

        //public constructor for the class
        public clsSongCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //send the SongName parameter back to the database 
            DB.AddParameter("@SongName", SongName);
            //execute the stored procedure to get the list of data 
            DB.Execute("sproc_tblSong_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportBySongName(string SongName)
        {
            //filters the records based on a full or partial Song Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the SongName parameter to the database 
            DB.AddParameter("@SongName", SongName);
            //execute the stored procedure 
            DB.Execute("sproc_tblSong_FilterBySongName");
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSongList = new List<clsSong>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsSong ASong = new clsSong();
                //read in the fields from the current records 
                ASong.SongID = Convert.ToInt32(DB.DataTable.Rows[Index]["SongID"]);
                ASong.SongName = Convert.ToString(DB.DataTable.Rows[Index]["SongName"]);
                ASong.SongArtist = Convert.ToString(DB.DataTable.Rows[Index]["SongArtist"]);
                ASong.SongAlbum = Convert.ToString(DB.DataTable.Rows[Index]["SongAlbum"]);
                //add the artist to the private data member
                mSongList.Add(ASong);
                //increment the index
                Index++;
            }
        }
    }
}







        