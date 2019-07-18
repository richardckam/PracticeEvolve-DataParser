using Kamputing.DataParser.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.Business.UnitTest
{
    public abstract class IWriteParserUnitTest
    {
        private IWriteParser _parser;
        public IWriteParserUnitTest(IWriteParser parser)
        {
            _parser = parser;
        }
        internal abstract string ExpectedOutput { get; }
        private DataSet SampleUnparsedData
        {
            get
            {
                DocumentObject document = new DocumentObject(1);
                document.FileName = "C:\\Test\\7471.pdf";

                MatterObject matter = new MatterObject(270033);
                matter.Documents.Add(document);

                ClientObject client = new ClientObject(1);
                client.PreferredName = "Australian Native Landscapes Pty Ltd";
                client.Email = "accounts@anlscape.com.au";
                client.Matters.Add(matter);

                ClientCollection clients = new ClientCollection();
                clients.Add(client);

                DataSet output = new DataSet() { Clients = clients };

                return output;
            }
        }

        public void CheckParsedData()
        {
            string output = _parser.ParseContent(SampleUnparsedData);

            Assert.AreEqual(ExpectedOutput, output);
        }
    }
}
