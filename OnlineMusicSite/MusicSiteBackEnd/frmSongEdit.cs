﻿using System;
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
    public partial class frmSongEdit : Form
    {
        public frmSongEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSongEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            EditSong();
        }
        public void EditSong()
        {
            //instance of data connection class
            clsDataConnection dataConnect = new clsDataConnection();
            //add parameters to SQL
            dataConnect.AddParameter("@SongName", txtSongName.Text);
            dataConnect.AddParameter("@SongArtist", txtSongArtist.Text);
            dataConnect.AddParameter("@SongAlbum", txtSongAlbum.Text);
            dataConnect.AddParameter("@SongGenre", txtSongGenre.Text);

            //execute stored procedure
            dataConnect.Execute("sproc_tblSong_Update");
        }
    }
}
