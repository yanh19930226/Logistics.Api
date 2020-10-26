using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using YunTu.SDK;
using YunTu.SDK.Models;

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
            var res = await _client.PostRequestAsync<BaseResponse<List<OrderResponse>>>(new CreateOrderRequest(Code, ApiSecret)
            {
                          CustomerOrderNumber="123333",
                          ShippingMethodCode= "THPHR",
                          PackageCount=2,
                          Weight = 1.00m,
                          Receiver =new Receiver {
                    CountryCode="",
                    FirstName="yanh",
                    LastName="hui",
                    Company="yanh",
                    Street="yanh",
                    City="yanh"
                }
            });
            Assert.True(res.Code == "0000");
        }
    }
}
