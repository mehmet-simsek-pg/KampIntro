using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class CampaignManager:ICampaingService
    {
     
        public void Save(GameCampaign campaign)
        {
            Console.WriteLine("Campaign Saved: " + campaign.Name);
        }

        public void Update(GameCampaign campaign)
        {
            Console.WriteLine("Campaign Updated: " + campaign.Name);
        }

        public void Delete(GameCampaign campaign)
        {
            Console.WriteLine("Campaign Deleted: " + campaign.Name);
        }
    }
}
