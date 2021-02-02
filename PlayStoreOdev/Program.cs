using System;
using System.Collections.Generic;

namespace PlayStoreOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Cenk", LastName = "Tosun", Tc = "45568713235", DateOfBirth = "12.05.1997" };

            Customer customer2 = new Customer { Id = 2, FirstName = "Kara", LastName = "Yılmaz", Tc = "97532552067", DateOfBirth = "25.11.2005" };

            Customer customer3 = new Customer { Id = 3, FirstName = "Engin", LastName = "Erdem", Tc = "85463202088", DateOfBirth = "01.07.2000" };



            Campaign campaign1 = new Campaign { CampaignId = 101, CampaignName = "BlackFriday kampanyası", CampaignDiscount = 25 };

            Campaign campaign2 = new Campaign { CampaignId = 102, CampaignName = "Yılbaşı kampanyası", CampaignDiscount = 50 };


            
            Game game1 = new Game { GameId = 111, GameName = "Minecraft for Windows of Master", GamePrice = 100 };

            Game game2 = new Game { GameId = 222, GameName = "Grand Theft Auto San Andreas", GamePrice = 300 };

            Game game3 = new Game { GameId = 333, GameName = "Amoung Us", GamePrice = 50 };

            Game game4 = new Game { GameId = 444, GameName = "Forza Horizon 4 Ultimate", GamePrice = 280 };

            Game game5 = new Game { GameId = 555, GameName = "Football Manager 2021", GamePrice = 150 };

            CustomerManager customerManager = new CustomerManager();
            AccountVerification accountVerification = new AccountVerification();

            customerManager.Add(customer1, accountVerification);
            customerManager.Add(customer2, accountVerification);
            customerManager.Add(customer3, accountVerification);


            List<Game> games = new List<Game> {game1,game2,game3,game4,game5 };
            Console.WriteLine("********* Oyun Listesi *********\n");
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine("--- " + i + ".Oyun bilgisi ---\n");
                Console.WriteLine("Oyun Id: " +game.GameId);
                Console.WriteLine("Oyun İsmi: " + game.GameName);
                Console.WriteLine("Oyun Fiyatı: " + game.GamePrice + " TL\n\n");
                i++;
            }


            List<Campaign> campains = new List<Campaign> { campaign1, campaign2 };
            i = 1;
            Console.WriteLine("********* Kampanya Listesi *********\n");
            foreach (var campaign in campains)
            {
                Console.WriteLine("--- " + i + ".Kampanya bilgisi ---\n");
                Console.WriteLine("Kampanya ismi: " + campaign.CampaignName);
                Console.WriteLine("Kampanya indirimi: " + campaign.CampaignDiscount + " %\n\n");
                i++;
            }

            SalesManagement salesManagement = new SalesManagement();

            //burada satış yönetiminden hangi oyuncunun hangi oyunu 
            //nasıl(kampanyalı yoksa kampanyasız) aldığını kontrol ediyoruz
            
            salesManagement.KampanyasızOyunSatısı(customer1, game2);

            salesManagement.KampanyalıOyunSatısı(customer2,game3,campaign2);

            salesManagement.KampanyalıOyunSatısı(customer3, game5, campaign1);
            

            Console.ReadLine();
        }
    }
}
