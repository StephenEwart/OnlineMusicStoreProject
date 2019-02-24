using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

        [TestMethod]
        public void AllAlbumsOK()
        {
            //create an instance of the class we want to create 
            clsAlbumCollection Albums = new clsAlbumCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsAlbum> TestList = new List<clsAlbum>();
            //set its properties
            //create the item of test data
            clsAlbum TestItem = new clsAlbum();
            //set its properties 
            TestItem.AlbumNo = 1;
            TestItem.Album = "Lil Wayne";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            Albums.AllAlbums = TestList;
            //test to see that the 2 values are the same 
            Assert.AreEqual(Albums.AllAlbums, TestList);
        }




    }
}
