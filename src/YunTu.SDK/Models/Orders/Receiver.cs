using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models.Orders
{
    public class Receiver
    {
        /// <summary>
        ///收件人所在国家，填写国际通用标准 2 位简码， 可通过国家查询服务查询
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        ///收件人姓
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        ///收件人名字
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 收件人公司名称
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 州
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 收件人详细地址
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }
    }
}
