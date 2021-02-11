using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerCheckerService
    {
         void CheckIfRealPerson(Gamer gamer);
    }
}
