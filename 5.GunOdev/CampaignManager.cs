using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Tebrikler . "+campaign.CampaignName + " adlı kampanya ile " + "%" + campaign.DiscountRate + " indirim kazandınız.");
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
