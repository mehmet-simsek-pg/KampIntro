using System;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                Id = 1,
                FirstName = "afsimsek",
                LastName = "thunder",
                BirthDate = new DateTime(1939, 03, 28),
                NationalityId = "56526258422"

            };

            Player player2 = new Player()
            {
                Id = 1,
                FirstName = "esat",
                LastName = "thunder",
                BirthDate = new DateTime(1999, 05, 13),
                NationalityId = "590085095402"
            };

            Player player3 = new Player()
            {
                Id = 1,
                FirstName = "heysem",
                LastName = "redSon",
                BirthDate = new DateTime(2009, 07, 18),
                NationalityId = "1998408940"
            };

          




            PlayerManager playerManager = new PlayerManager(new PlayerCheckService());
            

            GameCampaign gameCampaign = new GameCampaign(){Id = 1, Name = "Grand Campaign", Discount = 25};
            Game game = new Game(){Id = 1, GameName = "Cties Skylines", GamePrice = 50};

            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();

            gameManager.SellGame(game, player1, gameCampaign);

        }
    }
}
