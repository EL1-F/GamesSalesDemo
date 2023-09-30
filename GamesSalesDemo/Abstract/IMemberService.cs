using GamesSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesDemo.Abstract
{
    internal interface IMemberService
    {
        void Add(Member member);
        void Delete(Member member);
        void Update(Member member);
    }
}
