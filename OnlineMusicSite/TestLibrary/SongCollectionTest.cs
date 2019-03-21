using System;
<<<<<<< HEAD
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
=======
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
using System.Collections.Generic;

namespace TestLibrary
{

    [TestClass]
    public class SongCollectionTest
    {
        [TestMethod]
<<<<<<< HEAD
=======

>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSongCollection AllSongs = new clsSongCollection();
<<<<<<< HEAD
            //test to see that it exists 
=======
            //test to see that it exists
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
            Assert.IsNotNull(AllSongs);
        }

        [TestMethod]
        public void SongCountOK()
        {
<<<<<<< HEAD
            //create an instance of the class we want to create
=======
            //create an instance of clsSongCollection 
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
            clsSongCollection AllSongs = new clsSongCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 5;
            //assign the data to the property
            AllSongs.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllSongs.Count, SomeCount);
        }
<<<<<<< HEAD

=======
        
>>>>>>> parent of 75a771a... Merge branch 'master' into todays_work
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of clsSongCollection 
            clsSongCollection AllSongs = new clsSongCollection();
            //create some test data to assign to the property 
            //data is list of objects
            List<clsSong> TestList = new List<clsSong>();
            //create the item of test data
            clsSong TestItem = new clsSong();
            //set its properties 
            TestItem.SongID = 5;
            TestItem.Song = "Difference";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assgn the data to the property 
            AllSongs.SongList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSongs.Count, TestList.Count);
        }
    }
}
