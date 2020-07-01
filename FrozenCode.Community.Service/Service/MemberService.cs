
using FrozenCode.Community.Contract;
using FrozenCode.Community.DTO;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FrozenCode.Community.Service
{
    public class MemberService : IMemberService
    {
        CommunityEntities context = new CommunityEntities();
        public bool TrySaveMember(ref MemberDTO memberDto, out string message)
        {
            message = string.Empty;
            try
            {
                //ValidateNewMember(memberDto);
                if (!ValidateNewMember(memberDto, out message))
                {
                    return false;

                }

                Member communityMember = new Member();

                communityMember.FullName = memberDto.FullName;
                communityMember.FatherName = memberDto.FatherName;

                communityMember.GrandFatherName = memberDto.GrandFatherName;

                communityMember.Mobile = memberDto.Mobile;

                communityMember.DOB = memberDto.Dob;
                
                communityMember.Address = memberDto.Address;
                communityMember.EducationQualification = memberDto.EducationQualification;
                if (string.IsNullOrWhiteSpace(memberDto.ImageLocation))
                    communityMember.ImageLocation = string.Empty;
                else
                    communityMember.ImageLocation = memberDto.ImageLocation;

                communityMember.GrandFatherName = string.Empty;
               
                communityMember.MarriageDate = memberDto.MarriageDate;
                communityMember.CreatedDate = DateTime.Now;
                communityMember.CreatedBy = "System";

                communityMember.MemberID = memberDto.MemberId;
                communityMember.Address = memberDto.Address;

                context.Members.Add(communityMember);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private bool ValidateNewMember(MemberDTO memberDto, out string message)
        {
            //message
            var existingMember = context.Members.Where(wh => wh.MemberID == memberDto.MemberId).FirstOrDefault();
            if (existingMember != null)
            {
                message = "MEMBERID ALREADY EXIST!";
                return false;
            }
            else
            {
                message = string.Empty;
                return true;
            }
        }

        public IEnumerable<MemberSearchDTO> GetAll()
        {

            IEnumerable<MemberSearchDTO> members = null;
            try
            {
                CommunityEntities context = new CommunityEntities();

                members = context.Members.Select(sel => new MemberSearchDTO { Id = sel.Id, MemberId = sel.MemberID, FullName = sel.FullName, Mobile = sel.Mobile, FatherName = sel.FatherName, Address = sel.Address, ImageLocation = sel.ImageLocation }).ToList();
            }
            catch (Exception ex)
            {

            }
            return members;
        }

        public IEnumerable<MemberSearchDTO> SearchMembers(string searchKeyWord)
        {
            IEnumerable<MemberSearchDTO> members = null;
            try
            {
                searchKeyWord = searchKeyWord.Trim().ToLowerInvariant();
                CommunityEntities context = new CommunityEntities();

                members = context.Members.Where(wh=> wh.FullName.Contains(searchKeyWord) || wh.FatherName.Contains(searchKeyWord) || wh.Mobile.Contains(searchKeyWord) || wh.MemberID.Contains(searchKeyWord))
                .Select(sel => new MemberSearchDTO { Id = sel.Id, MemberId = sel.MemberID, FullName = sel.FullName,
                    Address = sel.Address, FatherName = sel.FatherName, Mobile = sel.Mobile, GrandFatherName = sel.GrandFatherName}).ToList();
            }
            catch (Exception ex)
            { }

            return members;
        }
    }
}
