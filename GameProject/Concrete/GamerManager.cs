using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        //GamerCheckManager'ın doğrulama methodunu kullanmak için.
        GamerCheckManager _checkManager;

        public GamerManager(GamerCheckManager checkManager)
        {
           _checkManager = checkManager;
        }

        public void Delete(Gamer gamer)
           
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Register(Gamer gamer)
        {
            Console.WriteLine("Kayıt olundu."+ gamer.FirstName);
            _checkManager.CheckIfRealPerson(gamer);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Güncelleme başarılı.");
        }
    }
}
