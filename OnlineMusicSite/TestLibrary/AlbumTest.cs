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
        public void AlbumNameOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "Tha Carter V";
            AnAlbum.AlbumName = SomeAlbum;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnAlbum.AlbumName, SomeAlbum);
        }

        [TestMethod]
        public void AlbumPriceOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "£9.99";
            AnAlbum.AlbumName = SomeAlbum;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.AlbumName, SomeAlbum);
        }

        [TestMethod]
        public void AlbumReleaseDateOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "10/11/18";
            AnAlbum.AlbumName = SomeAlbum;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.AlbumName, SomeAlbum);
        }

        [TestMethod]
        public void AlbumIDOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            Int32 AlbumID = 1;
            //assign the data to the property 
            AnAlbum.AlbumID = AlbumID;
            //test to see the 2 value are the same 
            Assert.AreEqual(AnAlbum.AlbumID, AlbumID);
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
        public void AlbumNameMaxBoundry()
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AlbumID = 1;
            //invoke the method
            Found = AnAlbum.Find(AlbumID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAlbumIDFound()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //bool variable to record if data is ok
            Boolean OK = true;
            //create  some test data to use the mothod 
            Int32 AlbumID = 1;
            //invoke the mothod
            Found = AnAlbum.Find(AlbumID);
            //check the album id
            if (AnAlbum.AlbumID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAlbumNameFound()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //bool variable to record if data is ok
            Boolean OK = true;
            //create  some test data to use the mothod 
            Int32 AlbumID = 1;
            //invoke the mothod
            Found = AnAlbum.Find(AlbumID);
            //check the album id
            if (AnAlbum.AlbumName != "Tha Carter V")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestReleaseDateFound()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //bool variable to record if data is ok
            Boolean OK = true;
            //create  some test data to use the mothod 
            Int32 AlbumID = 1;
            //invoke the mothod
            Found = AnAlbum.Find(AlbumID);
            //check the album id
            if (AnAlbum.ReleaseDate != Convert.ToDateTime("06/12/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceIDFound()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //bool variable to record if data is ok
            Boolean OK = true;
            //create  some test data to use the mothod 
            Int32 AlbumID = 1;
            //invoke the mothod
            Found = AnAlbum.Find(AlbumID);
            //check the album id
            if (AnAlbum.PriceID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
    }
