using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.ComponentModel;

namespace Bode.Services.Core.Models.Delivery
{
    [Generate]
    [Description("配送-运费模版")]
    public class FreightTemplate : EntityBase<int>
    {

        /// <summary>
        /// 快递名称和网址
        /// </summary>
        [Description("快递名称和网址")]
        public virtual Logistics Logistics { get; set; }

        /// <summary>
        /// 起始数量
        /// </summary>
        [Description("起始数量")]
        public int BeginCount { get; set; }

        /// <summary>
        /// 触发叠加运费的数量
        /// </summary>
        [Description("触发叠加运费的数量")]
        public int AddCount { get; set; }

        /// <summary>
        /// 初始运费
        /// </summary>
        [Description("初始运费")]
        public decimal Price { get; set; }

        /// <summary>
        /// 叠加运费
        /// 每触发一次叠加数量, 加一次运费
        /// </summary>
        [Description("叠加运费")]
        public decimal AddPrice { get; set; }

        /// <summary>
        /// 配送省
        /// </summary>
        [Description("配送省")]
        public virtual Province Province { get; set; }
        //public virtual City City { get; set; }
    }
}
