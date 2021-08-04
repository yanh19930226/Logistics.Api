using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using YDH.Sdk.Models;

namespace YDH.Sdk
{
    public class YDHClient
    {
        private HttpClient _client { get; }
        public YDHClient()
        {
            _client = new HttpClient();
        }
        public K PostRequestAsync<T, K>(BaseRequest<T, K> request)
        {
            var host = "http://customer.ydhex.com/webservice/PublicService.asmx/ServiceInterfaceUTF8";
            var dic = new Dictionary<string, string> {
                { "appToken", request.appToken },
                { "appKey",request.appKey },
                { "serviceMethod",request.serviceMethod },
                { "paramsJson",JsonConvert.SerializeObject(request.model)}};

            var client = new HttpClient();
            var req = new HttpRequestMessage(HttpMethod.Post, host) { Content = new FormUrlEncodedContent(dic) };
            var res = client.SendAsync(req).Result;
            var str = res.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeObject<K>(str);

            return obj;
        }
    }
}
