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

        //public constructor for the class 
        public clsAlbumCollection()
        {
            //create an instance of the album class to store a album
            clsAlbum AAlbum = new clsAlbum();
            //set the album to 
            AAlbum.Album = "Tha Carter V";
            //add the album to the private list of alnums
            mAllAlbums.Add(AAlbum);
            //re initialise the aalbum object to accept a new item
            AAlbum = new clsAlbum();
            //set the album to the private list of albums 
            AAlbum.Album = "KamiKaze";
            //add the second album to the private list 
            AllAlbums.Add(AAlbum);
            //the private list now contains 2 albums
        }

    }
}
