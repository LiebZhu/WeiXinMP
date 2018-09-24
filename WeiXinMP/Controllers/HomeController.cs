using MPWeiXin;
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
            Main.HandleEvent();
            if (Main.HasXMLData)
            {
                return Content("");
            }
            return Content(Request["echostr"]);
        }


    }
}