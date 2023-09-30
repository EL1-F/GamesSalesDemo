using GamesSalesDemo.Abstract;
using GamesSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesDemo.Concrete
{
    internal class MemberManager : IMemberService
    {
        IValidateService _validateService;

        public MemberManager(IValidateService validateService)
        {
            _validateService = validateService;
        }
        public void Add(Member member)
        {
            Console.WriteLine(member.Name+ ", kayıt oldunuz.");
        }

        public void Delete(Member member)
        {
            Console.WriteLine(member.Name + ", hesabınızı sildiniz.");
        }

        public void Update(Member member)
        {
            Console.WriteLine(member.Name + ", bilgileriniz güncellendi.");
        }
    }
}
