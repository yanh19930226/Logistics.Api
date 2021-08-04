using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Api.Services
{
    public interface ILogisticsService
    {
        /// <summary>
        /// 创建物流单
        /// </summary>
        /// <param name="logistics"></param>
        /// <param name="itemDic"></param>
        public  void Create(erp.dbmodel.OrderLogistics logistics, Dictionary<erp.dbmodel.OrderDetailed, erp.dbmodel.GoodsSku> itemDic);

        /// <summary>
        /// 获取预估运费
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="weight"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public  decimal GetEvaluateShippingFee(string countryCode, decimal weight, string code);

        /// <summary>
        /// 获取实际运费
        /// </summary>
        /// <param name="logistics"></param>
        /// <returns></returns>
        public  ShippingFee GetRealShippingFee(string trackingNumber);

        /// <summary>
        /// 获取跟踪信息
        /// </summary>
        /// <param name="logistics"></param>
        /// <returns>是否妥投，跟踪信息</returns>
        public void Dictionary<bool, IList<OrderTracking>> Track(string trackingNumber);
    }
}
