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
            //create some test data to assign tot the property
            string SomeAlbum = "Tha Carter V";
            AnAlbum.Album = SomeAlbum;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnAlbum.Album, SomeAlbum);
        }


    }
}
