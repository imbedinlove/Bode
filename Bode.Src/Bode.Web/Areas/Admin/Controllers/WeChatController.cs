using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Bode.Services.Core.Contracts;
using Bode.Web.Areas.Admin.ViewModes;
using OSharp.Core.Security;
using OSharp.Web.Mvc.Security;
using System.Threading.Tasks;
using System.Web.Security;
using OSharp.Utility.Data;
using OSharp.Web.Mvc.UI;
using System;
using OSharp.Utility.Helper;
using OSharp.Core.Data;
using OSharp.Web.Mvc.Initialize;

namespace Bode.Web.Areas.Admin.Controllers
{
    [Description("微信模块")]
    //[BodeMenuGroupKey("Admin.Home")]
    public class WeChatController : Controller
    {

        //[Authorize]
        //[BodeMenuGroupKey("mk222")]
        [Description("微信验证接口")]
        public ActionResult NotiflyUrl()
        {
            string token = "imbedinlove";
            if (string.IsNullOrEmpty(token))
            {
                return Content("");
            }

            string echoString = HttpContext.Request.QueryString["echoStr"];
            string signature = HttpContext.Request.QueryString["signature"];
            string timestamp = HttpContext.Request.QueryString["timestamp"];
            string nonce = HttpContext.Request.QueryString["nonce"];

            if (!string.IsNullOrEmpty(echoString))
            {
                HttpContext.Response.Write(echoString);
                HttpContext.Response.End();
            }
            return Content(echoString);
        }
    }
}