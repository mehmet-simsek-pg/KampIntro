using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalityId { get; set; }

    }
}
