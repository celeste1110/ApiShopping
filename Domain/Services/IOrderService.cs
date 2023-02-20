using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
namespace ApiShopp.Domain.Services
{
    public interface IOrderService
    {
        //Task<OrderResponse> InsertOrUpdateOrder(OrderRequest request);
        Task<OrderResponse> GetOrders(OrderRequest request);
        Task<SingleOrderResponse> GetSingleOrder(SingleOrderRequest request);
    }
}
