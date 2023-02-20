using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using ApiShopp.Domain.Entities;
using ApiShopp.Domain.Request;
using ApiShopp.Domain.Response;
using ApiShopp.Utlilities;

namespace ApiShopp.Domain.Repository
{
    public class DataRepository
    {

        public static IEnumerable<TypeDocument> GetTypeDocument()
        {
            var procedure = "execute USP_2023_LISTAR_TIPOS_DOCUMENTOS_API;";

            using (var connection = BdConnection.getConnection())
            {
                return connection.Query<TypeDocument>(procedure) ?? new List<TypeDocument>();
            }
        }

        public static IEnumerable<CategoryProduct> GetCategoryProducts(string name)
        {
            var procedure = "execute USP_2023_LISTAR_CATEGORIA_API @nameCategory;";
            var values = new { nameCategory = name };

            using (var connection = BdConnection.getConnection())
            {
                return connection.Query<CategoryProduct>(procedure,values) ?? new List<CategoryProduct>();
            }
        }

        public static IEnumerable<MeasureProduct> GetMeasureProducts(string name)
        {
            var procedure = "execute USP_2023_LISTAR_MEASURE_PRODUCT_API @name;";
            var values = new { name = name };
            using (var connection = BdConnection.getConnection())
            {
                return connection.Query<MeasureProduct>(procedure,values) ?? new List<MeasureProduct>();
            }
        }

        public static IEnumerable<Product> GetProducts(string name, List<CategoryProduct> categories, List<MeasureProduct> measures)
        {
            List<Product> oProduct = new List<Product>();
            var procedure = "execute USP_2023_LISTAR_PRODUCTOS_API @name;";
            var values = new { name = name };
            using (var connection = BdConnection.getConnection())
            {
                try
                {
                    var products = (connection.Query<Product>(procedure, values) ?? new List<Product>()).ToList();

                    foreach (var product in products)
                    {
                        product.category = categories.Find(x => x.categoryCode == product.categoryCode) ??
                                           new CategoryProduct
                                           {
                                               categoryCode = 0,
                                               categoryName = "",
                                               createFor="",
                                               enabled=false
                                           };
                        product.measure = measures.Find(x => x.measureCode == product.measureCode) ?? new MeasureProduct
                        {
                            measureCode = 0,
                            measureName = "",
                            measureNameMin = "",
                            createFor = "",
                            enabled = false
                        };
                    }

                    return products;
                }
                catch (Exception ex)
                {
                    return oProduct;
                }
               
            }
        }
    }
}
