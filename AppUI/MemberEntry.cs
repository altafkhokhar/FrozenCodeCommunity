using FrozenCode.Community.AppUI.Helper;
using FrozenCode.Community.Contract;
using FrozenCode.Community.DTO;
using FrozenCode.Community.Service;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FrozenCode.Community.AppUI
{
    public partial class MemberEntry : Form
    {

        private IMemberService memberSrevice;

        public MemberEntry()
        {
            InitializeComponent();

            memberSrevice  = new MemberService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var memberDto = GetMemberUIData();
            memberSrevice.TrySaveMember(ref memberDto);
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbMember.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFullName.Text = string.Empty;
        }

        #region PRVATE METHODS

        private MemberDTO GetMemberUIData()
        {
            MemberDTO memberDto = new MemberDTO();

            memberDto.MemberId = txtMemberID.Text.Trim();
            memberDto.FullName = txtFullName.Text.Trim();
            memberDto.FatherName = txtFatherName.Text.Trim();
            memberDto.Address = txtAddress.Text.Trim();

            memberDto.Mobile = txtMobile.Text.Trim();

            memberDto.Dob = dtDOB.Value;
            memberDto.MarriageDate = dtMaarriage.Value;

            if (pbMember.Image != null)
            {
                memberDto.EducationQualification = txtQualification.Text.Trim();
                var memberImageName = AppHelper.GetMemberImageFullPathToSave() + memberDto.MemberId + "_" + memberDto.FullName + AppHelper.GetMemberImageExtensionForSave();
                pbMember.Image.Save(memberImageName);
                memberDto.ImageLocation = memberImageName;
            }
            return memberDto;
        }
        #endregion
    }
}
