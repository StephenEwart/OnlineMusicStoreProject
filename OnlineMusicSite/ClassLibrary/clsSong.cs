﻿using System;
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
=======

        public string Valid(string SongName, string SongArtist, string SongAlbum, string SongGenre)
        {
            string Error = "";

            //if the song name is blank 
            if (SongName.Length == 0)
            {
                //record the error
                Error = Error + "The Song Name may not be blank: ";
            }
            //if the song artist is blank 
            if (SongArtist.Length == 0)
            {
                //record the error 
                Error = Error + "The Song Artist may not be blank: ";
            }
            //if the song album is blank 
            if (SongAlbum.Length == 0)
            {
                //record the error
                Error = Error + "The Song Album may not be blank: ";
            }
            //if the song genre is blank
            if (SongGenre.Length == 0)
            {
                //record the error 
                Error = Error + "The Song Genre may not be blank: ";
            }
            //return any error messages
            return Error;
        }

        public string Valid(string songID, string songName, string songArtist, string songAlbum, object songGenre)
        {
            throw new NotImplementedException();
        }

        public bool Find(int songID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the song id to search for 
            DB.AddParameter("@SongID", SongID);
            //execute the stored procedure 
            DB.Execute("sproc _tblSong_FilterBySongID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mSongID = Convert.ToInt32(DB.DataTable.Rows[0]["SongID"]);
                mSongName = Convert.ToString(DB.DataTable.Rows[0]["SongName"]);
                mSongArtist = Convert.ToString(DB.DataTable.Rows[0]["SongArtist"]);
                mSongAlbum = Convert.ToString(DB.DataTable.Rows[0]["SongAlbum"]);
                mSongGenre = Convert.ToString(DB.DataTable.Rows[0]["SongGenre"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
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
