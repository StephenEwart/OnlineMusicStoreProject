﻿using System;
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
    public partial class frmAddArtist : Form
    {
        public frmAddArtist()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddArtist()
        {
            //instance of data connection class
            clsDataConnection dataConnect = new clsDataConnection();
            //add parameters to SQL
            dataConnect.AddParameter("@ArtistName", txtArtistName.Text);
            dataConnect.AddParameter("@ArtistGenre", txtGenre.Text);
            dataConnect.AddParameter("@ArtistBio", txtBio.Text);
            //execute stored procedure
            dataConnect.Execute("sproc_tblArtist_Insert");
        }

       

        private void frmAddArtist_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //call addartist function
            AddArtist();
            lblError.Text = " Add Complete";
        }
    }
}
