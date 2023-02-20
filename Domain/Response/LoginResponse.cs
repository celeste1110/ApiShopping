using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Entities;

namespace ApiShopp.Domain.Response
{
    public class LoginResponse
    {
        public string status { get; set; }
        public string token { get; set; }
        public string message { get; set; }
        public User user { get; set; }
    }
}
