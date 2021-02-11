using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckerService
    {
        //Simule kontrol sistemi burdakilerle oluşturulan gamer eşleşirse kayıt işlemine izin verir. 
        public void CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName=="Lady" && gamer.LastName=="Gaga" && gamer.NationalityNumber== "123456789012")
            {
                Console.WriteLine("Checked!");
            }else
                throw new Exception("Not a valid person."); //eşleşmezde buraya gel.
        }
    }
}
