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
            AnAlbum.Album = SomeAlbum;
            //test to see that the 2 values are the same
            Assert.AreEqual(AnAlbum.Album, SomeAlbum);
        }

        [TestMethod]
        public void AlbumGenreOK()
        {
            //create an instance of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property
            string SomeAlbum = "Rap/Hip-Hop";
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
    }
}
