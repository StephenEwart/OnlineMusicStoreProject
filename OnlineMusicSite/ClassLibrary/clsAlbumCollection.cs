using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsAlbumCollection
    {
        //public int Count { get; set; }
        //private List<clsAlbum> AllAlbums { get; set; }

        //private data member for the allalbums list 
        private List<clsAlbum> mAllAlbums = new List<clsAlbum>();
    
        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllAlbums.Count;
            }
            set
            {
                //
            }
        }

        //public property of allAlbums
        public List<clsAlbum> AllAlbums
        {
            //getter sends data to requesting code 
            get
            {
                //retuen the private member
                return mAllAlbums;
            }
            //setter accepts data from other objects 
            set
            {
                //assign the incoming value to private data member 
                mAllAlbums = value;
            }
        }

    }
}