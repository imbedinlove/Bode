﻿using OSharp.Core.Data;
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
    [Description("职位")]
    public class Position: EntityBase<int>
    {
        [Description("名称")]
        public string Name { get; set; }

        [Description("职业")]
        public virtual Profession Profession { get; set; }
    }
}
