using Kamputing.DataParser.Business;
using Kamputing.DataParser.Data;
using Kamputing.DataParser.IO;
using Kamputing.DataParser.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser
{
    public class CsvToXmlProcessor
    {
        public static void ProcessData(string inputFilePath, string outputFilePath)
        {
            DataReader dataReader = new DataReader();
            IFileReader reader = new FileReader();
            IReadParser readParser;

            readParser = new CsvListedReadParser();
            //// This will parse the data in a relational format instead
            readParser = new CsvEmbeddedReadParser();

            DataSet data = dataReader.ReadData(reader, readParser, inputFilePath);

            DataWriter dataWriter = new DataWriter();
            IFileWriter writer = new FileWriter();
            IWriteParser writeParser = new XmlUtf8WriteParser();
            dataWriter.WriteData(writer, writeParser, data, outputFilePath);

            Process.Start(outputFilePath);
        }
    }
}
