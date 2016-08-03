
using Bode.Services.Core.Models.Character;
using Bode.Services.Core.Models.Delivery;
using OSharp.Data.Entity.Default;
using OSharp.Data.Entity.Migrations;
using System.Collections.Generic;


namespace Bode.Services.Implement.DbSeed
{
    public class CreateLabelSeedAction : ISeedAction<DefaultDbContext>
    {
        /// <summary>
        /// 定义种子数据初始化过程
        /// </summary>
        /// <param name="context">数据上下文</param>
        public void Action(System.Data.Entity.DbContext context)
        {
            context.Set<Label>().AddRange(
                new List<Label>() {
                    new Label() { Name = "游戏", OrderNo= 1},
                    new Label() { Name = "旅游", OrderNo= 2},
                    new Label() { Name = "看书", OrderNo= 3},
                    new Label() { Name = "音乐", OrderNo= 4},
                    new Label() { Name = "运动", OrderNo= 5},
                    new Label() { Name = "极客", OrderNo= 6},
                    new Label() { Name = "健身", OrderNo= 7},
                }
                );
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
