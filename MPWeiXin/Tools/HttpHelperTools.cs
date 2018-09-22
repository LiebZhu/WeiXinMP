using CsharpHttpHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPWeiXin.Tools
{
    class HttpHelperTools
    {
        public static HttpResult SendGet(string url)
        {
            HttpHelper httpHelper = new HttpHelper();
            HttpResult result = httpHelper.GetHtml(CreateDefalutItemGet(url));
            return result;
        }

        public static HttpItem CreateDefalutItemGet(string url)
        {
            return new HttpItem() { Allowautoredirect = true, AutoRedirectCookie = true, URL = url, Method = "GET", UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 11_0 like Mac OS X) AppleWebKit/604.1.38 (KHTML, like Gecko) Version/11.0 Mobile/15A372 Safari/604.1", Referer = url, Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8" };
        }
    }
}
