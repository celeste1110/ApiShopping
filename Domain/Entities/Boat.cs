using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class Boat
    {
        public int boatCode { get; set; }
        public string boatName { get; set; }
        public string clientCode { get; set; }
        public int crewCount { get; set; }
        public double normalDailyFactor { get; set; }
        public double specialDailyFactor { get; set; }

        public string createFor { get; set; }

        public bool enabled { get; set; }
    }
}
