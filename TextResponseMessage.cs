using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtor.Weixin
{
    public class TextResponseMessage : ResponseMessage
    {
        public string Content { get; set; }
        public TextResponseMessage():base()
        {
            MsgType = "text";
        }
        public override string ToPrivateXml()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("<Content><![CDATA[{0}]]></Content>", Content));
            sb.Append("<FuncFlag>0</FuncFlag>");
            return sb.ToString();
        }
    }
}
