namespace MusicSiteBackEnd
{
    partial class FrmAddSong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSongID = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblSongArtist = new System.Windows.Forms.Label();
            this.lblSongGenre = new System.Windows.Forms.Label();
            this.lblSongAlbum = new System.Windows.Forms.Label();
            this.txtSongID = new System.Windows.Forms.TextBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtSongArtist = new System.Windows.Forms.TextBox();
            this.txtSongAlbum = new System.Windows.Forms.TextBox();
            this.txtSongGenre = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSongID
            // 
            this.lblSongID.AutoSize = true;
            this.lblSongID.Location = new System.Drawing.Point(86, 53);
            this.lblSongID.Name = "lblSongID";
            this.lblSongID.Size = new System.Drawing.Size(55, 13);
            this.lblSongID.TabIndex = 0;
            this.lblSongID.Text = "Song ID : ";
            this.lblSongID.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Location = new System.Drawing.Point(68, 86);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(69, 13);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "Song Name :";
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.Location = new System.Drawing.Point(74, 122);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(67, 13);
            this.lblSongArtist.TabIndex = 2;
            this.lblSongArtist.Text = "Song Artist : ";
            // 
            // lblSongGenre
            // 
            this.lblSongGenre.AutoSize = true;
            this.lblSongGenre.Location = new System.Drawing.Point(68, 191);
            this.lblSongGenre.Name = "lblSongGenre";
            this.lblSongGenre.Size = new System.Drawing.Size(73, 13);
            this.lblSongGenre.TabIndex = 3;
            this.lblSongGenre.Text = "Song Genre : ";
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.AutoSize = true;
            this.lblSongAlbum.Location = new System.Drawing.Point(68, 155);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.Size = new System.Drawing.Size(73, 13);
            this.lblSongAlbum.TabIndex = 4;
            this.lblSongAlbum.Text = "Song Album : ";
            // 
            // txtSongID
            // 
            this.txtSongID.Location = new System.Drawing.Point(148, 53);
            this.txtSongID.Name = "txtSongID";
            this.txtSongID.Size = new System.Drawing.Size(77, 20);
            this.txtSongID.TabIndex = 5;
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(148, 86);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(209, 20);
            this.txtSongName.TabIndex = 6;
            // 
            // txtSongArtist
            // 
            this.txtSongArtist.Location = new System.Drawing.Point(147, 119);
            this.txtSongArtist.Name = "txtSongArtist";
            this.txtSongArtist.Size = new System.Drawing.Size(210, 20);
            this.txtSongArtist.TabIndex = 7;
            // 
            // txtSongAlbum
            // 
            this.txtSongAlbum.Location = new System.Drawing.Point(147, 152);
            this.txtSongAlbum.Name = "txtSongAlbum";
            this.txtSongAlbum.Size = new System.Drawing.Size(210, 20);
            this.txtSongAlbum.TabIndex = 8;
            // 
            // txtSongGenre
            // 
            this.txtSongGenre.Location = new System.Drawing.Point(147, 188);
            this.txtSongGenre.Name = "txtSongGenre";
            this.txtSongGenre.Size = new System.Drawing.Size(210, 20);
            this.txtSongGenre.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(339, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(267, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;

            // 
            // FrmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 286);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtSongGenre);
            this.Controls.Add(this.txtSongAlbum);
            this.Controls.Add(this.txtSongArtist);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.txtSongID);
            this.Controls.Add(this.lblSongAlbum);
            this.Controls.Add(this.lblSongGenre);
            this.Controls.Add(this.lblSongArtist);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.lblSongID);
            this.Name = "FrmAddSong";
            this.Text = "FrmAddSong";
            this.Load += new System.EventHandler(this.FrmAddSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongID;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblSongArtist;
        private System.Windows.Forms.Label lblSongGenre;
        private System.Windows.Forms.Label lblSongAlbum;
        private System.Windows.Forms.TextBox txtSongID;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.TextBox txtSongArtist;
        private System.Windows.Forms.TextBox txtSongAlbum;
        private System.Windows.Forms.TextBox txtSongGenre;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}