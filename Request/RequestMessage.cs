using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Web;
using System.IO;

namespace Newtor.Weixin
{
    public abstract class RequestMessage : WeixinMessage
    {
        public string RequestXml { get; set; }
        public static RequestMessage Load(string xml)
        {
            RequestMessage message = null;
            // 加载公共数据：
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList list = doc.GetElementsByTagName("xml");
            XmlNode xn = list[0];
            var msgType = xn.SelectSingleNode("//MsgType").InnerText;
            switch (msgType)
            {
                case "text":
                    message = new TextRequestMessage();
                    message.LoadPrivateMsg(xml);
                    break;
                default:
                    throw new Exception("未知微信请求类型");
            }
            message.RequestXml = xml;
            message.FromUserName = xn.SelectSingleNode("//FromUserName").InnerText;
            message.ToUserName = xn.SelectSingleNode("//ToUserName").InnerText;
            message.CreateTime = new DateTime(long.Parse(xn.SelectSingleNode("//CreateTime").InnerText));

            return message;
        }
        public static RequestMessage Load(HttpRequestBase request)
        {
            Stream s = request.InputStream;
            byte[] b = new byte[s.Length];
            s.Read(b, 0, (int)s.Length);
            return Load(Encoding.UTF8.GetString(b));
        }
        public abstract void LoadPrivateMsg(string xml);
    }
}
