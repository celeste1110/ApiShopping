using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class OrderDetail
    {
        public int orderDetailCode { get; set; }
        public int orderCode { get; set; }
        public string commentary { get; set; }
        public int amount { get; set; }
        public int status { get; set; }
        public int productCode { get; set; }
        public Product product { get; set; }
    }
}
