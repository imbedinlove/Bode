using OSharp.Data.Entity;
using Bode.Services.Core.Models.User;


namespace Bode.Services.Implement.ModelConfigs.User
{
    /// <summary>
    /// 实体映射类——用户信息映射信息
    /// </summary>
    public class UserInfoConfiguration : EntityConfigurationBase<UserInfo, int>
    {
        public UserInfoConfiguration()
        {
            HasRequired(m => m.Region);
            HasRequired(m => m.Education);
            HasRequired(m => m.Position);
            HasMany(m => m.Labels);
        }
    }
}