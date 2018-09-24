using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MPWeiXin.Model;
using MPWeiXin;

namespace WeiXinMP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            MPWeiXin.Main.OnXMLReceived += Main_OnXMLReceived1;
            MPWeiXin.Main.OnESubscribe += Main_OnESubscribe;
            MPWeiXin.Main.OnEUnsubscribe += Main_OnEUnsubscribe;
            MPWeiXin.Main.OnNmText += Main_OnNmText;
        }

        private void Main_OnNmText(MPWeiXin.Model.EventModel.NmTextParameter nmTextParameter)
        {
            //SendMeassagePassive.ReplyText("回复了你", nmTextParameter);
            SendMeassagePassive.ReplyImage("sJVBJ5VyqazbQj4eoz_rOWL6fpmIGBud8bYIPaqmObzfPxpQC99XpDvCgyTu7FBj", nmTextParameter);
        }

        private void Main_OnEUnsubscribe(MPWeiXin.Model.EventModel.EUnsubscribeParameter eUnsubscribeParameter)
        {

        }

        private void Main_OnESubscribe(MPWeiXin.Model.EventModel.ESubscribeParameter eSubscribeParameter)
        {
            SendMeassagePassive.ReplyText("欢迎关注", eSubscribeParameter);
        }

        private void Main_OnXMLReceived1(MPResult mPResult, MPWeiXin.Model.EventModel.BaseParameter baseParameter)
        {
        }
    }
}
