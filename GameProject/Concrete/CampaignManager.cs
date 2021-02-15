using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi: " + campaign.CampaignName + " İndirim oranı: " + campaign.DiscountRate+ '\n');
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "süresi dolduğu için kampanya silindi." + '\n');
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi: " + campaign.CampaignName + " İndirim oranı: " + campaign.DiscountRate);
        }
    }
}
