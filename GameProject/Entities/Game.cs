using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GamePrice { get; set; }
    }
}
