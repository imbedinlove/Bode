using OSharp.Data.Entity;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Implement.ModelConfigs.Delivery
{
    /// <summary>
    /// 实体映射类——收货地址信息
    /// </summary>
    public class DeliveryAddressConfiguration : EntityConfigurationBase<DeliveryAddress, int>
    {
        public DeliveryAddressConfiguration()
        {
            HasRequired(p => p.UserInfo);
        }
    }
}