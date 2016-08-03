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
    /// 行业
    /// </summary>
    [Generate]
    [Description("行业")]
    public class Trade : EntityBase<int>
    {
        public Trade()
        {
            Professions = new List<Profession>();
        }

        /// <summary>
        /// 行业名称
        /// </summary>
        [Description("行业名称")]
        public string Name { get; set; }

        public virtual ICollection<Profession> Professions { get; set; }
    }
}
