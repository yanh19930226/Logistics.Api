using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models.Orders
{
    public class CreateOrderRequest : BaseRequest<BaseResponse<List<OrderResponse>>>
    {
        public CreateOrderRequest(string code, string apiSecret) : base(code, apiSecret)
        {

        }

        public List<OrderRequest> OrderRequest { get; set; }

        public override string Url => "http://oms.api.yunexpress.com/api/WayBill/CreateOrder";
    }


    public class OrderRequest
    {
        /// <summary>
        /// 客户订单号,不能重复
        /// </summary>
        public string CustomerOrderNumber { get; set; }
        /// <summary>
        /// 运输方式代码
        /// </summary>
        public string ShippingMethodCode { get; set; }
        /// <summary>
        /// 运单包裹的件数，必须大于 0 的整数
        /// </summary>
        public int PackageCount { get; set; }
        /// <summary>
        /// 预估包裹总重量，单位 kg,最多 3 位小数
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// 收件人信息
        /// </summary>
        public Receiver Receiver { get; set; }

        public List<Parcels> Parcels { get; set; }
    }

    public class OrderResponse
    {
        /// <summary>
        ///客户的订单号
        /// </summary>
        public string CustomerOrderNumber { get; set; }
        /// <summary>
        ///运单请求状态，1-成功，0-失败
        /// </summary>
        public int Success { get; set; }
        /// <summary>
        ///1-已产生跟踪号，2-等待后续更新跟踪号,3-不需 要跟踪号
        /// </summary>
        public string TrackType { get; set; }
        /// <summary>
        /// 运单请求失败反馈失败原因
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 0-不需要分配地址，1-需要分配地址
        /// </summary>
        public string RequireSenderAddress { get; set; }
        /// <summary>
        ///代理单号
        /// </summary>
        public string AgentNumber { get; set; }
        /// <summary>
        ///YT 运单号
        /// </summary>
        public string WayBillNumber { get; set; }
        /// <summary>
        /// 跟踪号
        /// </summary>
        public string TrackingNumber { get; set; }

        public List<ShipperBoxs> ShipperBoxs { get; set; }
    }
}
