using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class GameCampaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}
