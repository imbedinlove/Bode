using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bode.Services.Core.Models.Delivery
{
    /// <summary>
    /// 区--市级下
    /// </summary>
    [Generate]
    [Description("区--市级下")]
    public class Region : EntityBase<int>
    {
        /// <summary>
        /// 区--市级下
        /// </summary>
        [Description("区--市级下")]
        public string Name { get; set; }

        public virtual City City { get; set; }
    }
}
