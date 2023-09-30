using GamesSalesDemo.Concrete;
using GamesSalesDemo.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        MemberManager memberManager = new MemberManager(new ValidateManager());
        Member player1 = new Member {Id=1,Name="Elif",Lastname="ipek",Email="123@gmail.com"
            ,UserName="elpek",IdentityNumber="11111111111",Birthday=new DateTime(1993,1,5) };

        memberManager.Add(player1);
        memberManager.Update(player1 );
        memberManager.Delete(player1);
        Console.WriteLine("*******");

        Game game1 = new Game { Id=1,GameName="Oyun1",Price=50};
        GameManager gameManager = new GameManager();
        gameManager.Add(game1);
        gameManager.Update(game1);
        gameManager.Delete(game1);
        Console.WriteLine("*******");

        Campaign campaign1 = new Campaign { Id=1,CampaignName="indirim1",DiscountRate=25};
        CampaignManager campaignManager = new CampaignManager();
        campaignManager.Add(campaign1);
        campaignManager.Update(campaign1);
        campaignManager.Delete(campaign1);
        Console.WriteLine("*******");

        SalesManager salesManager = new SalesManager();
        salesManager.Sell(player1, game1);
        salesManager.Sell(player1 , game1,campaign1);
    }
}