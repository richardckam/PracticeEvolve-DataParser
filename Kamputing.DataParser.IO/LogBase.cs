using System;
using System.Collections.Generic;
using System.Text;

namespace Kamputing.DataParser.IO
{
    public abstract class LogBase : ILogger
    {
        public abstract void Log(string message);
        internal static string AddDateTimeString(string message)
        {
            return GetCurrentDateTimeString() + " " + message;
        }
        internal static string GetCurrentDateTimeString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
