using FrozenCode.Community.AppUI.Helper;
using FrozenCode.Community.Contract;
using FrozenCode.Community.DTO;
using FrozenCode.Community.Service;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FrozenCode.Community.AppUI
{
    public partial class MemberEntry : BaseChildForm
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
            
            DialogResult dres1 = opnfd.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
           
            pbMember.Image = Image.FromFile(opnfd.FileName);
           }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.MdiParent.Controls["lblBackgroundTitle"].Visible = true;
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

            memberDto.MemberId = maskedTextBoxMemberId.Text.Trim();
            memberDto.FullName = txtFullName.Text.Trim();
            memberDto.FatherName = txtFatherName.Text.Trim();
            memberDto.Address = txtAddress.Text.Trim();

            memberDto.Mobile = maskedTextBoxmobilenumber.Text.Trim();

            memberDto.Dob = dtDOB.Value;
            memberDto.MarriageDate = dtMaarriage.Value;
            memberDto.EducationQualification = txtQualification.Text.Trim();
            
            if (pbMember.Image != null)
            {
                //MemoryStream ms1 = new MemoryStream();
                //pbMember.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                //pbMember.Image.Save(appPath + @"\" + filename + ".jpg", ImageFormat.Jpeg);

                var memberImageName = AppHelper.GetMemberImageFullPathToSave() + memberDto.MemberId + "_" + memberDto.FullName + AppHelper.GetMemberImageExtensionForSave();
                pbMember.Image.Save(memberImageName, ImageFormat.Jpeg);
                memberDto.ImageLocation = memberDto.MemberId + "_" + memberDto.FullName + AppHelper.GetMemberImageExtensionForSave();
            }
            return memberDto;
        }

        #endregion

        private void MemberEntry_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
