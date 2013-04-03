using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtor.Weixin
{
    public abstract class ResponseMessage : WeixinMessage
    {
        public ResponseMessage()
        {
            CreateTime = DateTime.Now;
        }
        public string ToXml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<xml>");
            sb.Append(string.Format("<ToUserName><![CDATA[{0}]]></ToUserName>", ToUserName));
            sb.Append(string.Format("<FromUserName><![CDATA[{0}]]></FromUserName>", FromUserName));
            sb.Append(string.Format("<CreateTime>{0}</CreateTime>", CreateTime.Ticks));
            sb.Append(string.Format("<MsgType><![CDATA[{0}]]></MsgType>", MsgType));
            sb.Append(ToPrivateXml());
            sb.Append("</xml>");
            return sb.ToString();
        }

        public abstract string ToPrivateXml();
    }
}
