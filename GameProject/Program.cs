using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager1 = new GamerManager(new GamerCheckManager());
            //gamerManager1.Register(new Gamer { FirstName = "Lady", LastName = "Gaga", NationalityNumber = "123456789012" });
            GameSaleManager saleManager = new GameSaleManager();

           // saleManager.Sales(new Game {Name="Counter-Strike",Price=30 },new Gamer {FirstName="Salem",LastName="Ursula" });
            saleManager.CampaignSales(new Game { Name = "The Witcher",Price=200 }, 
                                      new Gamer {FirstName= "Britney",LastName= "Spears" },
                                      new Campaign {CampName="Black Friday",NewPrice=103 });

        }
    }
}
