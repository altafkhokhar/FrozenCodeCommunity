using FrozenCode.Community.DTO;
using System;
using System.Collections.Generic;

namespace FrozenCode.Community.Contract
{
    public interface IMemberService : IBaseService
    {

        bool TrySaveMember(ref MemberDTO memberDto, out string message );

        IEnumerable<MemberSearchDTO> GetAll();
        IEnumerable<MemberSearchDTO> SearchMembers(string searchString);
    }
}
