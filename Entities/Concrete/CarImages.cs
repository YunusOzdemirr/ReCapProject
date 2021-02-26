using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImages:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Guid ImagePath { get; set; }
        public DateTime Datee = DateTime.Now;
    }
}
