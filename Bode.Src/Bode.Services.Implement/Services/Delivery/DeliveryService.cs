﻿// <autogenerated>
//   This file was generated by T4 code generator ServicesCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using OSharp.Core;
using OSharp.Core.Data;
using OSharp.Utility;
using OSharp.Utility.Data;
using OSharp.Utility.Extensions;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Bode.Services.Core.Contracts;
using Bode.Services.Core.Dtos.Delivery;
using Bode.Services.Core.Models.Delivery;
using Bode.Services.Core.Models.User;

namespace Bode.Services.Implement.Services
{
    public partial class DeliveryService : IDeliveryContract
    {
        public IRepository<UserInfo, int> UserInfoRepo {protected get; set; }
    }
}
