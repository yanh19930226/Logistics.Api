using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YunTu.SDK.Models;
using YunTu.SDK.Models.Orders;

namespace YunTu.SDK
{
    public class YuntuClient
    {

        public YuntuClient()
        {

        }

        #region private
        private static string Base64Encode(string content)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            return Convert.ToBase64String(bytes);
        }
        private string MD5(string source)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(source);
            string result = BitConverter.ToString(md5.ComputeHash(bytes));
            return result.Replace("-", "");
        }
        //private string GetApiBaseUrl()
        //{
        //    switch (_envEnum)
        //    {
        //        case EnvEnum.Dev:
        //            return "http://gztest.glitzcloud.com/agent/v1/";
        //        case EnvEnum.Prod:
        //            return "https://ssl.glitzcloud.com/agent/v1/";
        //        default:
        //            return "http://gztest.glitzcloud.com/agent/v1/";
        //    }
        //} 
        #endregion

        public Task<T> GetRequestAsync<T>(BaseRequest<T> request)
        {
            var Token = request.Code +"&"+ request.ApiSecret;
            return $"{request.Url}".WithHeaders(new { Accept = "application/json", Authorization = "Basic "+ Base64Encode(Token) })
                .GetAsync()
                .ReceiveJson<T>();
        }
        public Task<T> PostRequestAsync<T>(BaseRequest<T> request)
        {
            var Token = request.Code + "&" + request.ApiSecret;
            return $"{request.Url}".WithHeaders(new { Accept = "application/json", Authorization = "Basic " + Base64Encode(Token) })
                .PostJsonAsync(request)
                .ReceiveJson<T>();
        }

        /// <summary>
        /// 创建订单
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BaseResponse<List<OrderResponse>>> PostOrderRequestAsync<T>(CreateOrderRequest request)
        {
            var Token = request.Code + "&" + request.ApiSecret;
            return $"{request.Url}".WithHeaders(new { Accept = "application/json", Authorization = "Basic " + Base64Encode(Token) })
                .PostJsonAsync(request.OrderRequest)
                .ReceiveJson<BaseResponse<List<OrderResponse>>>();
        }

    }
}
