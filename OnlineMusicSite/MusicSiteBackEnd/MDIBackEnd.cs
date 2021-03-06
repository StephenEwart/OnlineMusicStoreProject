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
    public partial class MDIBackEnd : Form
    {
        private int childFormNumber = 0;

        public MDIBackEnd()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create object based on frmCustomerView
            frmCustomerView customerList = new frmCustomerView();
            //make the object a child of mdi parent
            customerList.MdiParent = this;
            //make the form visible
            customerList.Visible = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create object based on frmAddCustomer
            frmAddCustomer addCustomer = new frmAddCustomer(0);
            //make the object a child of mdi parent
            addCustomer.MdiParent = this;
            //make the form visible
            addCustomer.Visible = true;
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //create object based on frmAddArtist
            frmAddArtist addArtist = new frmAddArtist();
            //make the object a child of mdi parent 
            addArtist.MdiParent = this;
            //make the form visible
            addArtist.Visible = true;
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //create object based on frmAddArtist
            frmArtistView artistList = new frmArtistView();
            //make the object a child of mdi parent 
            artistList.MdiParent = this;
            //make the form visible
            artistList.Visible = true;
        }
    }
}
