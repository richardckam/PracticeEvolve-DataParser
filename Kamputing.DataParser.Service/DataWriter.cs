using Kamputing.DataParser.Business;
using Kamputing.DataParser.Data;
using Kamputing.DataParser.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamputing.DataParser.Service
{
    public class DataWriter
    {
        public void WriteData(IFileWriter writer, IWriteParser parser, DataSet data, string outputFileLocation)
        {
            string parsedData = parser.ParseContent(data);

            writer.SetFilePath(outputFileLocation);
            writer.WriteFileContents(parsedData);
        }
    }
}
