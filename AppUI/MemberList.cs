using FrozenCode.Community.Contract;
using FrozenCode.Community.DTO;
using FrozenCode.Community.Service;
using System;
using System.Collections.Generic;


namespace FrozenCode.Community.AppUI
{
    public partial class frmMemberList : BaseChildForm
    {
        private IMemberService memberSrevice;
        public frmMemberList()
        {
            InitializeComponent();

            memberSrevice = new MemberService();

            btnSearch.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var searchKeyword = txtSearchKeyWord.Text.Trim();
            var result =  memberSrevice.SearchMembers(searchKeyword);

            bindGridByData(result);
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            var result = memberSrevice.GetAll();
            bindGridByData(result);

        }

        private void bindGridByData(IEnumerable<MemberSearchDTO> resultData)
        {
            dgMembers.DataSource = resultData;
            this.dgMembers.Columns["Id"].Visible = false;

            dgMembers.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.MdiParent.Controls["lblBackgroundTitle"].Visible = true;
            this.Dispose();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtSearchKeyWord.Text = string.Empty;

            if (this.dgMembers.Rows != null && this.dgMembers.Rows.Count > 0)
            {
                this.dgMembers.DataSource = null;
                this.dgMembers.Rows.Clear();
            }
        }

        private void txtSearchKeyWord_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchKeyWord.Text.Trim() == string.Empty)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }

        private void frmMemberList_Load(object sender, EventArgs e)
        {
            this.dgMembers.ReadOnly = true;
        }
    }
}
