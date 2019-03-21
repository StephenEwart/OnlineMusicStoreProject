using System;

namespace ClassLibrary
{
    public class clsAlbum
    {
        //private data member for albumid
        private Int32 mAlbumID;
        //private data member for albumname
        private string mAlbumName;
        //private data member for releasedate
        private DateTime mReleaseDate;
        //private data member for apriceid
        private Int32 mPriceID;

        //public clsAlbum()
        //{

        //}
        //public string AlbumName { get; set; }

        //public int AlbumID { get; set; }

        public string Valid( string AlbumName)
        {
            //string variable to store the error msg
            string Error = "";
            //if the name of the album is more than 50 characters 
            if (AlbumName.Length > 50)
            {
                //return an error msg
                Error = "The album name cannot have more than 50 chararcters";
            }
            if (AlbumName.Length == 0)
            {
                //otherwise return an error msg
                return "The album name may not be blank";
            }
            return Error;
        }
        //get the property for albumid
        public int AlbumID
        {
            get
            {
                //return private data
                return mAlbumID;
            }
            set
            {
                //set the private data 
                mAlbumID = value;
            }
        }

        //get the property for AlbumName
        public string AlbumName
        {
            get
            {
                //return private data
                return mAlbumName;
            }
            set
            {
                //set the private data 
                mAlbumName = value;
            }
        }

        //get the property for ReleaseDate
        public DateTime ReleaseDate
        {
            get
            {
                //return private data
                return mReleaseDate;
            }
            set
            {
                //set the private data 
                mReleaseDate = value;
            }
        }

        //get the property for ArtistID
     

        //get the property for PriceID
        public int PriceID
        {
            get
            {
                //return private data
                return mPriceID;
            }
            set
            {
                //set the private data 
                mPriceID = value;
            }
        }

        public bool Find(int AlbumID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AlbumID", AlbumID);
            DB.Execute("sproc_tblAlbum_FilterByAlbumID");
            if (DB.Count == 1)
            {
                mAlbumID = Convert.ToInt32(DB.DataTable.Rows[0]["AlbumID"]);
                mAlbumName = Convert.ToString(DB.DataTable.Rows[0]["AlbumName"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);                
                mPriceID = Convert.ToInt32(DB.DataTable.Rows[0]["PriceID"]);
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
