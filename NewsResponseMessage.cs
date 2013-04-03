using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtor.Weixin
{
    public class NewsResponseMessage : ResponseMessage
    {
        public List<ArticleItem> Articles { get; set; }

        public NewsResponseMessage():base()
        {
            MsgType = "news";
            Articles = new List<ArticleItem>();
        }
        public override string ToPrivateXml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Content><![CDATA[]]></Content>");
            sb.Append(string.Format("<ArticleCount>{0}</ArticleCount>", Articles.Count));
            sb.Append("<Articles>");
            foreach (var item in Articles)
            {
                sb.Append(item.ToXml());
            }
            sb.Append("</Articles>");
            sb.Append("<FuncFlag>1</FuncFlag>");
            return sb.ToString();
        }
    }
}