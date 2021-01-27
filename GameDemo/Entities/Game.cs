using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }

    }
}
