
using Bode.Services.Core.Models.Delivery;
using Bode.Services.Core.Models.Industry;
using OSharp.Data.Entity.Default;
using OSharp.Data.Entity.Migrations;
using System.Collections.Generic;


namespace Bode.Services.Implement.DbSeed
{
    public class CreateIndustrySeedAction : ISeedAction<DefaultDbContext>
    {
        /// <summary>
        /// 定义种子数据初始化过程
        /// </summary>
        /// <param name="context">数据上下文</param>
        public void Action(System.Data.Entity.DbContext context)
        {
            context.Set<Trade>().AddRange(
                new List<Trade>()
                {
                    new Trade()
                    {
                    Name = "IT",
                    Professions = new List<Profession>()
                    {
                        new Profession() {
                            Name = "计算机软件",
                            Positions = new List<Position>()
                            {
                                new Position()
                                {
                                    Name = "Unity3D程序员"
                                }
                            }
                        }
                    }
                }
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
