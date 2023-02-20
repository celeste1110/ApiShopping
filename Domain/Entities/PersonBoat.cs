using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class PersonBoat
    {
        public int personBoatCode { get; set; }
        public int personCode { get; set; }
        public Person person { get; set; }
        public int boatCode { get; set; }
        public Boat boat { get; set; }

        public string createFor { get; set; }
        public bool enabled { get; set; }
    }
}
