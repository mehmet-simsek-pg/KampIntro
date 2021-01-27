using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class PlayerCheckService:IPlayerCheckService
    {
        public bool CheckPlayer(Player player)
        {
            return true;
        }
    }
}
