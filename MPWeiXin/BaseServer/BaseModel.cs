using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPWeiXin.BaseServer
{
    class BaseModel
    {
        private static string _appid;
        private static string _secret;
        public static string appid
        {
            get
            {
                if (string.IsNullOrEmpty(_appid))
                    _appid = System.Configuration.ConfigurationManager.AppSettings["appid"];
                return _appid;
            }
        }
        public static string secret
        {
            get
            {
                if (string.IsNullOrEmpty(_secret))
                    _secret = System.Configuration.ConfigurationManager.AppSettings["secret"];

                return _secret;
            }
        }
    }
}
