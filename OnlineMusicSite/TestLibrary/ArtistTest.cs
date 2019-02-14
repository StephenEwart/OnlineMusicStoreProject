using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class ArtistTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsArtist AnArtist = new clsArtist();
            Assert.IsNotNull(AnArtist);
        }

        [TestMethod]

        public void ArtistNameOK()
        {
            clsArtist AnArtist = new clsArtist();
            string SomeArtist = "Drake";
            AnArtist.Artist = SomeArtist;
            Assert.AreEqual(AnArtist.Artist, SomeArtist);
        }

        [TestMethod]

        public void ArtistGenreOK()
        {
            clsArtist AnArtist = new clsArtist();
            string SomeArtist = "Rap";
            AnArtist.Artist = SomeArtist;
            Assert.AreEqual(AnArtist.Artist, SomeArtist);
        }

        [TestMethod]

        public void ArtistBioOK()
        {
            clsArtist AnArtist = new clsArtist();
            string SomeArtist = "Rapper";
            AnArtist.Artist = SomeArtist;
            Assert.AreEqual(AnArtist.Artist, SomeArtist);
        }

        [TestMethod]

        public void ArtistNoOK()
        {
            clsArtist AnArtist = new clsArtist();
            Int32 ArtistNo = 1;
            AnArtist.ArtistNo = ArtistNo;
            Assert.AreEqual(AnArtist.ArtistNo, ArtistNo);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "Drake";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMinLessOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        public void ArtistGenreMinLessOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        public void ArtistBioMinLessOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMinBoundary()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "a";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMinBoundary()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "a";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMinBoundary()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "a";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMinPlusOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "aa";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMinPlusOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "aa";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMinPlusOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "aa";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMaxLessOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "0123456789012345678901234567890123456789012345678";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMaxLessOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "0123456789012345678901234567890123456789012345678";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMaxLessOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "0123456789012345678901234567890123456789012345678";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMaxBoundary()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "01234567890123456789012345678901234567890123456789";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMaxBoundary()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "01234567890123456789012345678901234567890123456789";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMaxBoundary()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "01234567890123456789012345678901234567890123456789";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMaxPlusOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "012345678901234567890123456789012345678901234567890";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMaxPlusOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "012345678901234567890123456789012345678901234567890";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMaxPlusOne()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "012345678901234567890123456789012345678901234567890";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ArtistNameMid()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "0123456789012345678901234";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistGenreMid()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "0123456789012345678901234";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void ArtistBioMid()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "0123456789012345678901234";
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreEqual(Error, "");
        }

        public void ArtistNameExtremeMax()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "";
            SomeArtist = SomeArtist.PadRight(500, 'a');
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        public void ArtistGenreExtremeMax()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "";
            SomeArtist = SomeArtist.PadRight(500, 'a');
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }

        public void ArtistBioExtremeMax()
        {
            clsArtist AnArtist = new clsArtist();
            string Error = "";
            string SomeArtist = "";
            SomeArtist = SomeArtist.PadRight(500, 'a');
            Error = AnArtist.Valid(SomeArtist);
            Assert.AreNotEqual(Error, "");
        }
    }
}
