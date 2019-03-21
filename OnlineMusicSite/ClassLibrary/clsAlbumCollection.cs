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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblAlbum_SelectAll");
            //get the count of records 
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the album class
                clsAlbum AllAlbum = new clsAlbum();
                //get the album name 
                AllAlbum.AlbumID = Convert.ToInt32(DB.DataTable.Rows[Index]["AlbumID"]);
                AllAlbum.AlbumName = Convert.ToString(DB.DataTable.Rows[Index]["AlbumName"]);
                AllAlbum.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AllAlbum.PriceID = Convert.ToInt32(DB.DataTable.Rows[Index]["PriceID"]);
                //add the county to the private data member
                mAlbumsList.Add(AllAlbum);
                //increment the index 
                Index++;
            }

        }

    }
}
