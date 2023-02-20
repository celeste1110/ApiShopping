using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Entities;
namespace ApiShopp.Domain.Response
{
    public class OrderResponse
    {
        public IEnumerable<Order> orders { get; set; }
    }
}
