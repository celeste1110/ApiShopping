using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiShopp.Domain.Entities
{
    public class User
    {
        public int userCode { get; set; }
        public string usuario { get; set; }
        public int rolCode { get; set; }
        public string rolName { get; set; }
        public string name { get; set; }
        public string clientCode { get; set; }
        public string userType { get; set; }
        public int crewMemberCode { get; set; }
        public string password { get; set; }

        public string nameUser { get; set; }

        public string lastNameUser { get; set; }
        public string createFor { get; set; }
        public bool enabled { get; set; }

        public string dni { get; set; }
        public Boat boat { get; set; }
      

        public Person person { get; set; }

        //public string token { get; set; }
    }
}
