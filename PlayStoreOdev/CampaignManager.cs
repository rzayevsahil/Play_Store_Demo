using System;
using System.Collections.Generic;
using System.Text;

namespace PlayStoreOdev
{
    class CampaignManager
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sisteme ***" + campaign.CampaignName + "*** kampanyası eklendi\n");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sistemden ***" + campaign.CampaignName + "*** kampanyası silindi\n");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Sistemde ***" + campaign.CampaignName + "*** kampanyası güncellendi\n");
        }

        
    }
}
