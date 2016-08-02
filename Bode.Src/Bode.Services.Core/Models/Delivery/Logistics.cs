using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bode.Services.Core.Models.Delivery
{
    [Generate]
    [Description("物流信息")]
    public class Logistics : EntityBase<int>
    {
        /// <summary>
        /// 物流名称(顺丰,申通...)
        /// </summary>
        [Description("物流名称")]
        public string Name { get; set; }

        /// <summary>
        /// 物流官网
        /// </summary>
        [Description("物流官网")]
        public string Url { get; set; }
    }
}
