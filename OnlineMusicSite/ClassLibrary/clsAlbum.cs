using System;

namespace ClassLibrary
{
    public class clsAlbum
    {
        public string AlbumName { get; set; }
       
        public int AlbumID { get; set; }

        public string Valid(string someAlbum)
        {
            //string variable to store the error msg
            string Error = "";
            //if the name of the album is more than 50 characters 
            if (someAlbum.Length >50)
            {
                //return an error msg
                Error = "The album name cannot have more than 50 chararcters";
            }
            if (someAlbum.Length ==0)
            {
                //otherwise return an error msg
                return "The album name may not be blank";
            }
            return Error;
        }
    }
}