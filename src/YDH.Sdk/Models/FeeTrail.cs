using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public class FeeTrailReq : BaseRequest<FeeTrailReqModel, BaseResponse<List<FeeTrailRes>>>
    {
        public FeeTrailReq(FeeTrailReqModel model) : base(model)
        {

        }
        public override string serviceMethod => "feetrail";
    }

    public class FeeTrailReqModel
    {
        /// <summary>
        /// country_code
        /// </summary>
        public string country_code { get; set; }
        /// <summary>
        /// 运输方式代码
        /// </summary>
        public string weight { get; set; }
        /// <summary>
        /// 运输方式代码
        /// </summary>
        public string order_weight { get; set; }
        /// <summary>
        /// 发件人信息
        /// </summary>
        public Shipper shipper { get; set; }
        /// <summary>
        /// 收件人信息
        /// </summary>
        public Consignee consignee { get; set; }
        /// <summary>
        /// 海关申报信息
        /// </summary>
        public List<Invoice> invoice { get; set; }
    }
    public class FeeTrailRes
    {
        /// <summary>
        /// ServiceCode
        /// </summary>
        public string ServiceCode { get; set; }
        /// <summary>
        /// ServiceCnName
        /// </summary>
        public string ServiceCnName { get; set; }
        /// <summary>
        /// ServiceEnName
        /// </summary>
        public string ServiceEnName { get; set; }
        /// <summary>
        /// channel_hawbcode
        /// </summary>
        public string ChargeWeight { get; set; }
        /// <summary>
        /// Effectiveness
        /// </summary>
        public string Effectiveness { get; set; }
        /// <summary>
        /// Formula
        /// </summary>
        public string Formula { get; set; }
        /// <summary>
        /// FreightFee
        /// </summary>
        public string FreightFee { get; set; }
        /// <summary>
        /// FuelFee
        /// </summary>
        public string FuelFee { get; set; }

        public string RegisteredFee { get; set; }
        /// <summary>
        /// FreightFee
        /// </summary>
        public string OtherFee { get; set; }
        /// <summary>
        /// FuelFee
        /// </summary>
        public string TotalFee { get; set; }

        /// <summary>
        /// Traceability
        /// </summary>
        public string Traceability { get; set; }

        /// <summary>
        /// VolumeCharge
        /// </summary>
        public string VolumeCharge { get; set; }
    }
}
