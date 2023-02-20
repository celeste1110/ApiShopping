using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class AttentionPort
    {
        public int attentionPortCode { get; set; }
        public string attentionPortName { get; set; }
        public bool enabled { get; set; }
        public string createFor { get; set; }
        public string nomenclature { get; set; }

    }
}
