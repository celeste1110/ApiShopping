using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Request
{
    public class OrderRequest
    {
        public int status { get; set; }
        public string clientCode { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int boatCode { get; set; }
    }
}
