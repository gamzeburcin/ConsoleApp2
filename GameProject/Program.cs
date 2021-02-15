using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidatinoManager());
            Gamer gamer1 = new Gamer {Id=1, BirthYear=1996, FirstName="Gamze", LastName="Aydın", IdentityNumber=12356};
            GamerManager gamerManager2 = new GamerManager(new UserValidatinoManager());
            Gamer gamer2 = new Gamer { Id = 2, BirthYear = 2004, FirstName = "Cemre", LastName = "Aydın", IdentityNumber = 12796 };
            
            Game game1 = new Game {GameId=1, GameName=" PUBG" , GamePrice=125};
            Game game2 = new Game { GameId = 2, GameName = " COUNTER STRİKE", GamePrice = 350 };
            Game game3 = new Game { GameId = 3, GameName = " NEED FOR SPEED", GamePrice = 150 };

            Campaign campaign1 = new Campaign { CampaignId=1, CampaignName=" Yeni Üye Kampanyası", DiscountRate=50 };
            Campaign campaign2 = new Campaign { CampaignId = 2, CampaignName = " Yeni Yıl Kampanyası", DiscountRate = 35 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game3, gamer1);
            salesManager.CampaignSales(game2, gamer2, campaign2);



        }
    }    

    
}
