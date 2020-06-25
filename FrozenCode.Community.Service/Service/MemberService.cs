
using FrozenCode.Community.Contract;
using FrozenCode.Community.DTO;

using System;

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
                communityMember.Mobile = memberDto.Mobile;

                communityMember.DOB = memberDto.Dob;
                communityMember.Address = memberDto.Address;
                communityMember.EducationQualification = memberDto.EducationQualification;
                communityMember.ImageLocation = memberDto.ImageLocation;
                communityMember.MarriageDate = memberDto.MarriageDate;
                communityMember.CreatedDate = DateTime.Now;

                communityMember.MemberID = memberDto.MemberId;

                context.Members.Add(communityMember);
                 var result = context.SaveChanges();
            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
