using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidatinoManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if (gamer.Id == 1 && gamer.BirthYear == 1996 && gamer.FirstName == "Gamze" && gamer.LastName == "Aydın" && gamer.IdentityNumber == 12356)
            {
                return true;
            }
            else if (gamer.Id == 2 && gamer.BirthYear == 2004 && gamer.FirstName == "cemre" && gamer.LastName == "Aydın" && gamer.IdentityNumber == 12796)
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
