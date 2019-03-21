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
=======
        public void SongPropertyOK()
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data to asssign to the property
            string SomeSong = "Rockstar";
            //assign the data to the property
            ASong.Song = SomeSong;
            //test to see that the two values are the same
            Assert.AreEqual(ASong.Song, SomeSong);
        }

        [TestMethod]
        public void SongNoPropertyOKK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create some test data t assign to the property 
            Int32 SongNo = 1;
            //assign the data to the property 
<<<<<<< HEAD
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
=======
            ASong.SongNo = SongNo;
            //test to see that the two values are the same
            Assert.AreEqual(ASong.SongNo, SongNo);
        }

        clsSong ASong = new clsSong();
        string NewSong = txtSong.Text;
        if (clsSong.Valid(NewSong) == "")
        {
            //do something with the data 
        }
        else
        {
            //display an error message
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
<<<<<<< HEAD
            //create a string variable to store the result of the validation 
=======
            //create an string variable to store the result of the validation 
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
            String Error = "";
            //create some test data to test the method 
            string SomeSong = "Difference";
            //invoke the method
            Error = ASong.Valid(SomeSong);
            //test to see that the result is OK i.e. there was no error message returned 
            Assert.AreEqual(Error, "");
        }



>>>>>>> parent of e43c839... Merge pull request #20 from StephenEwart/todays_work
    }
}
