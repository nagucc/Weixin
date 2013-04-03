using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtor.Weixin
{
    public class ArticleItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PicUrl { get; set; }
        public string Url { get; set; }

        public string ToXml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<item>");
            sb.Append(string.Format("<Title><![CDATA[{0}]]></Title>", Title));
            sb.Append(string.Format("<Description><![CDATA[{0}]]></Description>", Description));
            sb.Append(string.Format("<PicUrl><![CDATA[{0}]]></PicUrl>", PicUrl));
            sb.Append(string.Format("<Url><![CDATA[{0}]]></Url>", Url));
            sb.Append("</item>");
            return sb.ToString();
        }
    }
}
