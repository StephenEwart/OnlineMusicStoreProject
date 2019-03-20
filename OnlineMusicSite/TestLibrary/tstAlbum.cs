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



        //[TestMethod]
        //public void ActivePropertyOK()
        //{
        //    //create an instnace of the class we want to create 
        //    clsAlbum AnAlbum = new clsAlbum();
        //    //create some test data to assign to the property 
        //    Boolean TestData = true;
        //    //assign the data to the property
        //    AnAlbum.Active = TestData;
        //    //test to see that the two value are the same
        //    Assert.AreEqual(AnAlbum.Active, TestData);
        //}

        [TestMethod]
        public void AlbumIDPropertyOK()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the proptery
            AnAlbum.AlbumID = TestData;
            //test to see that the 2 values are equal
            Assert.AreEqual(AnAlbum.AlbumID, TestData);
        }

        [TestMethod]
        public void AlbumNamePropertyOK()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property 
            string TestData = "Tha Carter V";
            //assign the data to the proptery
            AnAlbum.AlbumName = TestData;
            //test to see that the 2 values are equal
            Assert.AreEqual(AnAlbum.AlbumName, TestData);
        }

        [TestMethod]
        public void PriceIDOK()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property
            AnAlbum.PriceID = TestData;
            //test to see that the 2 values are equal
            Assert.AreEqual(AnAlbum.PriceID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AlbumID = 1;
            //invoke the method
            Found = AnAlbum.Find(AlbumID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAlbumIDFound()
        {
            //create an instnace of the class we want to create 
            clsAlbum AnAlbum = new clsAlbum();
            //bool variable to store the result of the validation
            Boolean Found = false;
            //bool variable to record if data is ok
            Boolean OK = true;
            //create  some test data to use the mothod 
            Int32 AlbumID = 1;
            //invoke the mothod
            Found = AnAlbum.Find(AlbumID);
            //check the album id
            if (AnAlbum.AlbumID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);            
        }


    }
}