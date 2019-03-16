using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class tstAlbum
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //test to see that it exists
            Assert.IsNotNull(AnAlbum);
        }
    }
}
