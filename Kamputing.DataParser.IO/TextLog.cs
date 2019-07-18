using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kamputing.DataParser.IO
{
    public class TextLog : LogBase
    {
        private const string LOGFILEPATH = ".\\DataParserLog.txt";
        StreamWriter outputWriter;

        public TextLog()
        {
            FileInfo fi = new FileInfo(LOGFILEPATH);
            if (!Directory.Exists(fi.DirectoryName))
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }

            outputWriter = File.AppendText(LOGFILEPATH);
        }

        #region ILogger Implementation
        override public void Log(string message)
        {
            Console.WriteLine(AddDateTimeString(message));

        }
        #endregion

        private void WriteToFile(string message)
        {
            outputWriter.WriteLine(message);
        }
    }
}
