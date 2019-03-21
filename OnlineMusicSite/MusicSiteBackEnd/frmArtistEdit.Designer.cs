namespace MusicSiteBackEnd
{
    partial class frmArtistEdit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(246, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Artist Name";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(13, 80);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(62, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Artist Genre";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(13, 109);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(48, 13);
            this.lblBio.TabIndex = 4;
            this.lblBio.Text = "Artist Bio";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(80, 47);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(165, 20);
            this.txtArtistName.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(80, 77);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(165, 20);
            this.txtGenre.TabIndex = 6;
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(80, 106);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(165, 64);
            this.txtBio.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(246, 231);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "[lblError]";
            // 
            // frmArtistEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 299);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmArtistEdit";
            this.Text = "frmArtistEdit";
            this.Load += new System.EventHandler(this.frmArtistEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label lblError;
    }
}