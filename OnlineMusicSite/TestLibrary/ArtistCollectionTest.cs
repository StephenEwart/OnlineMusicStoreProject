using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestLibrary
{
    [TestClass]
    public class ArtistCollectionTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of clsArtistCollection
            clsArtistCollection AllArtists = new clsArtistCollection();
            //test to see that it exists
            Assert.IsNotNull(AllArtists);
        }
        [TestMethod]
        public void ArtistCountOK()
        {
            //create an instance of clsArtistCollection
            clsArtistCollection AllArtists = new clsArtistCollection();
            //create some test data to asssign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllArtists.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllArtists.Count, SomeCount);
        }

        [TestMethod]
        public void AllArtistsOK()
        {
            //create an instance of clsArtistCollection
            clsArtistCollection Artists = new clsArtistCollection();
            //create some test data to asssign to the property
            //data is list of objects
            List<clsArtist> TestList = new List<clsArtist>();
            //create the item of test data
            clsArtist TestItem = new clsArtist();
            //set its properties
            TestItem.ArtistNo = 1;
            TestItem.Artist = "Drake";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Artists.AllArtists = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Artists.AllArtists, TestList);
        }
    }
}
