using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsSong
    {
        public string Song { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
=======

        public string Valid(string SongName, string SongArtist, string SongAlbum, string SongGenre)
=======
        public int SongNo { get; set; }

        public bool Valid(string SomeSong)
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        {
            throw new NotImplementedException();
        }
    }

<<<<<<< HEAD
        public string Valid(string songID, string songName, string songArtist, string songAlbum, object songGenre)
        {
            throw new NotImplementedException();
        }

        public bool Find(int songID)
=======
    public string Valid(string someSong)
    {
        //if the name of the county is not blank
        if (someSong !== "")
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        {
            //return a blank string 
            return "";
        }
        else
        {
            //otherwise return an error message 
            return "The song name may not be blank!";
        }

        public string Valid(string songName, string songArtist, string songAlbum, object songGenre)
        {
            throw new NotImplementedException();
        }

        public bool Find(string songName)
        {
            throw new NotImplementedException();
        }

        public string Valid(object songName, string songArtist, string songAlbum, object songGenre)
        {
            throw new NotImplementedException();
        }

        public string Valid(string someSong)
        {
            throw new NotImplementedException();
        }
>>>>>>> parent of e43c839... Merge pull request #20 from StephenEwart/todays_work
    }
}
