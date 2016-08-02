using OSharp.Data.Entity;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Implement.ModelConfigs.Delivery
{
    public class CityConfiguration : EntityConfigurationBase<City, int>
    {
        public CityConfiguration()
        {
            HasRequired(x => x.Province).WithMany(p=>p.Citys);
        }
    }
}
