using GamesSalesDemo.Abstract;
using GamesSalesDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesSalesDemo.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Sell(Member member, Game game)
        {
            Console.WriteLine(member.UserName+" adlı üye "+game.GameName+" oyununu satın aldı.");
        }

        public void Sell(Member member, Game game, Campaign campaign)
        {
            Console.WriteLine(member.UserName + " adlı üye " + game.GameName + " oyununu % "+campaign.DiscountRate +" indirimli satın aldı.");
        }
    }
}
