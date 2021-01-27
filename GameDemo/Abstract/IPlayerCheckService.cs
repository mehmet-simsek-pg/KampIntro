using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckPlayer(Player player);
    }
}
