using FrozenCode.Community.AppUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrozenCode.Community.AppUI
{
    public partial class frmBackUp : Form
    {
        public string Data { get; private set; }

        public frmBackUp()
        {
            InitializeComponent();
        }

        private void btnBrowseBackUpFolder_Click(object sender, EventArgs e)
        {
           if (fbdBackup.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = fbdBackup.SelectedPath;
            }
        }

        private void fbdBackup_HelpRequest(object sender, EventArgs e)
        {

        }

        private void frmBackUp_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
           string strSelectedPath = txtBackupPath.Text.Trim(), sourceFileWithPath = string.Empty;
           if (string.IsNullOrWhiteSpace(strSelectedPath))
            {
                string message = "Please seleect a folder";
                DisplayMessage.ShowErrorMessage(message, DisplayMessage.ERROR_TITLE);

                return; 
           }

            sourceFileWithPath = AppHelper.GetDatabaseFileWithPath();


            if (System.IO.File.Exists(sourceFileWithPath))
            {
                //System.IO.File.Copy(sourceFileWithPath, Path.Combine(strSelectedPath, AppHelper.GetBackupFileName()), true);

                AppHelper.ExecuteCommand("COPY " + sourceFileWithPath + " " + strSelectedPath,3000);
                string message = "Backup has been successfully taken!";
                DisplayMessage.ShowSuccessMessage(message, DisplayMessage.DONE_TITLE);

                this.Dispose();
                this.Close();
            }
            else
            {
                string message = "File does not exist!";
                DisplayMessage.ShowErrorMessage(message, DisplayMessage.ERROR_TITLE);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
 