using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bode.Services.Core.Models.Delivery
{
    [Generate]
    [Description("市信息")]
    public class City : EntityBase<int>
    {
        public City() {
            Regions = new List<Region>();
        }

        [Description("市")]
        public string Name { get; set; }

        [Description("所属省份")]
        public virtual Province Province { get; set; }

        /// <summary>
        /// 区集合
        /// </summary>
        public virtual ICollection<Region> Regions { get; set; }
    }
}
