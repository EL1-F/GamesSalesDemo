using GamesSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesDemo.Abstract
{
    internal interface IValidateService
    {
        bool Validate(Member member);
    }
}
