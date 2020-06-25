using FrozenCode.Community.DTO;
using System;

namespace FrozenCode.Community.Contract
{
    public interface IMemberService : IBaseService
    {

        bool TrySaveMember(ref MemberDTO memberDto);
    }
}
