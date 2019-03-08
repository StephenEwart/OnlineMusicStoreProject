using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class ArtistTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test to see it exists
            Assert.IsNotNull(AnArtist);
        }

        [TestMethod]

        public void ArtistNameOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test data to assign to property
            string SomeArtist = "Drake";
            //test data assigned to property
            AnArtist.Artist = SomeArtist;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.Artist, SomeArtist);
        }

        [TestMethod]

        public void ArtistGenreOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test data to assign to property
            string SomeArtist = "Rap";
            //test data assigned to property
            AnArtist.Artist = SomeArtist;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.Artist, SomeArtist);
        }

        [TestMethod]

        public void ArtistBioOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test data to assign to property
            string SomeArtist = "Rapper";
            //test data assigned to property
            AnArtist.Artist = SomeArtist;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.Artist, SomeArtist);
        }

        [TestMethod]

        public void ArtistIDOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test data to assign to property
            Int32 ArtistID = 1;
            //test data assigned to property
            AnArtist.ArtistID = ArtistID;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.ArtistID, ArtistID);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "Drake";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMinLessOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        public void ArtistGenreMinLessOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        public void ArtistBioMinLessOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMinBoundary()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "a";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMinBoundary()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "a";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMinBoundary()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "a";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMinPlusOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "aa";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMinPlusOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "aa";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMinPlusOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "aa";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMaxLessOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMaxLessOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMaxLessOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMaxBoundary()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMaxBoundary()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMaxBoundary()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMaxPlusOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMaxPlusOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMaxPlusOne()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMid()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "0123456789012345678901234";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMid()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "0123456789012345678901234";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMid()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            //test data assigned to property
            string SomeArtist = "0123456789012345678901234";
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //a test to see the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ArtistNameExtremeMax()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "";
            //pad the string with characters
            SomeArtist = SomeArtist.PadRight(500, 'a');
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArtistGenreExtremeMax()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "";
            //pad the string with characters
            SomeArtist = SomeArtist.PadRight(500, 'a');
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ArtistBioExtremeMax()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //create a string variable to store the result of the validation
            string Error = "";
            //test data assigned to property
            string SomeArtist = "";
            //pad the string with characters
            SomeArtist = SomeArtist.PadRight(500, 'a');
            //invoke the method
            Error = AnArtist.Valid(SomeArtist);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsArtist AnArtist = new clsArtist();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ArtistID = 1;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestArtistIDFound()
        {
            //create an instance of the class we want to create
            clsArtist AnArtist = new clsArtist();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ArtistID = 21;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //check the ArtistID
            if (AnArtist.ArtistID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArtistNameFound()
        {
            //create an instance of the class we want to create
            clsArtist AnArtist = new clsArtist();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ArtistID = 21;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //check the ArtistID
            if (AnArtist.ArtistName != "Drake")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArtistGenreFound()
        {
            //create an instance of the class we want to create
            clsArtist AnArtist = new clsArtist();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ArtistID = 21;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //check the ArtistID
            if (AnArtist.ArtistGenre != "Rap")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArtistBioFound()
        {
            //create an instance of the class we want to create
            clsArtist AnArtist = new clsArtist();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ArtistID = 21;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //check the ArtistID
            if (AnArtist.ArtistBio != "Rapper")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
