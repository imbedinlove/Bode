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
    [Generate]
    [Description("学历")]
    public class Education : EntityBase<int>
    {
        [Description("名称")]
        public string Name { get; set; }
    }
}
