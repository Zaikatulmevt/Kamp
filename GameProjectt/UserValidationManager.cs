using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectt
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2002 && gamer.FirstName == "Metehan Melih" && gamer.LastName == "Yapan" && gamer.İdentitiyNumber == 12313132131)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
