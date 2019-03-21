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
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblArtistGenre = new System.Windows.Forms.Label();
            this.lblArtistBio = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(86, 56);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(108, 20);
            this.txtArtistName.TabIndex = 0;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(86, 99);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(108, 20);
            this.txtGenre.TabIndex = 1;
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(86, 145);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(108, 48);
            this.txtBio.TabIndex = 2;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(16, 58);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(61, 13);
            this.lblArtistName.TabIndex = 3;
            this.lblArtistName.Text = "Artist Name";
            // 
            // lblArtistGenre
            // 
            this.lblArtistGenre.AutoSize = true;
            this.lblArtistGenre.Location = new System.Drawing.Point(16, 103);
            this.lblArtistGenre.Name = "lblArtistGenre";
            this.lblArtistGenre.Size = new System.Drawing.Size(59, 13);
            this.lblArtistGenre.TabIndex = 4;
            this.lblArtistGenre.Text = "ArtistGenre";
            // 
            // lblArtistBio
            // 
            this.lblArtistBio.AutoSize = true;
            this.lblArtistBio.Location = new System.Drawing.Point(20, 145);
            this.lblArtistBio.Name = "lblArtistBio";
            this.lblArtistBio.Size = new System.Drawing.Size(48, 13);
            this.lblArtistBio.TabIndex = 5;
            this.lblArtistBio.Text = "Artist Bio";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(282, 264);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(19, 264);
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
            this.lblError.Location = new System.Drawing.Point(282, 231);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "[lblError]";
            // 
            // frmArtistEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 299);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblArtistBio);
            this.Controls.Add(this.lblArtistGenre);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtistName);
            this.Name = "frmArtistEdit";
            this.Text = "frmArtistEdit";
            this.Load += new System.EventHandler(this.frmArtistEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label lblArtistGenre;
        private System.Windows.Forms.Label lblArtistBio;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblError;
    }
}