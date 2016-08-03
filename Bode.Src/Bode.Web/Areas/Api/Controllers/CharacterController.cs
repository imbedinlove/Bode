using System.Web.Http;
using Bode.Services.Core.Contracts;
using OSharp.Web.Http.Messages;
using OSharp.Web.Http;
using System.ComponentModel;
using OSharp.Core.Data.Extensions;
using System.Linq;
using Bode.Services.Implement.Helper;
using OSharp.Web.Http.Authentication;

namespace Bode.Web.Areas.Api.Controllers
{
    [Description("角色")]
    public class CharacterController : BaseApiController
    {
        public ICharacterContract CharacterContract { get; set; }
        public IUserContract UserContract { get; set; }

        /// <summary>
        /// 获取标签
        /// </summary>
        /// <returns></returns>
        [Description("获取标签")]
        [HttpPost]
        public IHttpActionResult GetLabels()
        {
            var result = CharacterContract.Labels.OrderBy(m => m.OrderNo).Select(m => new { m.Id, m.Name }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }

        /// <summary>
        /// 是否有标签
        /// </summary>
        /// <returns></returns>
        [Description("是否有标签")]
        [HttpPost]
        [TokenAuth]
        public IHttpActionResult IsExistLabel()
        {
            var result = UserContract.UserInfos.Single(m => m.Id == OperatorId).Labels.Count();
            return Json((result == 0 ?  BodeResult.QueryNull("") : BodeResult.Success()).ToApiResult());
        }
    }
}
