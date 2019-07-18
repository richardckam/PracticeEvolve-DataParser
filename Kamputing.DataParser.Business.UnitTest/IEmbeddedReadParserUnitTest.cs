using Kamputing.DataParser.Data;
using Kamputing.DataParser.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.Business.UnitTest
{
    public abstract class IEmbeddedReadParserUnitTest
    {
        private IReadParser _parser;

        internal abstract string SampleParsedData { get; }

        public IEmbeddedReadParserUnitTest(IReadParser parser)
        {
            _parser = parser;
        }
        private DataSet GetUnparsedData(string content)
        {
            return _parser.UnparseContent(content);
        }

        public void CheckClientID()
        {
            ClientObject client = GetUnparsedData(SampleParsedData).Clients.First();

            Assert.AreEqual(1, client.ClientID);
        }

        public void CheckClientPreferredName()
        {
            ClientObject client = GetUnparsedData(SampleParsedData).Clients.First();

            Assert.AreEqual("Australian Native Landscapes Pty Ltd", client.PreferredName);
        }

        public void CheckClientEmail()
        {
            ClientObject client = GetUnparsedData(SampleParsedData).Clients.First();

            Assert.AreEqual("accounts@anlscape.com.au", client.Email);
        }

        public void CheckMatterID()
        {
            ClientObject client = GetUnparsedData(SampleParsedData).Clients.First();
            MatterObject matter = client.Matters.First();

            Assert.AreEqual(270033, matter.MatterID);
        }

        public void CheckDocumentID()
        {
            ClientObject client = GetUnparsedData(SampleParsedData).Clients.First();
            MatterObject matter = client.Matters.First();
            DocumentObject document = matter.Documents.First();

            Assert.AreEqual(1, document.DocumentID);
        }

        public void CheckDocumentFileName()
        {
            ClientObject client = GetUnparsedData(SampleParsedData).Clients.First();
            MatterObject matter = client.Matters.First();
            DocumentObject document = matter.Documents.First();

            Assert.AreEqual("C:\\Test\\7471.pdf", document.FileName);
        }
    }
}
