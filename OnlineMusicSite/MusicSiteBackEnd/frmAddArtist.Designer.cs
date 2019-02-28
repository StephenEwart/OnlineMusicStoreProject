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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblArtistGenre = new System.Windows.Forms.Label();
            this.lblArtistBio = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(239, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 271);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblArtistBio);
            this.Controls.Add(this.lblArtistGenre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblArtistName);
            this.Name = "frmAddArtist";
            this.Text = "frmAddArtist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblArtistGenre;
        private System.Windows.Forms.Label lblArtistBio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}