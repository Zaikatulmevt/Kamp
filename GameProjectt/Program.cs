using System;

namespace GameProjectt
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id=1, BirthYear= 2002, FirstName= "Metehan Melih", LastName="Yapan", İdentitiyNumber= 12313132131});
        }
    }
}
