using System;

namespace FrozenCode.Community.DTO
{
    public class MemberDTO 
    {
        public short Id { get; set; }

        public string MemberId { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? MarriageDate { get; set; }
        public string EducationQualification { get; set; }
        
        public string ImageLocation { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdaatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
