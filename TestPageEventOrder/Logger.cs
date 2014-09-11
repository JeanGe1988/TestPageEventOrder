using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TestPageEventOrder
{
    public static class Logger
    {
        static string staticPath = @"f:\log.txt";

        public static void LogToStaticFile(string content)
        {
            File.AppendAllText(staticPath, content + "\r\n");
        }
    }
}