using System;
using System.Text;
using Kamputing.DataParser.Business.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kamputing.DataParser.Business.UnitTest
{
    [TestClass]
    public class CsvListedReadParserUnitTest : IEmbeddedReadParserUnitTest
    {
        #region Constructor
        public CsvListedReadParserUnitTest() : base(new CsvEmbeddedReadParser()) { }
        #endregion

        #region CSV-specific data
        override internal string SampleParsedData
        {
            get
            {
                StringBuilder content = new StringBuilder();
                content.AppendLine("ClientId,PreferredName,Email,MatterId,DocumentId,FileName");
                content.AppendLine("1,Australian Native Landscapes Pty Ltd,accounts@anlscape.com.au,270033,1,C:\\Test\\7471.pdf");
                return content.ToString();
            }
        }
        #endregion

        [TestMethod]
        new public void CheckClientID()
        {
            base.CheckClientID();
        }
        [TestMethod]
        new public void CheckClientPreferredName()
        {
            base.CheckClientPreferredName();
        }
        [TestMethod]
        new public void CheckClientEmail()
        {
            base.CheckClientEmail();
        }
        [TestMethod]
        new public void CheckMatterID()
        {
            base.CheckMatterID();
        }
        [TestMethod]
        new public void CheckDocumentID()
        {
            base.CheckDocumentID();
        }
        [TestMethod]
        new public void CheckDocumentFileName()
        {
            base.CheckDocumentFileName();
        }

    }
}
