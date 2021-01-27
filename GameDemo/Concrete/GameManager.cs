using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class GameManager
    {
        public void SellGame(Game game, Player player, GameCampaign gameCampaign)
        {
            Console.WriteLine("Game: " + game.GameName + "\nPrice: " + game.GamePrice
            + "\nPlayer: " + player.FirstName +
            "\nCampaing Name : " + gameCampaign.Name +
            "\nDiscounted price: " +(game.GamePrice - (game.GamePrice * gameCampaign.Discount) / 100));
        }
    }
}
