using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public abstract class BaseRequest<T, K>
    {
        public BaseRequest(T Model)
        {
            model = Model;
        }
        /// <summary>
        /// appToken
        /// </summary>
        public string appToken { get; set; } = "yj5f7itnzu80wbrfj6e6vfvndlg30dwcn";
        /// <summary>
        /// appKey
        /// </summary>
        public string appKey { get; set; } = "y5bcs1lv7660rws8t4o6zul3xsbvczxw75n0apxrus9zj55r3hk5y0n3thp9zzthj";
        /// <summary>
        /// paramsJson
        /// </summary>
        public T model { get; set; }
        /// <summary>
        /// serviceMethod
        /// </summary>
        public abstract string serviceMethod { get; }
    }

    public class BaseResponse<K>
    {
        /// <summary>
        /// success
        /// </summary>
        public int success { get; set; }
        /// <summary>
        /// cnmessage
        /// </summary>
        public string cnmessage { get; set; }
        /// <summary>
        /// enmessage
        /// </summary>
        public string enmessage { get; set; }
        /// <summary>
        /// data
        /// </summary>
        [JsonConverter(typeof(DataConvert))]
        public K data { get; set; }
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
