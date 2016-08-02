using Bode.Services.Core.Models.User;
using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bode.Services.Core.Models.Delivery
{
    [Generate]
    [Description("配送-收货地址")]
    public class DeliveryAddress : EntityBase<int>
    {
        /// <summary>
        /// 收货人
        /// </summary>
        [Required, Description("收货人")]
        public string Consignee { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Required, Description("联系电话")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [Required, Description("省")]
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [Required, Description("市")]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [Required, Description("区")]
        public string District { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [Description("邮编")]
        public string PostCode { get; set; }

        /// <summary>
        /// 配送地址
        /// </summary>
        [Required, Description("配送地址")]
        public string ShipAddress { get; set; }

        /// <summary>
        /// 是否默认收货地址
        /// </summary>
        [Description("是否默认收货地址")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [Description("用户信息")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
