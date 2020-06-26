using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenCode.Community.DTO
{
    public class MemberSearchDTO
    {
        public short Id { get; set; }
        public string MemberId { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
       
        
       

    }
}
