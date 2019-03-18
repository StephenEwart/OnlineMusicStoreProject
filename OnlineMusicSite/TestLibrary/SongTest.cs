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
        public void SongPropertyOK()
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
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //create an string variable to store the result of the validation 
            String Error = "";
            //create some test data to test the method 
            string SomeSong = "Difference";
            //invoke the method
            Error = ASong.Valid(SomeSong);
            //test to see that the result is OK i.e. there was no error message returned 
            Assert.AreEqual(Error, "");
        }


    }

}
