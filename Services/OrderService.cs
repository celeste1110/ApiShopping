using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Repository;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
using ApiShopp.Domain.Services;
namespace ApiShopp.Services
{
    public class OrderService : IOrderService
    {
        //public Task<OrderResponse> InsertOrUpdateOrder(OrderRequest request)
        //{
        //    return Task.FromResult(OrderRepository.SyncOrders(request));
        //}
        public Task<OrderResponse> GetOrders(OrderRequest request)
        {
            return Task.FromResult(OrderRepository.GetOrders(request));
        }

        public Task<SingleOrderResponse> GetSingleOrder(SingleOrderRequest request)
        {
            return Task.FromResult(OrderRepository.GetSingleOrder(request));
        }
    }
}
