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
            string ArtistName = "Drake";
            //test data assigned to property
            AnArtist.Artist = ArtistName;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.Artist, ArtistName);
        }

        [TestMethod]

        public void ArtistGenreOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test data to assign to property
            string ArtistGenre = "Rap";
            //test data assigned to property
            AnArtist.Artist = ArtistGenre;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.Artist, ArtistGenre);
        }

        [TestMethod]

        public void ArtistBioOK()
        {
            //create an instance of clsArtist
            clsArtist AnArtist = new clsArtist();
            //test data to assign to property
            string ArtistBio = "Rapper";
            //test data assigned to property
            AnArtist.Artist = ArtistBio;
            //a test to see the two values are the same
            Assert.AreEqual(AnArtist.Artist, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "a";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "a";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "a";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "aa";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "aa";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "aa";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "0123456789012345678901234567890123456789012345678";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "0123456789012345678901234567890123456789012345678";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "01234567890123456789012345678901234567890123456789";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "01234567890123456789012345678901234567890123456789";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "012345678901234567890123456789012345678901234567890";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "012345678901234567890123456789012345678901234567890";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "0123456789012345678901234";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "0123456789012345678901234";
            string ArtistBio = "Canadian Rapper";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "0123456789012345678901234";
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "";
            string ArtistGenre = "Rap";
            string ArtistBio = "Canadian Rapper";
            //pad the string with characters
            ArtistName = ArtistName.PadRight(500, 'a');
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "";
            string ArtistBio = "Canadian Rapper";
            //pad the string with characters
            ArtistGenre = ArtistGenre.PadRight(500, 'a');
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            string ArtistName = "Drake";
            string ArtistGenre = "Rap";
            string ArtistBio = "";
            //pad the string with characters
            ArtistBio = ArtistBio.PadRight(500, 'a');
            //invoke the method
            Error = AnArtist.Valid(ArtistName, ArtistGenre, ArtistBio);
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
            Int32 ArtistID = 1;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //check the ArtistID
            if (AnArtist.ArtistID != 1)
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
            Int32 ArtistID = 1;
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
            Int32 ArtistID = 1;
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
            Int32 ArtistID = 1;
            //invoke the method
            Found = AnArtist.Find(ArtistID);
            //check the ArtistID
            if (AnArtist.ArtistBio != "Rapper from Canada")
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
            clsArtistCollection AllArtists = new clsArtistCollection();
            //create the item of test data
            clsArtist TestItem = new clsArtist();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArtistID = 1;
            TestItem.ArtistName = "Iron Maiden";
            TestItem.ArtistGenre = "Metal";
            TestItem.ArtistBio = "Legendary Metal band";
            //set thisArtist to the test data
            AllArtists.ThisArtist = TestItem;
            //add the record
            PrimaryKey = AllArtists.Add();
            //set the primary key of the test data
            TestItem.ArtistID = PrimaryKey;
            //find the record
            AllArtists.ThisArtist.Find(PrimaryKey);
            //test ti see that the two values are the same
            Assert.AreEqual(AllArtists.ThisArtist, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsArtistCollection AllArtists = new clsArtistCollection();
            //create the item of test data
            clsArtist TestItem = new clsArtist();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArtistID = 1;
            TestItem.ArtistName = "Iron Maiden";
            TestItem.ArtistGenre = "Metal";
            TestItem.ArtistBio = "Legendary Metal band";
            //set ThisArtist to the test data
            AllArtists.ThisArtist = TestItem;
            //add the record
            PrimaryKey = AllArtists.Add();
            //set the primary key of the test data#
            TestItem.ArtistID = PrimaryKey;
            //find the record
            AllArtists.ThisArtist.Find(PrimaryKey);
            //delete the record
            AllArtists.Delete();
            //now find the record
            Boolean Found = AllArtists.ThisArtist.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsArtistCollection AllArtists = new clsArtistCollection();
            //create the item of test data
            clsArtist TestItem = new clsArtist();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ArtistID = 1;
            TestItem.ArtistName = "Iron Maiden";
            TestItem.ArtistGenre = "Metal";
            TestItem.ArtistBio = "Legendary Metal band";
            //set ThisArtist to the test data
            AllArtists.ThisArtist = TestItem;
            //add the record
            PrimaryKey = AllArtists.Add();
            //set the primary key of the test data
            TestItem.ArtistID = PrimaryKey;
            //modify the test data
            TestItem.ArtistID = 10;
            TestItem.ArtistName = "RUN DMC";
            TestItem.ArtistGenre = "Rap";
            TestItem.ArtistBio = "Iconic Rap group";
            //set the record based on the new test data
            AllArtists.ThisArtist = TestItem;
            //update the record
            AllArtists.Update();
            //find the record
            AllArtists.ThisArtist.Find(PrimaryKey);
            //test to see thisArtist matches the test data
            Assert.AreEqual(AllArtists.ThisArtist, TestItem);
        }

        [TestMethod]
        public void ReportByArtistNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsArtistCollection AllArtists = new clsArtistCollection();
            //create an instance of the filtered data
            clsArtistCollection FilteredArtists = new clsArtistCollection();
            //apply a blank string (should return all records)
            FilteredArtists.ReportByArtistName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllArtists.Count, FilteredArtists.Count);
        }

        [TestMethod]
        public void ReportByArtistNameNoneFound()
        {
            //create an instance of the filtered data
            clsArtistCollection FilteredArtist = new clsArtistCollection();
            //apply an Artist name that does not exist
            FilteredArtist.ReportByArtistName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredArtist.Count);
        }
    }
}
