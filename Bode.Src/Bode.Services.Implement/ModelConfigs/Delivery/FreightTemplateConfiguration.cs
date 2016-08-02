using OSharp.Data.Entity;
using Bode.Services.Core.Models.Delivery;

namespace Bode.Services.Implement.ModelConfigs.Delivery
{
    public class FreightTemplateConfiguration : EntityConfigurationBase<FreightTemplate, int>
    {
        public FreightTemplateConfiguration()
        {
            HasRequired(x => x.Province);
            HasRequired(m => m.Logistics);
        }
    }
}
