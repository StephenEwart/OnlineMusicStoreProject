using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicSiteBackEnd
{
    public partial class frmSongView : Form
    {
        public object lstSongs { get; private set; }
        public object SongList { get; private set; }
        public object Songs { get; private set; }
        public object lstCustomers { get; private set; }

        public frmSongView()
        {
            InitializeComponent();
        }

    private void lstSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

      private void frmSongView_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            DisplaySongs("");
        }

        private void DisplaySongs(string v)
        {
            throw new NotImplementedException();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddSong addSong = new frmAddSong(Convert.ToInt32(lstSongs));
            addSong.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            clsSongCollection songs = new clsSongCollection();
            songs.sortSongList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsSongCollection Song = new clsSongCollection();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this customer", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {

            }
            DisplaySongs("");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplaySongs(txtSongSearch.Text);
        }
    }
}
