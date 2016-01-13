using Bode.Services.Core.Contracts;
using OSharp.Web.Http;
using OSharp.Web.Http.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Bode.Web.Areas.Api.Controllers
{
    public class BugController : BaseApiController
    {
        public IBugContract BugContract { get; set; }

        [HttpPost]
        public IHttpActionResult GetBugCount(string userName, string password)
        {
            return Json(BugContract.GetBugCount(userName, password).ToApiResult());
        }
    }
}