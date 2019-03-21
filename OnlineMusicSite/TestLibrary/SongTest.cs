using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class SongTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSong ASong = new clsSong();
            //test to see that it exists
            Assert.IsNotNull(ASong);
        }

        [TestMethod]
        public void SongPropertyOK()
        {
            //create an instance of the class we want to create
            clsSong Asong = new clsSong();
            //create some test data to asssign to the property
            string SomeSong = "Rockstar";
            //assign the data to the property
            Asong.Song = SomeSong;
            //test to see that the two values are the same
            Assert.AreEqual(Asong.Song, SomeSong);
        }
    }
}
