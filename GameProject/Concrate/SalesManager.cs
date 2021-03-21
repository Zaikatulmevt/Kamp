using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class SalesManager : ISalesService
    {
        public void Sale(Game game, User user)
        {
            Console.WriteLine("Sayın " + user.FirstName+" "+user.LastName +" "+ game.GameName + " isimli oyunu satın almış bulunuyorsunuz. Oyunu satın aldığınız için teşekkür eder iyi eğlenceler dileriz.");
        }
    }
}
