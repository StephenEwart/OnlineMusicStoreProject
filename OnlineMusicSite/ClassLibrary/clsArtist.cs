using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsArtist
    {
        //private data member for the ArtistID property
        private Int32 mArtistID;
        //private data member for ArtistName
        private string mArtistName;
        //private data member for ArtistGenre
        private string mArtistGenre;
        //private data member for ArtistBio
        private string mArtistBio;

        public clsArtist()
        {
            
        }

        public string Artist { get; set; }
        public int ArtistID
        {
            get
            {
                //return the private data
                return mArtistID;
            }

            set
            {
                //set the value of the private data member
                mArtistID = value;
            }
        }
        public string ArtistName
        {
            get
            {
                //return the private data
                return mArtistName;
            }
            set
            {
                //set the private data
                mArtistName = value;
            }
        }
        public string ArtistGenre
        {
            get
            {
                //return the private data
                return mArtistGenre;
            }
            set
            {
                //set the private data
                mArtistGenre = value;
            }
        }
        public string ArtistBio
        {
            get
            {
                //return the private data
                return mArtistBio;
            }
            set
            {
                //set the private data
                mArtistBio = value;
            }
        }

        public string Valid(string ArtistName, string ArtistGenre, string ArtistBio)
        {
            string Error = "";
            
            //if the Artist Name is blank
            if (ArtistName.Length == 0)
            {
                //record the error
                Error = Error + "The Artist Name may not be blank : ";
            }
            //if the Artist Name is more than 50 characters
            if (ArtistName.Length > 50)
            {
                Error = Error + "The Artist Name may not be more than 6 characters : ";
            }
            //if the Artist Genre is blank
            if (ArtistGenre.Length == 0)
            {
                //record the error
                Error = Error + "The Artist Genre may not be blank : ";
            }
            //if the Artist Genre is more than 50 characters
            if (ArtistGenre.Length > 50)
            {
                Error = Error + "The Artist Genre may not be more than 6 characters : ";
            }
            //if the Artist Bio is blank
            if (ArtistBio.Length == 0)
            {
                //record the error
                Error = Error + "The Artist Bio may not be blank : ";
            }
            //if the Artist Bio is more than 50 characters
            if (ArtistBio.Length > 50)
            {
                Error = Error + "The Artist Bio may not be more than 6 characters : ";
            }
            //return any error messages
            return Error;
        }

        public bool Find (int ArtistID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the artistID to search for
            DB.AddParameter("@ArtistID", ArtistID);
            //execute the stored procedure
            DB.Execute("sproc_tblArtist_FilterByArtistID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mArtistID = Convert.ToInt32(DB.DataTable.Rows[0]["ArtistID"]);
                mArtistName = Convert.ToString(DB.DataTable.Rows[0]["ArtistName"]);
                mArtistGenre = Convert.ToString(DB.DataTable.Rows[0]["ArtistGenre"]);
                mArtistBio = Convert.ToString(DB.DataTable.Rows[0]["ArtistBio"]);
                //return that everything went ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}