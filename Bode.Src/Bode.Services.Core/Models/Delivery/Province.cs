using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bode.Services.Core.Models.Delivery
{
    [Generate]
    [Description("省信息")]
    public class Province : EntityBase<int>
    {
        public Province()
        {
            Citys = new List<City>();
        }

        [Description("省")]
        public string Name { get; set; }

       // [Description("市集合")]
        public virtual ICollection<City> Citys { get; set; }

        public virtual Area Area { get; set; }
    }
}
