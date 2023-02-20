using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class TypeDocument
    {
        public int typeDocumentCode { get; set; }
        public string typeDocumentName { get; set; }

        public string createFor { get; set; }

        public bool enabled { get; set; }
    }
}
