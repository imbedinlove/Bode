using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bode.Services.Core.Models.Industry
{
    /// <summary>
    /// 职业
    /// </summary>
    [Generate]
    [Description("职业")]
    public class Profession: EntityBase<int>
    {
        public Profession() {
            Positions = new List<Position>();
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Description("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [Description("行业")]
        public virtual Trade Trade { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
