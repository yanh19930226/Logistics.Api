using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models
{
    public class GoodsTypeRequest : BaseRequest<BaseResponse<List<GoodsTypeReponse>>>
    {
        public GoodsTypeRequest(string code, string apiSecret) : base(code, apiSecret)
        {

        }
        public override string Url => "http://oms.api.yunexpress.com/api/Common/GetGoodsType";
    }

    public class GoodsTypeReponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 货品类型英文名称
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// 货品类型中文名称
        /// </summary>
        public string CName { get; set; }
    }
}
