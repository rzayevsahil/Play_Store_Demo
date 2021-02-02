using System;
using System.Collections.Generic;
using System.Text;

namespace PlayStoreOdev
{
    class CampaignManager
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("Sisteme " + campaign.CampaignName + " kampanyası eklendi");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Sistemden " + campaign.CampaignName + " kampanyası silindi");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("Sistemde " + campaign.CampaignName + " kampanyası güncellendi");
        }
       
    }
}
