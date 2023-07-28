using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Campaign campaign, Sale sale)
        {
            int discount = campaign.DiscountRate;
            sale.Price = sale.Price * discount / 100;
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName+ " adlı kullanıcıya "
                + sale.GameName + " oyunu için " + campaign.CampaignName + " uygulanmıştır. Fiyatı " + sale.Price + " TL.");
        }
    }
}
