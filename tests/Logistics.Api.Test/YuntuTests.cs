using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using YunTu.SDK;
using YunTu.SDK.Models;
using YunTu.SDK.Models.Orders;

namespace Logistics.Api.Test
{
    public class YuntuTests
    {
        private YuntuClient _client;

        #region Shop
        private string Code = "C06901";

        private string ApiSecret = "3VniAsdO6mU=";

        #endregion

        public YuntuTests()
        {
            _client = new YuntuClient();
        }
        /// <summary>
        /// 查询国家简码
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetCountry()
        {
            var res = await _client.GetRequestAsync<BaseResponse<List<CountryReponse>>>(new CountryRequest(Code, ApiSecret));
            Assert.True(res.Code == "0000");
        }
        /// <summary>
        /// 查询运输方式
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetShippingMethods()
        {
            var res = await _client.GetRequestAsync<BaseResponse<List<ShippingMethodsReponse>>>(new ShippingMethodsRequest(Code, ApiSecret)
            {

            });
            Assert.True(res.Code == "0000");
        }
        /// <summary>
        /// 查询货品类型
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetGoodsType()
        {
            var res = await _client.GetRequestAsync<BaseResponse<List<GoodsTypeReponse>>>(new GoodsTypeRequest(Code, ApiSecret)
            {

            });
            Assert.True(res.Code == "0000");
        }
        /// <summary>
        /// 运单申请
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateOrder()
        {
            var res = await _client.PostOrderRequestAsync<BaseResponse<List<OrderResponse>>>(new CreateOrderRequest(Code, ApiSecret)
            {

                OrderRequest=new List<OrderRequest>() {
                    new OrderRequest(){
                         CustomerOrderNumber = "123333",
                    ShippingMethodCode = "THPHR",
                    PackageCount = 1,
                    Weight = 1.00m,
                    Receiver = new Receiver
                    {
                        State="CA",
                        Zip="92656",
                        Email="dwhitcher07@gmail.com",
                        Phone="(949) 887-3875",
                        CountryCode = "US",
                        FirstName = "Donna",
                        LastName = "Whitcher",
                        Company = "yanh",
                        Street = "68 Breakers Lane",
                        City = "ALISO VIEJO"
                    },
                    Parcels=new List<Parcels>(){ 
                       new Parcels{
                           CName="测试",
                           EName="test",
                           Quantity=1,
                           UnitPrice=2m,
                           UnitWeight=1m,
                           CurrencyCode="USD"
                       }
                    }
                    }
                }
            });
            Assert.True(res.Code == "0000");
        }

        /// <summary>
        /// 查询运单
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task GetOrder()
        {
            var res = await _client.GetRequestAsync<BaseResponse<GetOrderResponse>>(new GetOrderRequest(Code, ApiSecret)
            {
                OrderNumber = "YT2030021272207392",
            });
            Assert.True(res.Code == "0000");
        }

        /// <summary>
        /// 修改订单预报重量
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task UpdateWeight()
        {
            var res = await _client.PostRequestAsync<BaseResponse<UpdateWeightResponse>>(new UpdateWeightRequest(Code, ApiSecret)
            {
               OrderNumber= "YT2030021272207392",
                Weight=3.0m
            });
            Assert.True(res.Code == "0000");
        }
    }
}
