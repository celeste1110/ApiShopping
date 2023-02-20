using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiShopp.Domain.Entities;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
using ApiShopp.Utlilities;
using Dapper;
using System.IO;
using System.Text;

namespace ApiShopp.Domain.Repository
{
    public class OrderRepository
    {
        public static OrderResponse GetOrders(OrderRequest request)
        {
            OrderResponse oOrderResponse = new OrderResponse();
            var procedure = "execute USP_2023_LISTAR_PEDIDOS_API @status,@clientCode,@startDate,@endDate,@boatCode;";
            var values = new { status = request.status, clientCode = request.clientCode, startDate=request.startDate, endDate=request.endDate, boatCode=request.boatCode };

            using (var connection = BdConnection.getConnection())
            {

                try
                {
                    var result = (connection.Query<Order>(procedure, values)?? new List<Order>()).ToList();

                   
                    return new OrderResponse
                    {
                        
                        orders = result
                    };

                }
                catch (Exception ex)
                {
                    return oOrderResponse;
                }

            }


        }

        public static SingleOrderResponse GetSingleOrder(SingleOrderRequest request)
        {
            SingleOrderResponse oSingleOrderResponse = new SingleOrderResponse();
            var procedure = "execute USP_2023_LISTAR_PEDIDO_API @orderCode;";
            var values = new { orderCode = request.orderCode };

            using (var connection = BdConnection.getConnection())
            {

                try
                {
                    var result = connection.QueryFirstOrDefault<SingleOrder>(procedure, values);
                    var categories = DataRepository.GetCategoryProducts("").ToList();
                    var measures = DataRepository.GetMeasureProducts("").ToList();
                    var details = GetDetails(result.orderCode, categories, measures).ToList();
                    result.detail = details;
                    return new SingleOrderResponse
                    {

                        order = result
                    };

                }
                catch (Exception ex)
                {
                    return oSingleOrderResponse;
                }

            }


        }

        private static IEnumerable<OrderDetail> GetDetails(int codOrder, List<CategoryProduct> categories,
          List<MeasureProduct> measures)
        {
            var procedure = "execute USP_2023_LISTAR_DETALLE_PEDIDO_API @OrderCode;";

            var parameters = new { OrderCode = codOrder};

            using (var connection = BdConnection.getConnection())
            {
                var nDetails = (connection.Query<OrderDetail>(procedure, parameters) ?? new List<OrderDetail>()).ToList();
                var pivotDetails = new List<OrderDetail>();

                var products =
                    DataRepository.GetProducts("",categories, measures).ToList();

                foreach (var orderDetail in nDetails)
                {
                    orderDetail.product = products.Find(x => x.productCode == orderDetail.productCode);
                    if (orderDetail.product != null)
                    {
                        pivotDetails.Add(orderDetail);
                    }
                }

                return pivotDetails;
            }
        }

     

    }


}
