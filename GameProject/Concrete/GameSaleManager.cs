using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        // Satışlarda kampanya entegrasyonunu simule ediniz.
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.Name + " " + gamer.FirstName + " " + gamer.LastName + " " + "tarafından "+ (game.Price - campaign.NewPrice) + " TL indirimli satın alındı.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name + " "+ gamer.FirstName + " " + gamer.LastName +" " + "tarafından satın alındı.");
        }
    }
}
