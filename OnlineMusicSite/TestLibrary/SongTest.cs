using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class SongTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //test to see that it exists
            Assert.IsNotNull(ASong);
        }

        [TestMethod]
<<<<<<< HEAD
        public void SongPropertyOK()
=======

        public void SongIDOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to assign to the property
            Int32 SongID = 1;
            //assign the data to the property
            ASong.SongID = SongID;
            //test to see that the two values are the same
            Assert.AreEqual(ASong.SongID, SongID);
        }

        public void SongNameOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to assign to the property
            string SongName = "Difference";
            //assign the data to the property
            ASong.Song = SongName;
            //test to see that the two values are the same
            Assert.AreEqual(ASong.Song, SongName);
        }

        [TestMethod]
        public void SongArtistOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to assign to the property
            string SongArtist = "Amrit Maan";
            //assign the data to the property 
            ASong.SongArtist = SongArtist;
            //test to see that the two values are the same 
            Assert.AreEqual(ASong.Song, SongArtist);
        }

        [TestMethod]
        public void SongAlbumOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to assign to the property
            string SongAlbum = "DAMN";
            //test data assigned to property
            ASong.Song = SongAlbum;
            //test to see that the two values are the same 
            Assert.AreEqual(ASong.Song, SongAlbum);
        }

        [TestMethod]
        public void SongGenreOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to assign to the property
            string SongGenre = "Rap";
            //test data assigned to property
            ASong.Song = SongGenre;
            //test to see that the two values are the same 
            Assert.AreEqual(ASong.Song, SongGenre);
        }

        [TestMethod]
        public void SongNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string SongName = "";
            //invoke the method 
            Error = ASong.Valid(SongID, SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongNameMin()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SongName = "D";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSong ASong = new clsSong();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string SongName = "Di";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string SongName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongNameMax()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string SongName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string SongName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongNameMid()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string SongName = "aaaaaaaaaaaaaaaaaaaaaaa";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMinLessOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should fail
            string SongName = "Difference";
            string SongArtist = "";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMin()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string SongName = "Difference";
            string SongArtist = "A";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSong ASong = new clsSong();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string SongName = "Difference";
            string SongArtist = "Aa";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string SongName = "Difference";
            string SongArtist = "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMax()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string SongName = "Difference";
            string SongArtist = "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string SongName = "Difference";
            string SongArtist = "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongArtistMid()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            string Error = "";
            //this should pass
            string SongName = "Difference";
            string SongArtist = "Aaaaaaaaaaaaaaaaaaaaaaaa";
            string SongAlbum = "Testing";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongAlbumMinLessOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message
            string Error = "";
            //test data assigned to property 
            string SongName = "Difference";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SongAlbumMin()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message
            string Error = "";
            //test data assigned to property 
            string SongName = "Difference";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "a";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongAlbumMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsSong ASong = new clsSong();
            //string variable to store any error message
            string Error = "";
            //test data assigned to property 
            string SongName = "Difference";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "aa";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongAlbumMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store the validation 
            string Error = "";
            //test data assigned to property
            string SongName = "Differene";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testinggggggggggggggggggg";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongAlbumMax()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //string variable to store any error message 
            string Error = "";
            //test data assigned to property
            string SongName = "Difference";
            string SongArtist = "Amrit Maan";
            string SongAlbum = "Testingggggggggggggggggggg";
            string SongGenre = "Bhangra";
            //invoke the method 
            Error = ASong.Valid(SongName, SongArtist, SongAlbum, SongGenre);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SongAlbumMaxPlusOne()
>>>>>>> parent of e43c839... Merge pull request #20 from StephenEwart/todays_work
        {
            //create an instance of the class we want to create
            clsSong Asong = new clsSong();
            //create some test data to asssign to the property
            string SomeSong = "Rockstar";
            //assign the data to the property
            Asong.Song = SomeSong;
            //test to see that the two values are the same
            Assert.AreEqual(Asong.Song, SomeSong);
        }
<<<<<<< HEAD
=======

        public void SongIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to assign to the property 
            Int32 SongID = 1;
            //assign the data to the property 
            ASong.SongID = SongID;
            //test to see that the two values are the same 
            Assert.AreEqual(ASong.SongID, SongID);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create a string variable to store the result of the validation 
            String Error = "";
            //create some test data to test the method
            string SomeSong = "Difference";
            //invoke the method
            Error = ASong.Valid(SomeSong);
            //test to see that the result is OK i.e. there was no error message 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SongID = 1;
            //invoke the method 
            Found = ASong.Find(SongID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSongIDFound()
        {
            //create an instance of the class we want to create 
            clsSong ASong = new clsSong();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if darta is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SongID = 1;
            //invoke the method 
            Found = ASong.Find(SongID);
            //check the song ID
            if (ASong.SongID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSongNameFound()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string SongName = "Difference";
            //invoke the method 
            Found = ASong.Find(SongName);
            //check the property
            if (ASong.SongName != "Test Song Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSongArtistFound()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            string SongArtist = "Amrit Maan";
            //invoke the method
            Found = ASong.Find(SongArtist);
            //check the property 
            if (ASong.SongArtist != "Test Song Artist")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSongAlbumFound()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            string SongAlbum = "DAMN";
            //invoke the method 
            Found = ASong.Find(SongAlbum);
            //check the property 
            if (ASong.SongAlbum != "Test Song Album")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSongGenreFound()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            string SongGenre = "rap";
            //invoke the method 
            Found = ASong.Find(SongGenre);
            //check the property 
            if (ASong.SongGenre != "Test Song Genre")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsSongCollection AllSongs = new clsSongCollection();
            //create the item of test data 
            clsSong TestItem = new clsSong();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.SongID = 1;
            TestItem.SongName = "Issa Jatt";
            TestItem.SongArtist = "Sidhu Moosewala";
            TestItem.SongAlbum = "Issa Jatt";
            TestItem.SongGenre = "Bhangra";
            //set thisSong to the test data 
            AllSongs.ThisSong = TestItem;
            //add the record 
            PrimaryKey = AllSongs.Add();
            //set the primary key to the test data 
            TestItem.SongID = PrimaryKey;
            //find the record 
            AllSongs.ThisSong.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllSongs.ThisSong, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsSongCollection AllSongs = new clsSongCollection();
            //create the item of test data 
            clsSong TestItem = new clsSong();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SongID = 1;
            TestItem.SongName = "Issa Jatt";
            TestItem.SongArtist = "Sidhu Moosewala";
            TestItem.SongAlbum = "Issa Jatt";
            TestItem.SongGenre = "Bhangra";
            //set thisSong to the test data 
            AllSongs.ThisSong = TestItem;
            //add the record 
            PrimaryKey = AllSongs.Add();
            //set the primary key to the test data 
            TestItem.SongID = PrimaryKey;
            //find the record 
            AllSongs.ThisSong.Find(PrimaryKey);
            //delete the record
            AllSongs.Delete();
            //and find the record
            Boolean Found = AllSongs.ThisSong.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsSongCollection AllSongs = new clsSongCollection();
            //create the item of test data 
            clsSong TestItem = new clsSong();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SongID = 1;
            TestItem.SongName = "Issa Jatt";
            TestItem.SongArtist = "Sidhu Moosewala";
            TestItem.SongAlbum = "Issa Jatt";
            TestItem.SongGenre = "Bhangra";
            //set thisSong to the test data 
            AllSongs.ThisSong = TestItem;
            //add the record 
            PrimaryKey = AllSongs.Add();
            //set the primary key to the test data 
            TestItem.SongID = PrimaryKey;
            //modify the test data
            TestItem.SongID = 11;
            TestItem.SongName = "Praise The Lord";
            TestItem.SongArtist = "ASAP Rocky";
            TestItem.SongAlbum = "Testing";
            TestItem.SongGenre = "Rap";
            //set the record based on the new test data 
            AllSongs.ThisSong = TestItem;
            //update the record
            AllSongs.Update();
            //find the record
            AllSongs.ThisSong.Find(PrimaryKey);
            //test to see thisSong matches the test data
            Assert.AreEqual(AllSongs.ThisSong, TestItem);
        }

        [TestMethod]
        public void ReportBySongNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsSongCollection AllSongs = new clsSongCollection();
            //create an instance of the filtered data
            clsSongCollection FilteredSongs = new clsSongCollection();
            //apply a blank string (should return all records)
            FilteredSongs.ReportBySongName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSongs.Count, FilteredSongs.Count);
        }

        [TestMethod]
        public void ReportBySongNameNoneFound()
        {
            //create an instance of the filtered data
            clsSongCollection FilteredSongs = new clsSongCollection();
            //apply a song name that does not exist
            FilteredSongs.ReportBySongName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSongs.Count);
        }


>>>>>>> parent of e43c839... Merge pull request #20 from StephenEwart/todays_work
    }
}
