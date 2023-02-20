using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class CategoryProduct
    {
        public int categoryCode { get; set; }
        public string categoryName { get; set; }

        public string createFor { get; set; }

        public bool enabled { get; set; }
    }
}
