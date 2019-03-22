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
    public partial class ViewSong : Form
    {
        public ViewSong()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int SongID = Convert.ToInt32(lstSong.SelectedValue);
            AddSong newAdd = new AddSong();
            newAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int SongID = Convert.ToInt32(lstSong.SelectedValue);
            frmSongEdit newEdit = new frmSongEdit();
            newEdit.Show();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            DisplaySongs("");
        }

        void DisplaySongs(string nameFilter)
        {
            clsSongCollection Songs = new clsSongCollection();

            string SongName;
            int index = 0;
            lstSong.Items.Clear();
            Songs.ReportBySongName(nameFilter);
            int recordCount = Songs.Count;
            while (index < recordCount)
            {
                SongName = Convert.ToString(Songs.SongList[index].SongName);
                lstSong.Items.Add(SongName);
                index++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplaySongs(textBox1.Text);
        }
    }
}
