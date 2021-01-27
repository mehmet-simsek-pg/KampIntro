using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface ICampaingService
    {
        void Save(GameCampaign campaign);
        void Update(GameCampaign campaign);
        void Delete(GameCampaign campaign);
    }
}
