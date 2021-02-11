using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
