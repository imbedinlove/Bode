using Bode.Services.Core.Contracts;
using OSharp.Utility.Helper;
using System.Configuration;
using System.Net;
using OSharp.Utility.Data;
using System;
using Bode.Services.Implement.Helper;
using Winista.Text.HtmlParser.Lex;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Filters;
using Winista.Text.HtmlParser.Util;
using System.Text;

namespace Bode.Services.Implement.Services
{
    public partial class BugService : IBugContract
    {
        public OperationResult GetBugCount(string userName, string password)
        {
            var url = "http://pm.bodecn.com/user-login.html";
            var param = "account=qinchaoyue&password=imbed%40bod4&keepLogin%5B%5D=on&referer=http%3A%2F%2Fpm.bodecn.com%2Fmy-bug.html";
            ImbedLibrary.WebRequest webRequest = new ImbedLibrary.WebRequest();
            var html = webRequest.PostWebRequestEx(url, param, Encoding.UTF8, true);
            url = "http://pm.bodecn.com/my-bug.html";
            html = webRequest.GetWebRequest(url, Encoding.UTF8, false);
            ParserHtml(html);
            return BodeResult.Success();
        }

        public int ParserHtml(string html)
        {
            Lexer lexer = new Lexer(html);
            Parser parser = new Parser(lexer);
            NodeFilter filter = new NodeClassFilter(typeof(Winista.Text.HtmlParser.Tags.TableRow));
            NodeList htmlNode = parser.Parse(filter);
            return htmlNode.Count - 2;
        }
    }
}
