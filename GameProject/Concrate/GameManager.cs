using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Oyun" + game.GameName + " mağazaya eklendi");
        }

        public void DeleteGame(Game game)
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Oyun" + game.GameName + " mağazadan kaldırıldı");
        }
    }
}
