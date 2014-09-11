using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPageEventOrder
{
    public static class ReponseHelper
    {
        public static void WriteLine(this HttpResponse response, string content)
        {
            response.Write(content);
            response.Write("<br/>");
        }
    }
}