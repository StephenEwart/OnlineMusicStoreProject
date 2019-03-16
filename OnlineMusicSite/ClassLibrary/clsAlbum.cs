using System;

namespace ClassLibrary
{
    public class clsAlbum
    {
        public bool Active { get; set; }
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int PriceID { get; set; }

        public bool Find(int albumID)
        {
            //always return true
            return true;
        }
    }
}