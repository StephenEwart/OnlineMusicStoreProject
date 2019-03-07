namespace MusicSiteBackEnd
{
    partial class frmAddArtist
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
            this.lblArtistName = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.lblArtistGenre = new System.Windows.Forms.Label();
            this.lblArtistBio = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(37, 70);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(61, 13);
            this.lblArtistName.TabIndex = 0;
            this.lblArtistName.Text = "Artist Name";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(104, 67);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(149, 20);
            this.txtArtistName.TabIndex = 1;
            // 
            // lblArtistGenre
            // 
            this.lblArtistGenre.AutoSize = true;
            this.lblArtistGenre.Location = new System.Drawing.Point(36, 106);
            this.lblArtistGenre.Name = "lblArtistGenre";
            this.lblArtistGenre.Size = new System.Drawing.Size(62, 13);
            this.lblArtistGenre.TabIndex = 2;
            this.lblArtistGenre.Text = "Artist Genre";
            // 
            // lblArtistBio
            // 
            this.lblArtistBio.AutoSize = true;
            this.lblArtistBio.Location = new System.Drawing.Point(50, 143);
            this.lblArtistBio.Name = "lblArtistBio";
            this.lblArtistBio.Size = new System.Drawing.Size(48, 13);
            this.lblArtistBio.TabIndex = 3;
            this.lblArtistBio.Text = "Artist Bio";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(104, 103);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(149, 20);
            this.txtGenre.TabIndex = 4;
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(104, 140);
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(149, 20);
            this.txtBio.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(239, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(236, 284);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "[lblError]";
            // 
            // frmAddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 319);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblArtistBio);
            this.Controls.Add(this.lblArtistGenre);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.lblArtistName);
            this.Name = "frmAddArtist";
            this.Text = "frmAddArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label lblArtistGenre;
        private System.Windows.Forms.Label lblArtistBio;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
    }
}