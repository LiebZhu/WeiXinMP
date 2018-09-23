using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WeiXinMP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ContentResult Index()
        {
            byte[] bts = new byte[1024 * 1024 * 1];
            int pos = Request.InputStream.Read(bts, 0, (int)Request.InputStream.Length);
            string data = Encoding.UTF8.GetString(bts, 0, pos);
            if (pos > 0)
                return Content("<xml><ToUserName><![CDATA[o7PGE0sTN77Iz9-UQfwmGDn-YnSI]]></ToUserName><FromUserName><![CDATA[MiniNetTools]]></FromUserName><CreateTime>1537671502</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[你好]]></Content></xml>");

            return Content(Request["echostr"]);
        }
    }
}