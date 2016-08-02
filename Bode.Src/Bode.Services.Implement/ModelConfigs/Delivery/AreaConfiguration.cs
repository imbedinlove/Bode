using OSharp.Data.Entity;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Implement.ModelConfigs.Delivery
{
    public class AreaConfiguration : EntityConfigurationBase<Area, int>
    {
        public AreaConfiguration()
        {
            HasMany(m => m.Province);
        }
    }
}
