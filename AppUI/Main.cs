using System;


using System.Windows.Forms;

namespace FrozenCode.Community.AppUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblBackgroundTitle.Text = AppUI.Helper.AppHelper.GetCommunityName();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberList listForm = new frmMemberList();
            // Set the Parent Form of the Child window.
            listForm.MdiParent = this;
            // Display the new form.
            listForm.Show();

            this.PerformCommonSettingForChildDisplay();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberEntry memberForm = new MemberEntry();
            // Set the Parent Form of the Child window.
            memberForm.MdiParent = this;
            // Display the new form.
            memberForm.Show();
            
            this.PerformCommonSettingForChildDisplay();
        }

        private void PerformCommonSettingForChildDisplay()
        {
            lblBackgroundTitle.Visible = false;
        }

        

        private void Main_Deactivate(object sender, EventArgs e)
        {
            lblBackgroundTitle.Visible = false;
        }

        private void Main_Enter(object sender, EventArgs e)
        {
            lblBackgroundTitle.Visible = true;
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackUp wndBackUp = new frmBackUp();
            wndBackUp.MdiParent = this;
            wndBackUp.Show();
        }
    }
}
