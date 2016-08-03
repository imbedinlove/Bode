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
    public class DistrictController : BaseApiController
    {
        public IDeliveryContract DeliveryContract { get; set; }

        /// <summary>
        /// 获取省份
        /// </summary>
        /// <returns></returns>
        [Description("获取省份")]
        [HttpPost]
        public IHttpActionResult GetProvinces()
        {
            var result = DeliveryContract.Provinces.Select(m => new
            {
                m.Id,
                m.Name,
            }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }

        /// <summary>
        /// 根据省份获取市
        /// </summary>
        /// <param name="provinceId">省份</param>
        /// <returns></returns>
        [Description("根据省份获取市")]
        [HttpPost]
        public IHttpActionResult GetCitys(int provinceId)
        {
            var result = DeliveryContract.Citys.Where(m => m.Province.Id == provinceId).Select(m => new
            {
                m.Id,
                m.Name,
            }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }

        /// <summary>
        /// 根据市获取区
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        [Description("根据市获取区")]
        [HttpPost]
        public IHttpActionResult GetPositions(int cityId)
        {
            var result = DeliveryContract.Regions.Where(m => m.City.Id == cityId).Select(m => new
            {
                m.Id,
                m.Name
            }).ToList();
            return Json(BodeResult.Success(result).ToApiResult());
        }
    }
}
