using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.Channels
{
    public class PdfChannel :DisplayChannel
    {
        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.QueryString["pdf"] == 1.ToString();
        }

        public override string ChannelName
        {
            get { return "PDF"; }
        }
    }
}