using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Xunit;
using YDH.Sdk;
using YDH.Sdk.Models;

namespace Logistics.Api.Test
{

    public class RandomNumber
    {
        public static object _lock = new object();
        public static int count = 1;

        public string GetRandom1()
        {
            lock (_lock)
            {
                if (count >= 10000)
                {
                    count = 1;
                }
                var number = "P" + DateTime.Now.ToString("yyMMddHHmmss") + count.ToString("0000");
                count++;
                return number;
            }
        }


        public string GetRandom2()
        {
            lock (_lock)
            {
                return "T" + DateTime.Now.Ticks;

            }
        }

        public string GetRandom3()
        {
            lock (_lock)
            {
                Random ran = new Random();
                return "U" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ran.Next(1000, 9999).ToString();
            }
        }
    }
    public class YDHTests
    {
        [Fact]
        public void CreateOrder()
        {
            Shipper shipper = new Shipper()
            {
                shipper_name = "易酷",
                shipper_countrycode = "CN",
                shipper_street = "福建省莆田市工业园",
                shipper_telephone = "18650805022",
                shipper_mobile = "18650805022"
            };

            Consignee consignee = new Consignee()
            {
                consignee_name = "Marie Denise Medard Francois",
                /// <summary>
                /// 收件人国家二字代码
                /// </summary>
                consignee_countrycode = "US",
                /// <summary>
                /// 收件人省
                /// </summary>
                consignee_province = "US-FL",
                /// <summary>
                /// 收件人城市
                /// </summary>
                consignee_city = "Mattapan",
                /// <summary>
                /// 收件人地址
                /// </summary>
                consignee_street = "760 Cummins HWY Apt11",
                /// <summary>
                /// 收件人邮编
                /// </summary>
                consignee_postcode = "02126",
                /// <summary>
                /// 收件人电话
                /// </summary>
                consignee_telephone = "862-235-2637",
                /// <summary>
                /// 收件人手机
                /// </summary>
                consignee_mobile = "",
                /// <summary>
                /// 税号
                /// </summary>
                consignee_tariff = "",
            };

            List<Invoice> invoiceList = new List<Invoice>();

            Invoice invoice = new Invoice();
            invoice.invoice_enname = "Dresses";
            invoice.invoice_cnname = "是否是";
            invoice.invoice_quantity = "1";
            invoice.invoice_unitcharge = "2.34";
            invoice.consignee_street = "760 Cummins HWY Apt11";
            invoice.consignee_postcode = "02126";
            invoiceList.Add(invoice);

            var start = consignee.consignee_province.IndexOf("-") + 1;

            var cons = consignee.consignee_province.Substring(start);

            CreateOrderReqModel model = new CreateOrderReqModel()
            {
                reference_no = "LB20121891902",
                shipping_method = "EUBYD",
                order_weight = "10",
                consignee = consignee,
                shipper = shipper,
                invoice = invoiceList
            };
            CreateOrderReq req = new CreateOrderReq(model);
            YDHClient yDHClient = new YDHClient();
            var response = yDHClient.PostRequestAsync(req);
            Assert.Equal(true, 1 > 0);
        }

        [Fact]
        public void GetTrackingNumber()
        {
            GetTrackingNumberReqModel model = new GetTrackingNumberReqModel() { reference_no = "LB20121891902" };
            GetTrackingNumberReq req = new GetTrackingNumberReq(model);
            YDHClient yDHClient = new YDHClient();
            var response = yDHClient.PostRequestAsync(req);
            Assert.Equal(true, 1 > 0);
        }

        [Fact]
        public void GetTrack()
        {
            GetTrackReqModel model = new GetTrackReqModel() { tracking_number = "LY822835750CN" };
            GetTrackReq req = new GetTrackReq(model);
            YDHClient yDHClient = new YDHClient();
            var response = yDHClient.PostRequestAsync(req);
            Assert.Equal(true, 1 > 0);
        }
        [Fact]
        public void Delete()
        {
            RemoveOrderReqModel model = new RemoveOrderReqModel() { reference_no = "P2107081654580001" };
            RemoveOrderReq req = new RemoveOrderReq(model);
            YDHClient yDHClient = new YDHClient();
            var response = yDHClient.PostRequestAsync(req);
            Assert.Equal(true, 1 > 0);
        }

        [Fact]
        public void Label()
        {
            configInfo conf = new configInfo()
            {
                lable_file_type = "2",
                lable_paper_type = "2",
                lable_content_type = "6",
                additional_info = new additional_info()
                {
                    lable_print_invoiceinfo = "Y",
                    lable_print_buyerid = "Y",
                    lable_print_datetime = "Y",
                }
            };

            GetNewLabelReqModel newModel = new GetNewLabelReqModel()
            {
                configInfo = conf,
                listorder = new List<reference>() { new reference() { reference_no = "P2107071412180001" } }
            };
            GetNewLabelReq request = new GetNewLabelReq(newModel);
            YDHClient yDHClient = new YDHClient();
            var newRes = yDHClient.PostRequestAsync(request);

            if (newRes.success == 1)
            {
                var trackingNumber = ("HZZADA0008731719");
                using (WebClient web = new WebClient())
                {

                }
            }
            else
            {

            }
            Assert.Equal(true, 1 > 0);
        }
        [Fact]
        public void FeeTrailReqModel()
        {
            FeeTrailReqModel feeTrailReqModel = new FeeTrailReqModel()
            {
                country_code = "US",
                weight = "800"
            };

            FeeTrailReq req = new FeeTrailReq(feeTrailReqModel);

            YDHClient yDHClient = new YDHClient();

            var rep = yDHClient.PostRequestAsync(req);

            if (rep.data != null && rep.data.Count != 0)
            {
                var item = rep.data.FirstOrDefault(obj => obj.ServiceCode == "YDHGLON");
                if (item != null)
                {
                    var res = Convert.ToDecimal(item.TotalFee);

                    Console.WriteLine(res);
                }
            }
            Assert.Equal(true, 1 > 0);
        }
    }
}
