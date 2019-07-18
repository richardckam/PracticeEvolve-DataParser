using Kamputing.DataParser.Business;
using Kamputing.DataParser.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.Business.UnitTest
{
    [TestClass]
    public class XmlUtf8WriteParserUnitTest : IWriteParserUnitTest
    {
        #region Constructor
        public XmlUtf8WriteParserUnitTest() : base(new XmlUtf8WriteParser()) { }
        #endregion

        #region XML-specific data
        override internal string ExpectedOutput
        {
            get
            {
                StringBuilder expectedOutput = new StringBuilder();
                expectedOutput.AppendLine("ï»¿<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                expectedOutput.AppendLine("<DataSet>");
                expectedOutput.AppendLine("  <Clients>");
                expectedOutput.AppendLine("    <Client ClientID=\"1\" PreferredName=\"Australian Native Landscapes Pty Ltd\" Email=\"accounts@anlscape.com.au\">");
                expectedOutput.AppendLine("      <Matters>");
                expectedOutput.AppendLine("        <Matter MatterID=\"270033\">");
                expectedOutput.AppendLine("          <Documents>");
                expectedOutput.AppendLine("            <Document DocumentID=\"1\" FileName=\"C:\\Test\\7471.pdf\" />");
                expectedOutput.AppendLine("          </Documents>");
                expectedOutput.AppendLine("        </Matter>");
                expectedOutput.AppendLine("      </Matters>");
                expectedOutput.AppendLine("    </Client>");
                expectedOutput.AppendLine("  </Clients>");
                expectedOutput.Append("</DataSet>");
                return expectedOutput.ToString();
            }
        }
        #endregion

        [TestMethod]
        new public void CheckParsedData()
        {
            base.CheckParsedData();
        }
    }
}
