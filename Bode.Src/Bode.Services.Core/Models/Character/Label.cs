using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.ComponentModel;

namespace Bode.Services.Core.Models.Character
{
    /// <summary>
    /// 标签
    /// </summary>
    [Description("标签")]
    [Generate]
    public class Label : EntityBase<int>
    {
        /// <summary>
        /// 排序号
        /// </summary>
        [Description("排序号")]
        public int OrderNo { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [Description("名字")]
        public string Name { get; set; }
    }
}
