using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication0419Home
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<string> GetData(string prefixText)
        {
            List<string> data = new List<string>();
            data.Add("abr,wuxi,1@qq,2");
            data.Add("abc,shanghai,2@cc,3");
            data.Add("abraham,beijing,5@qi,6");
            data.Add("ab,wuxi,3@qq,9");
            data.Add("d,shenzhen,2@qq,5");
            data.Add("ad,shanghai,4@qy,5");
            data.Add("adc,beijing,5@yy,6");
            data.Add("ap,shanghai,7@yy,8");
            data.Add("apc,wuxi,5@yy,9");
            data.Add("fa,wuxi,5@qq,9");
            data.Add("fat,shagnhai,2@qq,8");
            return data.Where(p => p.StartsWith(prefixText)).ToList();
        }

    }
}
