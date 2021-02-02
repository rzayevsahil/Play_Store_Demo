using System;
using System.Collections.Generic;
using System.Text;

namespace PlayStoreOdev
{
    class SalesManagement
    {
        public void KampanyasızOyunSatısı(Customer customer, Game game)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("***" + game.GameName + "***  oyunu  *" + customer.FirstName + " "
                + customer.LastName + "*  isimli kullanıcı tarafından başarıyla satın alındı!\n");
        }
        int id;
        public void KampanyalıOyunSatısı(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("-------------------------------------------------------");
            game.GamePrice = game.GamePrice * campaign.CampaignDiscount / 100;
            Console.WriteLine(game.GameName + " oyunu " + campaign.CampaignName + " kampanyası kullanılarak *" + customer.FirstName + " "
                + customer.LastName + "* isimli kullanıcı tarafından başarıyla satın alındı!");
            Console.WriteLine(campaign.CampaignName +
                " isimli kampanyayı kullandığı için oyun fiyatına " + campaign.CampaignDiscount + "% indirim yapıldı");
            Console.WriteLine("Oyunun yeni fiyatı : " + game.GamePrice + " TL\n");

        }
    }
}
