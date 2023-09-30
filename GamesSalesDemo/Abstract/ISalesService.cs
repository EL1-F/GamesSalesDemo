using GamesSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesDemo.Abstract
{
    internal interface ISalesService
    {
        void Sell(Member member, Game game);
        void Sell(Member member, Game game,Campaign campaign);

    }
}
