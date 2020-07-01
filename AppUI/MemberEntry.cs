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
          
            //HideErrorMessages();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var memberDto = GetMemberUIData();

            string message = string.Empty;
            if (memberSrevice.TrySaveMember(ref memberDto, out message))
            {
                message = "Record Saved Successfully!";
                DisplayMessage.ShowSuccessMessage(message, DisplayMessage.SAVE_TITLE);
                //this.btnClear.Click();
                ClearMemberEntryData();
            }
            else
            {
                if(string.IsNullOrWhiteSpace( message))
                    message = "There is Error while saving the record, Record not saved!";
                DisplayMessage.ShowErrorMessage(message, DisplayMessage.ERROR_TITLE);
            }
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
            ClearMemberEntryData();
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

        private bool ValidatMemberEntry(MemberDTO memberDTO)
        {
            if (string.IsNullOrWhiteSpace(memberDTO.FullName))
            {

            }

            return true;
        
        }

        private void ValidateUI()
        {
            if (this.lblErrorFullName.Visible || this.lblErrorFatherName.Visible
                 || this.lblErrorAddress.Visible || this.lblErrorMemberID.Visible
                 || this.lblErrorMobile.Visible)
            {
                this.btnSave.Enabled = false;
            }
            else
            {
                this.btnSave.Enabled = true;
            }            
        }



        private void ClearMemberEntryData()
        {

            this.maskedTextBoxMemberId.Text = string.Empty;
            this.txtFullName.Text = string.Empty;
            this.txtFatherName.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.maskedTextBoxMemberId.Text = string.Empty;
            this.maskedTextBoxmobilenumber.Text = string.Empty;
            this.dtDOB.Value = DateTime.Now.AddYears(-20);
            this.dtMaarriage.Value = DateTime.Now.AddYears(-10);
            this.txtQualification.Text = string.Empty;
            //this.pbMember.Image. = DEFAULT_PROFILE_PIC;

        }
        #endregion
        
        private void MemberEntry_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void maskedTextBoxMemberId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.maskedTextBoxMemberId.Text.Trim()))
            {
                this.lblErrorMemberID.Visible = true;
            }
            else
                this.lblErrorMemberID.Visible = false;

            ValidateUI();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtFullName.Text.Trim()))
            {
                this.lblErrorFullName.Visible = true;
                this.txtFullName.Text = this.txtFullName.Text.Trim();
            }
            else
                this.lblErrorFullName.Visible = false;

            ValidateUI();
        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtFatherName.Text.Trim()))
            {
                this.lblErrorFatherName.Visible = true;
                this.txtFatherName.Text = this.txtFatherName.Text.Trim();
            }
            else
                this.lblErrorFatherName.Visible = false;

            ValidateUI();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAddress.Text.Trim()))
            {
                this.lblErrorAddress.Visible = true;
                this.txtAddress.Text = this.txtAddress.Text.Trim();
            }
            else
                this.lblErrorAddress.Visible = false;
            ValidateUI();
        }

        private void maskedTextBoxmobilenumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.maskedTextBoxmobilenumber.Text.Trim()))
            {
                this.lblErrorMobile.Visible = true;
            }
            else
                this.lblErrorMobile.Visible = false;

            ValidateUI();
        }

        private void MemberEntry_Load(object sender, EventArgs e)
        {
            ValidateUI();
        }
    }
}
