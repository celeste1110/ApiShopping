using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class SupplyDistrict
    {
        public int supplyDistrictId { get; set; }
        public int supplyId { get; set; }
        public Supply supply { get; set; }
        public string departmentCode { get; set; }
        public Department department { get; set; }
        public string provinceCode { get; set; }
        public Province province { get; set; }
        public int districtCode { get; set; }
        public District district { get; set; }

        public string address { get; set; }

        public string alias { get; set; }

        public string createFor { get; set; }

        public bool enabled { get; set; }
    }
}
