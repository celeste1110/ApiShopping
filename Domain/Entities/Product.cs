using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class Product
    {
        public int productCode { get; set; }
        public int categoryCode { get; set; }
        public string productName { get; set; }
        public int measureCode { get; set; }
        public bool draftCopy { get; set; }
        public MeasureProduct measure { get; set; }
        public CategoryProduct category { get; set; }

        public double price { get; set; }

        public string createFor { get; set; }

        public bool enabled { get; set; }
    }
}
