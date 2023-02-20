using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class MeasureProduct
    {
        public int measureCode { get; set; }
        public string measureName { get; set; }
        public string measureNameMin { get; set; }
        public string createFor { get; set; }

        public bool enabled { get; set; }
    }
}
