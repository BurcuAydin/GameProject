using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public DateTime BirthOfDate { get; set; }
        public string NationalityNumber { get; set; }
        public object Register { get; internal set; }
    }
}
