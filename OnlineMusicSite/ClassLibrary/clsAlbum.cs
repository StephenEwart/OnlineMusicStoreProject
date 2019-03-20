using System;

namespace ClassLibrary
{
    public class clsAlbum
    {
        //public bool Active { get; set; }
        //public int AlbumID { get; set; }
        //public string AlbumName { get; set; }
        //public int PriceID { get; set; }

        //private data member for the albumid prop
        private Int32 mAlbumID;
        private string mAlbumName;
        private DateTime mReleaseDate;
        private Int32 mArtistID;
        private Int32 mPriceID;

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
                return AlbumName;
            }
            set
            {
                //set the private data 
                AlbumName = value;
            }
        }

        //get the property for ReleaseDate
        public DateTime ReleaseDate
        {
            get
            {
                //return private data
                return ReleaseDate;
            }
            set
            {
                //set the private data 
                ReleaseDate = value;
            }
        }

        //get the property for ArtistID
        public int ArtistID
        {
            get
            {
                //return private data
                return ArtistID;
            }
            set
            {
                //set the private data 
                ArtistID = value;
            }
        }

        //get the property for PriceID
        public int PriceID
        {
            get
            {
                //return private data
                return PriceID;
            }
            set
            {
                //set the private data 
                PriceID = value;
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
                mArtistID = Convert.ToInt32(DB.DataTable.Rows[0]["ArtistID"]);
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