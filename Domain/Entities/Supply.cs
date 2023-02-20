using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class Supply
    {
        public int supplyId { get; set; }
        public string supplyName { get; set; }
        public string createFor { get; set; }
        public bool enable { get; set; }
    }
}
