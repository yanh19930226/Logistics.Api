using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models.Orders
{
    public class GetOrderRequest : BaseRequest<BaseResponse<GetOrderResponse>>
    {
        public GetOrderRequest(string code, string apiSecret) : base(code, apiSecret)
        {

        }
        /// <summary>
        ///物流系统运单号，客户订单或跟踪号
        /// </summary>
        public string OrderNumber { get; set; }
        public override string Url => "http://oms.api.yunexpress.com/api/WayBill/GetOrder";
    }

    public class GetOrderResponse
    {
        /// <summary>
        ///物流系统运单号
        /// </summary>
        public string WayBillNumber { get; set; }
        /// <summary>
        ///客户订单号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        ///发货的方式
        /// </summary>
        public string ShippingMethodCode { get; set; }
        /// <summary>
        /// 包裹跟踪号
        /// </summary>
        public string TrackingNumber { get; set; }
        /// <summary>
        ///平台交易号
        /// </summary>
        public string TransactionNumber { get; set; }
        /// <summary>
        ///预估包裹单边长，单位 cm
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        ///预估包裹单边宽，单位 cm
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 预估包裹单边高，单位 cm
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        ///订单状态：3-已提交，4-已收货，5-发货运输中，6-已删除， 7-已退回，8-待转单，9-退货在仓，10-已签收
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        ///运单的包裹件数
        /// </summary>
        public int PackageNumber { get; set; }
        /// <summary>
        /// 预估包裹总重量，单位 kg
        /// </summary>
        public decimal Weight { get; set; }

        public Receiver Receiver { get; set; }

        public List<Parcels> Parcels { get; set; }
    }
}
