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
        private List<clsAlbum> mAlbumsList = new List<clsAlbum>();

        //public property of allAlbums
        public List<clsAlbum> AlbumsList
        {
            //getter sends data to requesting code 
            get
            {
                //retuen the private member
                return mAlbumsList;
            }
            //setter accepts data from other objects 
            set
            {
                //assign the incoming value to private data member 
                mAlbumsList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAlbumsList.Count;
            }
            set
            {
                //
            }
        }
        //public constructor for the class 
        public clsAlbumCollection()
        {
            ////create an instance of the album class to store a album
            //clsAlbum AAlbum = new clsAlbum();
            ////set the album to 
            //AAlbum.Album = "Tha Carter V";
            ////add the album to the private list of alnums
            //mAllAlbums.Add(AAlbum);
            ////re initialise the aalbum object to accept a new item
            //AAlbum = new clsAlbum();
            ////set the album to the private list of albums 
            //AAlbum.Album = "KamiKaze";
            ////add the second album to the private list 
            //mAllAlbums.Add(AAlbum);
            //AAlbum = new clsAlbum();
            ////set the album to the private list of albums 
            //AAlbum.Album = "Tomorrow";
            ////add the second album to the private list 
            //mAllAlbums.Add(AAlbum);
            ////the private list now contains 2 albums

            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblAlbum_SelectAll");
            //get the count of records 
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the album class
                clsAlbum AllAlbum = new clsAlbum();
                //get the album name 
                AllAlbum.AlbumName = DB.DataTable.Rows[Index]["AlbumName"].ToString();
                //get the primary key
                AllAlbum.AlbumID = Convert.ToInt32(DB.DataTable.Rows[Index]["AlbumID"]);
                //add the county to the private data member
                mAlbumsList.Add(AllAlbum);
                //increment the index 
                Index++;
            }

        }

    }
}
