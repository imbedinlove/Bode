using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bode.Services.Core.Models.Delivery
{
    /// <summary>
    /// 区域
    /// </summary>
    [Generate]
    [Description("区域")]
    public class Area : EntityBase<int>
    {
        public Area()
        {
            Province = new List<Province>();
        }
        /// <summary>
        /// 区域
        /// </summary>
        [Description("区域")]
        public string Name { get; set; }

        /// <summary>
        /// 省集合
        /// </summary>
        public virtual ICollection<Province> Province { get; set; }
    }
}
