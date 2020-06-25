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
            lblBackgroundTitle.Text = "";// AppUI.Helper.AppHelper.GetCommunityName();

           

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberEntry memberForm = new MemberEntry();
            // Set the Parent Form of the Child window.
            memberForm.MdiParent = this;
            // Display the new form.
            memberForm.Show();
        }
    }
}
