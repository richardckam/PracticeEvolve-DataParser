using System;
using System.Collections.Generic;
using System.Text;

namespace Kamputing.DataParser.IO
{
    public class ConsoleLog : LogBase
    {
        #region ILogger Implementation
        public override void Log(string message)
        {
            Console.WriteLine(AddDateTimeString(message));

        }
        #endregion
    }
}
