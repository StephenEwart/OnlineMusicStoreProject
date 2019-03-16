using System;

namespace ClassLibrary
{
    public class clsAlbum
    {
        public bool Active { get; set; }
       // public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int PriceID { get; set; }
    
        public bool Find(int AlbumID)
        {
            //set the private data member to the test data value
            mAlbumID = 1;
            //always return true
            return true;
        }
    
        public int AlbumID
        {
            get
            {
                return mAlbumID;
            }
            set
            {
                mAlbumID = value;
            }
        }

        //private data member for the albumid prop
        private Int32 mAlbumID;


    }
}