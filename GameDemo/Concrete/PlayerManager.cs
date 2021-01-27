using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class PlayerManager:IPlayerService
    {
        private readonly IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Save(Player player)
        {
            if (_playerCheckService.CheckPlayer(player))
            {
                Console.WriteLine("Saved " + player.FirstName);
            }
            else
            {
                Console.WriteLine("Verification error!");
            }
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " updated.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " deleted.");
        }
    }
}
