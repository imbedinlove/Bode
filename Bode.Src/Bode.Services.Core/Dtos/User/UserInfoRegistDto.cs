using System;
using Bode.Services.Core.Models.User;
using OSharp.Core.Data;

namespace Bode.Services.Core.Dtos.User
{
    public class UserInfoRegistDto : IAddDto
    {
        public int Id { get; set; }
        /// <summary>
        /// 登录帐号  手机号码
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNo { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPic { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public int PositionId { get; set; }

        /// <summary>
        /// 教育
        /// </summary>
        public int EducationId { get; set; }

        /// <summary>
        /// 毕业学校名称
        /// </summary>
        public string School { get; set; } 
    }
}
