using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "FERHAT",
                LastName = "TURUÇ",
                IdentityNumber = 12345
            };


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "FERHAT",
                LastName = "TURUÇ",
                IdentityNumber = 12345
            });

            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager2.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "FERHAT",
                LastName = "TURUÇ",
                IdentityNumber = 12345
            });

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "30% indirim";
            campaign1.DiscountRate = 30;

            Sale sale1 = new Sale();
            sale1.GameName = "Diablo4";
            sale1.Price = 300;
            GamerManager customerManager1 = new GamerManager(new UserValidationManager());
            customerManager1.Add(gamer1);
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Update(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, campaign1, sale1);
        }
    }
}