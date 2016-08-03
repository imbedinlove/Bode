using System.Web.Http;
using Bode.Services.Core.Contracts;
using OSharp.Web.Http.Messages;
using OSharp.Web.Http;
using System.ComponentModel;
using OSharp.Core.Data.Extensions;
using System.Linq;
using Bode.Services.Implement.Helper;

namespace Bode.Web.Areas.Api.Controllers
{
    [Description("账户接口")]
    public class IndustryController : BaseApiController
    {
        public IIndustryContract IndustryContract { get; set; }

        /// <summary>
        /// 获取行业
        /// </summary>
        /// <returns></returns>
        [Description("获取行业")]
        [HttpPost]
        public IHttpActionResult GetTrades()
        {
            var result = IndustryContract.Trades.Select(m => new
            {
                m.Id,
                m.Name,
            }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }

        /// <summary>
        /// 根据行业获取职业
        /// </summary>
        /// <param name="tradeId">行业</param>
        /// <returns></returns>
        [Description("根据行业获取职业")]
        [HttpPost]
        public IHttpActionResult GetProfessions(int tradeId)
        {
            var result = IndustryContract.Professions.Where(m => m.Trade.Id == tradeId).Select(m => new
            {
                m.Id,
                m.Name,
            }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }

        /// <summary>
        /// 根据职业获取职位
        /// </summary>
        /// <param name="professionId"></param>
        /// <returns></returns>
        [Description("根据职业获取职位")]
        [HttpPost]
        public IHttpActionResult GetPositions(int professionId)
        {
            var result = IndustryContract.Positions.Where(m => m.Profession.Id == professionId).Select(m => new
            {
                m.Id,
                m.Name
            }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }

        /// <summary>
        /// 获取学历
        /// </summary>
        /// <returns></returns>
        [Description("获取学历")]
        [HttpPost]
        public IHttpActionResult GetEducations()
        {
            var result = IndustryContract.Educations.Select(m => new { m.Id, m.Name }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }
    }
}
