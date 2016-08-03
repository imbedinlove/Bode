using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Bode.Services.Core.Models.Identity;
using OSharp.Core.Data;
using OSharp.Utility.Develop.T4;
using Bode.Services.Core.Models.Delivery;
using Bode.Services.Core.Models.Industry;
using Bode.Services.Core.Models.Character;
using System.Collections.Generic;

namespace Bode.Services.Core.Models.User
{
    [Generate]
    [Description("用户-用户信息")]
    public class UserInfo : EntityBase<int>
    {
        public UserInfo() {
            Labels = new List<Label>();
        }
        [Description("头像地址")]
        public string HeadPic { get; set; }

        [Description("真实姓名")]
        public string RealName { get; set; }

        [Description("设备唯一标识号")]
        public string RegistKey { get; set; }

        [Description("性别")]
        public Sex Sex { get; set; }

        [Description("个性签名")]
        public string Signature { get; set; }

        [Description("生日")]
        public string BirthDay { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [Description("区")]
        public Region Region { get; set; }

        [Description("系统用户")]
        public virtual SysUser SysUser { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [Description("职位")]
        public virtual Position Position { get; set; }

        /// <summary>
        /// 毕业院校
        /// </summary>
        [Description("毕业院校")]
        public string School { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [Description("学历")]
        public virtual Education Education { get; set; }

        /// <summary>
        /// 登录凭据
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 标签集合
        /// </summary>
        public virtual ICollection<Label> Labels { get;set; }
    }

    public enum Sex
    {
        不限 = 0,
        男 = 1,
        女 = 2
    }
}
