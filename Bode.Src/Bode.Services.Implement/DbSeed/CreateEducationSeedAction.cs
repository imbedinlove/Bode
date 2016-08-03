
using Bode.Services.Core.Models.Industry;
using OSharp.Data.Entity.Default;
using OSharp.Data.Entity.Migrations;
using System.Collections.Generic;


namespace Bode.Services.Implement.DbSeed
{
    public class CreateEducationSeedAction : ISeedAction<DefaultDbContext>
    {
        /// <summary>
        /// 定义种子数据初始化过程
        /// </summary>
        /// <param name="context">数据上下文</param>
        public void Action(System.Data.Entity.DbContext context)
        {
            context.Set<Education>().AddRange(
                new List<Education>()
                {
                    new Education() { Name = "初中"},
                    new Education() { Name = "高中"},
                    new Education() { Name = "大学"}
                });
        }

        /// <summary>
        /// 获取 操作排序，数值越小越先执行
        /// </summary>
        public int Order
        {
            get { return 2; }
        }
    }
}
