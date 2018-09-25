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
        private string hostWeb = "http://i5rxrs.natappfree.cc";
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
            string msg = "小傻子~😘\r\n\r\n";
            msg += helloMsg() + "\r\n";
            msg += "\r\n哇哦~这是与小傻子共度的" + (int)(DateTime.Now - DateTime.Parse("2018-2-21")).TotalDays + "天😍\r\n";
            msg += "\r\n近期纪念日：10月4小傻子的生日🎂\r\n";
            msg += "\r\n按摩比例：88:15😃\r\n";
            msg += "\r\n今日运势：处女座工作中有些障碍，挫折感顿生，令你有点心力交瘁，需费尽心思来解决(提示~10个按摩就能解咒啦😜)\r\n";
            msg += "\r\n你想做什么❓\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>1.个人中心🏠</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>2.按摩增加❤️</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>3.大事记📅</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>4.纪念日☁️</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>5.每日抽奖⭐</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>6.统计⌛</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>7.神秘功能🐖</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>8.神秘功能🐷</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>9.神秘功能🐈</a>\r\n";
            msg += "\r\n<a href='" + hostWeb + "/Family/Index'>10.神秘功能🐱</a>\r\n";
            msg += "\r\n其他还在完善哦~哇哦?\r\n";
            msg += "\r\n☹️☹️☹️☹️我需要按摩~\r\n";


            SendMeassagePassive.ReplyText(msg, nmTextParameter);

            //SendMeassagePassive.ReplyImage("sJVBJ5VyqazbQj4eoz_rOWL6fpmIGBud8bYIPaqmObzfPxpQC99XpDvCgyTu7FBj", nmTextParameter);
        }

        private string helloMsg()
        {
            string msg = "";
            int hour = DateTime.Now.Hour;
            if (hour >= 1 && hour <= 6)
            {
                msg = "凌晨了！快睡觉！";
            }
            else if (hour >= 6 && hour <= 10)
            {
                msg = "早上好~抱抱~";
            }
            else if (hour >= 10 && hour <= 14)
            {
                msg = "中午好~你又在吃独食~";
            }
            else if (hour >= 14 && hour <= 16)
            {
                msg = "下午好~你该睡觉了~";
            }
            else
            {
                msg = "晚上好~还在吃独食吗~你该睡觉了~";
            }

            return msg;
        }

        private void Main_OnEUnsubscribe(MPWeiXin.Model.EventModel.EUnsubscribeParameter eUnsubscribeParameter)
        {

        }

        private void Main_OnESubscribe(MPWeiXin.Model.EventModel.ESubscribeParameter eSubscribeParameter)
        {
            SendMeassagePassive.ReplyText("小傻子~😘~你来啦~", eSubscribeParameter);
        }

        private void Main_OnXMLReceived1(MPResult mPResult, MPWeiXin.Model.EventModel.BaseParameter baseParameter)
        {
        }
    }
}
