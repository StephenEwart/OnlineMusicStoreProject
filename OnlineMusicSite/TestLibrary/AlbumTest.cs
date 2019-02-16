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
    }
}
