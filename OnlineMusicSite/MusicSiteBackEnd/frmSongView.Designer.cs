namespace MusicSiteBackEnd
{
    partial class frmSongView
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
            this.lblSongSearch = new System.Windows.Forms.Label();
            this.txtSongSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSongSearch
            // 
            this.lblSongSearch.AutoSize = true;
            this.lblSongSearch.Location = new System.Drawing.Point(41, 60);
            this.lblSongSearch.Name = "lblSongSearch";
            this.lblSongSearch.Size = new System.Drawing.Size(78, 13);
            this.lblSongSearch.TabIndex = 0;
            this.lblSongSearch.Text = "Song Search : ";
            // 
            // txtSongSearch
            // 
            this.txtSongSearch.Location = new System.Drawing.Point(44, 86);
            this.txtSongSearch.Name = "txtSongSearch";
            this.txtSongSearch.Size = new System.Drawing.Size(286, 20);
            this.txtSongSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(337, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(46, 122);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(384, 160);
            this.listBox.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(337, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(238, 289);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(93, 23);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(139, 289);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(44, 289);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(93, 23);
            this.btnPopulate.TabIndex = 11;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 393);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSongSearch);
            this.Controls.Add(this.lblSongSearch);
            this.Name = "frmSongView";
            this.Text = "frmSongView";
            this.Load += new System.EventHandler(this.frmSongView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongSearch;
        private System.Windows.Forms.TextBox txtSongSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnCancel;
    }
}