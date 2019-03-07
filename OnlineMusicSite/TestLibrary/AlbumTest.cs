using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class AlbumTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the clsalbum 
            clsAlbum AnAblum = new clsAlbum();
            //test to see that it exists 
            Assert.IsNotNull(AnAblum);
        }
        [TestMethod]
        public void AlbumPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "Tha Carter V";
            AnAlbum.Album = SomeAlbum;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnAlbum.Album, SomeAlbum);
        }

        [TestMethod]
        public void ArtistIDOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "1234";
            AnAlbum.Album = SomeAlbum;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.Album, SomeAlbum);
        }

        [TestMethod]
        public void AlbumPriceOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "£9.99";
            AnAlbum.Album = SomeAlbum;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.Album, SomeAlbum);
        }

        [TestMethod]
        public void AlbumReleaseDateOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "10/11/18";
            AnAlbum.Album = SomeAlbum;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.Album, SomeAlbum);
        }

        [TestMethod]
        public void AlbumNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            Int32 AlbumNo = 1;
            //assign the data to the property 
            AnAlbum.AlbumNo = AlbumNo;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.AlbumNo, AlbumNo);
        }
      

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "Lil Wayne";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AlbumNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArtistIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AlbumPriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AlbumReleaseDateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumNameMinBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "a";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ArtistIDMinBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "a";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AlbumPriceMinBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "a";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleasedateMinBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "a";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AlbumNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "aa";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArtistIDMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "aa";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "aa";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleaseDateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "aa";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234567890123456789012345678";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArtistIDMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234567890123456789012345678";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234567890123456789012345678";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleasedateMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234567890123456789012345678";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AlbumnameMaxBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "01234567890123456789012345678901234567890123456789";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArtistIDMaxBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "01234567890123456789012345678901234567890123456789";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMaxBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "01234567890123456789012345678901234567890123456789";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleaseDateMaxBoundry()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "01234567890123456789012345678901234567890123456789";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "012345678901234567890123456789012345678901234567890";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArtistIDMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "012345678901234567890123456789012345678901234567890";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "012345678901234567890123456789012345678901234567890";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleasedateMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "012345678901234567890123456789012345678901234567890";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumNameMid()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArtistIDMid()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceMid()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleaseDateMid()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "0123456789012345678901234";
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumNameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //pad the string with characters 
            SomeAlbum = SomeAlbum.PadRight(500, 'a');
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ArtistIDExtremeMax()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //pad the string with characters 
            SomeAlbum = SomeAlbum.PadRight(500, 'a');
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumPriceExtremeMax()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //pad the string with characters 
            SomeAlbum = SomeAlbum.PadRight(500, 'a');
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumReleasedateExtremeMax()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create a string variable to store the results of the validation 
            string Error = "";
            //create some test data to test the meothod 
            string SomeAlbum = "";
            //pad the string with characters 
            SomeAlbum = SomeAlbum.PadRight(500, 'a');
            //invoke the mothod
            Error = AnAlbum.Valid(SomeAlbum);
            //test to see that the result is ok there was no error msg returned 
            Assert.AreNotEqual(Error, "");
        }
    }
}
