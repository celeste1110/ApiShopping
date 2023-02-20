using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
using ApiShopp.Domain.Services;
namespace ApiShopp.Controllers
{
    [Route("api/[controller]")]
    //[Produces("application/json")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("get-orders")]
        public async Task<OrderResponse> GetOrders([FromBody] OrderRequest request)
        {
            return await _orderService.GetOrders(request);
        }


        [HttpPost("get-order-single")]
        public async Task<SingleOrderResponse> GetSingleOrder([FromBody] SingleOrderRequest request)
        {
            return await _orderService.GetSingleOrder(request);
        }
    }
}
