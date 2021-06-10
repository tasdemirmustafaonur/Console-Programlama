using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public static class MemberManager
    {
        public static List<Member> Members;

        static MemberManager()
        {
            Members = DefaultMembers();
        }

        public static List<Member> DefaultMembers()
        {
            return new List<Member>(){
            new Member(1,"Yağız Ünal"),
            new Member(2,"Özgür Taşdemir"),
            new Member(3,"Fatih Taşdemir"),
            new Member(4,"Mustafa Taşdemir"),
            new Member(5,"OKtay Ağca"),
            };
        }
    }
}