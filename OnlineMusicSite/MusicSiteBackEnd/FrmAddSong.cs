using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace MusicSiteBackEnd
{
    public partial class FrmAddSong : Form
    {
        public int SongID;

        public object lblError { get; private set; }

        public FrmAddSong(int SongID)
        {
            InitializeComponent();
            this.SongID = SongID;
            txtSongID.Text = Convert.ToString(SongID);

            if (SongID != 0)
            {
                DisplaySongs(SongID);
            }
        }

        public void AddSong()
        {
            //instance of the data connection class
            clsDataConnection dataConnect = new clsDataConnection();
            //add parameters to SQL 
            dataConnect.AddParameter("@SongName", txtSongName.Text);
            dataConnect.AddParameter("@SongArtist", txtSongArtist.Text);
            dataConnect.AddParameter("@SongAlbum", txtSongAlbum.Text);
            dataConnect.AddParameter("@SongGenre", txtSongGenre.Text);
            //execute stored procedure 
            dataConnect.Execute("sproc_tblSong_Insert");
        }

        private void DisplaySongs(int songID)
        {
            clsSongCollection Song = new clsSongCollection();
            Song.ThisSong.Find(SongID);
            txtSongName.Text = Song.ThisSong.SongName;
            txtSongArtist.Text = Song.ThisSong.SongArtist;
            txtSongAlbum.Text = Song.ThisSong.SongAlbum;
            txtSongGenre.Text = Song.ThisSong.SongGenre;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSong();
        }

        private void FrmAddSong_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
