﻿using System;

using OSharp.Data.Entity.Migrations;
using Bode.Services.Core.Models.Identity;
using OSharp.Data.Entity.Default;

namespace Bode.Services.Implement.DbSeed
{
    public class CreateSysRoleSeedAction : ISeedAction<DefaultDbContext>
    {
        /// <summary>
        /// 定义种子数据初始化过程
        /// </summary>
        /// <param name="context">数据上下文</param>
        public void Action(System.Data.Entity.DbContext context)
        {
            context.Set<SysRole>()
                .Add(new SysRole()
                {
                    Name = "超级管理员",
                    Remark = "超级管理员角色，拥有系统最高权限",
                    IsAdmin = true,
                    IsSystem = true,
                    IsLocked = false,
                    CreatedTime = DateTime.Now
                });
        }

        /// <summary>
        /// 获取 操作排序，数值越小越先执行
        /// </summary>
        public int Order
        {
            get { return 1; }
        }
    }
}