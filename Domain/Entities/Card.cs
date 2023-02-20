using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class Card
    {
        public int cardCode { get; set; }
        public string cardNumber { get; set; }
        public int supplyDistrictId { get; set; }
        public SupplyDistrict supplyDistrict { get; set; }
        public string createFor { get; set; }
        public bool enabled { get; set; }
     
    }
}
