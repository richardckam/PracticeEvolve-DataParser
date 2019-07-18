using Kamputing.DataParser.Business;
using Kamputing.DataParser.Data;
using Kamputing.DataParser.IO;
using System;

namespace Kamputing.DataParser.Service
{
    public class DataReader
    {
        public DataSet ReadData(IFileReader reader, IReadParser parser, string inputFileLocation)
        {
            reader.SetFilePath(inputFileLocation);
            string rawData = reader.ReadFileContents();

            DataSet output = parser.UnparseContent(rawData);

            return output;
        }
    }
}
