
using FrozenCode.Community.Contract;
using FrozenCode.Community.DTO;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FrozenCode.Community.Service
{
    public class MemberService : IMemberService
    {
        public bool TrySaveMember(ref MemberDTO memberDto)
        {
            try
            {

                CommunityEntities context = new CommunityEntities();

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

                memberDto.GrandFatherName = string.Empty;
               
                communityMember.MarriageDate = memberDto.MarriageDate;
                communityMember.CreatedDate = DateTime.Now;
                communityMember.CreatedBy = "System";

                communityMember.MemberID = memberDto.MemberId;

                context.Members.Add(communityMember);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<MemberSearchDTO> GetAll()
        {

            IEnumerable<MemberSearchDTO> members = null;
            try
            {
                CommunityEntities context = new CommunityEntities();

                members = context.Members.Select(sel => new MemberSearchDTO { Id = sel.Id, MemberId = sel.MemberID, FullName = sel.FullName, Mobile = sel.Mobile, FatherName = sel.FatherName   }).ToList();
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
