using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası başladı" + campaign.CampaignDiscount + "'e varan indirimler" + campaign.CampaignDuration + "tarihleri arasında");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası sona erdi");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi." + "Kampanya süresi" + campaign.UpdateTime + " 'a uzatılmıştır.");
        }
    }
}
