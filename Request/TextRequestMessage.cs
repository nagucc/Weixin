using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Newtor.Weixin
{
    public class TextRequestMessage: RequestMessage
    {
        public string Content { get; set; }

        public TextRequestMessage()
        {
            MsgType = "text";
        }

        public override void LoadPrivateMsg(string xml)
        {
            // 加载类型私有数据：
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList list = doc.GetElementsByTagName("xml");
            XmlNode xn = list[0];
            Content = xn.SelectSingleNode("//Content").InnerText;
        }
    }
}
