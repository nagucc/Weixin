using System;
namespace Newtor.Weixin
{
    public abstract class WeixinMessage
    {
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public DateTime CreateTime { get; set; }
        public string MsgType { get; protected set; }
    }
}
