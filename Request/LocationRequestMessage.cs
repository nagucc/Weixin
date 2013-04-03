using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtor.Weixin
{
    public class LocationRequestMessage : RequestMessage
    {
        public LocationRequestMessage()
        {
            MsgType = "location";
        }

        public override void LoadPrivateMsg(string xml)
        {
            throw new NotImplementedException();
        }
    }
}
