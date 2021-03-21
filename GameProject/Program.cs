using GameProject.Abstract;
using GameProject.Concrate;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseUserManager userManager = new UserManager(new MernisServiceAdapter());
            User user2 = new User();
            user2.NationalityId = "4343534652";
            user2.FirstName = "Yasin";
            user2.LastName = "Çetin";
            user2.DateOfBirth = new DateTime(2000, 10, 17);
            user2.City = "Sakarya";
            userManager.Add(user2);

            User user1 = new User();
            user1.FirstName = "Özgür";
            user1.LastName = "Özyurt";
            user1.Id = 2;
            user1.City = "İstanbul";
            user1.DateOfBirth = new DateTime(1998, 01, 12);
            user1.NationalityId = "124235436";

            userManager.Add2(user1);
            userManager.Update(user1);
            userManager.Delete(user1);
            userManager.Save(user2);

            Game game1 = new Game();
            GameManager gameManager = new GameManager();
            game1.GameId = 37;
            game1.GameName = "Tom Clancy's Rainbow Six: Siege";
            game1.GamePrice = "129.99₺";

            gameManager.AddGame(game1);

            gameManager.DeleteGame(new Game { Game.Id = 13, GameName = "Rocket League", GamePrice = "30₺" });

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Bahar";
            campaign.CampaignDiscount = "%70";
            campaign.CampaignDuration = "19-27";
            campaign.UpdateTime = "10 gün";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign);

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(user2, game1);

            campaignManager.UpdateCampaign(campaign);

            campaignManager.DeleteCampaign(campaign);





            Console.ReadLine();
        }
    }
}
