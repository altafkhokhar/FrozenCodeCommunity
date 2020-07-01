namespace FrozenCode.Community.AppUI
{
    partial class frmBackUp
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
            this.lblBackUpFolderPath = new System.Windows.Forms.Label();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowseBackUpFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackUpFolderPath
            // 
            this.lblBackUpFolderPath.AutoSize = true;
            this.lblBackUpFolderPath.Location = new System.Drawing.Point(40, 50);
            this.lblBackUpFolderPath.Name = "lblBackUpFolderPath";
            this.lblBackUpFolderPath.Size = new System.Drawing.Size(104, 13);
            this.lblBackUpFolderPath.TabIndex = 0;
            this.lblBackUpFolderPath.Text = "Select BackUp Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBrowseBackUpFolder);
            this.panel1.Controls.Add(this.lblBackUpFolderPath);
            this.panel1.Location = new System.Drawing.Point(67, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 137);
            this.panel1.TabIndex = 1;
            // 
            // btnBrowseBackUpFolder
            // 
            this.btnBrowseBackUpFolder.Location = new System.Drawing.Point(265, 50);
            this.btnBrowseBackUpFolder.Name = "btnBrowseBackUpFolder";
            this.btnBrowseBackUpFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseBackUpFolder.TabIndex = 1;
            this.btnBrowseBackUpFolder.Text = "Browser";
            this.btnBrowseBackUpFolder.UseVisualStyleBackColor = true;
            this.btnBrowseBackUpFolder.Click += new System.EventHandler(this.btnBrowseBackUpFolder_Click);
            // 
            // frmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(581, 281);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmBackUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BACKUP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBackUpFolderPath;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowseBackUpFolder;
    }
}