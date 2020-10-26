using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models
{
    public abstract class BaseRequest<T>
    {
        public BaseRequest(string code, string apiSecret)
        {
            this.Code = code;
            this.ApiSecret = apiSecret;
        }
        public string Code { get; set; }
        public string ApiSecret { get; set; }
        public abstract string Url { get;}
    }

    public class BaseResponse<T>
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string RequestId { get; set; }
        public string TimeStamp { get; set; }
        [JsonConverter(typeof(DataConvert))]
        public T Items { get; set; }
    }


    public class DataConvert : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                var result = serializer.Deserialize(reader);

                if (result.ToString() == "[]")
                    return null;

                return JsonConvert.DeserializeObject(result.ToString(), objectType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Console.WriteLine(111);
        }
    }
}
