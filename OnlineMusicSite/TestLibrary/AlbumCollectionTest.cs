using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class AlbumCollectionTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsAlbumCollection AllAlbums = new clsAlbumCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAlbums);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsAlbumCollection AllAlbums = new clsAlbumCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 1;
            //assign the data to the property
            AllAlbums.Count = SomeCount;
            //test to see that the 2 values are the same
            Assert.AreEqual(AllAlbums.Count, SomeCount);
        }


    }
}
