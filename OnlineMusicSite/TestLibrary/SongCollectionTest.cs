using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{

    [TestClass]
    public class SongCollectionTest
    {
        [TestMethod]

        public void InstanceOK()
        {
            //create an instance clsSongCollection
            clsSongCollection AllSongs = new clsSongCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSongs);
        }

        [TestMethod]
        public void SongCountOK()
        {
            //create an instance of clsSongCollection 
            clsSongCollection AllSongs = new clsSongCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 5;
            //assign the data to the property 
            AllSongs.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllSongs.Count, SomeCount);
        }
        
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
