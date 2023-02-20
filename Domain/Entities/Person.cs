using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class Person
    {
        public int personCode { get; set; }
        public string dni { get; set; }
        public string personName { get; set; }
        public string personLastName { get; set; }
        public string personEmail { get; set; }
        public string personPhone { get; set; }
        public string createFor { get; set; }
        public bool enable{ get; set; }

        public int typeDocumentCode { get; set; }

       
        public string sexo { get; set; }
        public string fullName { get; set; }

        public TypeDocument typeDocument { get; set; }
    }
}
