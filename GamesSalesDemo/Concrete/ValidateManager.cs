using GamesSalesDemo.Abstract;
using GamesSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesDemo.Concrete
{
    internal class ValidateManager : IValidateService
    {
        public bool Validate(Member member)
        {
            return true;
        }
    }
}
