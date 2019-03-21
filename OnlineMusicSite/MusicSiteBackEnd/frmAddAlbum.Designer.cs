namespace MusicSiteBackEnd
{
    partial class frmAddAlbum
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAlbumID = new System.Windows.Forms.TextBox();
            this.lblAlbumID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(270, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtAlbumID
            // 
            this.txtAlbumID.Location = new System.Drawing.Point(260, 48);
            this.txtAlbumID.Name = "txtAlbumID";
            this.txtAlbumID.Size = new System.Drawing.Size(100, 22);
            this.txtAlbumID.TabIndex = 2;
            // 
            // lblAlbumID
            // 
            this.lblAlbumID.AutoSize = true;
            this.lblAlbumID.Location = new System.Drawing.Point(185, 51);
            this.lblAlbumID.Name = "lblAlbumID";
            this.lblAlbumID.Size = new System.Drawing.Size(64, 17);
            this.lblAlbumID.TabIndex = 3;
            this.lblAlbumID.Text = "Album ID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(185, 182);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(260, 179);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(155, 141);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(94, 17);
            this.lblReleaseDate.TabIndex = 7;
            this.lblReleaseDate.Text = "Release Date";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Location = new System.Drawing.Point(260, 136);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(100, 22);
            this.txtReleaseDate.TabIndex = 6;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(161, 97);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(88, 17);
            this.lblAlbumName.TabIndex = 9;
            this.lblAlbumName.Text = "Album Name";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(260, 94);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(100, 22);
            this.txtAlbumName.TabIndex = 8;
            // 
            // frmAddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 397);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblAlbumID);
            this.Controls.Add(this.txtAlbumID);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddAlbum";
            this.Text = "frmAddAlbum";
            this.Load += new System.EventHandler(this.frmAddAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAlbumID;
        private System.Windows.Forms.Label lblAlbumID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.TextBox txtAlbumName;
    }
}