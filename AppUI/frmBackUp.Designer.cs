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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUp));
            this.lblBackUpFolderPath = new System.Windows.Forms.Label();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowseBackUpFolder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackUpFolderPath
            // 
            resources.ApplyResources(this.lblBackUpFolderPath, "lblBackUpFolderPath");
            this.lblBackUpFolderPath.Name = "lblBackUpFolderPath";
            // 
            // fbdBackup
            // 
            this.fbdBackup.HelpRequest += new System.EventHandler(this.fbdBackup_HelpRequest);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtBackupPath);
            this.panel1.Controls.Add(this.lblPath);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBrowseBackUpFolder);
            this.panel1.Controls.Add(this.lblBackUpFolderPath);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.txtBackupPath, "txtBackupPath");
            this.txtBackupPath.Name = "txtBackupPath";
            // 
            // lblPath
            // 
            resources.ApplyResources(this.lblPath, "lblPath");
            this.lblPath.Name = "lblPath";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowseBackUpFolder
            // 
            this.btnBrowseBackUpFolder.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.btnBrowseBackUpFolder, "btnBrowseBackUpFolder");
            this.btnBrowseBackUpFolder.Name = "btnBrowseBackUpFolder";
            this.btnBrowseBackUpFolder.UseVisualStyleBackColor = false;
            this.btnBrowseBackUpFolder.Click += new System.EventHandler(this.btnBrowseBackUpFolder_Click);
            // 
            // frmBackUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmBackUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBackUpFolderPath;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowseBackUpFolder;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtBackupPath;
    }
}