using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MPWeiXin.Tools
{
    class JsonTools
    {
        public static T GetIdValue<T>(string source, string JsonCol)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            dynamic modelDy = jss.Deserialize<dynamic>(source);
            return modelDy[JsonCol];
        }
    }
}
