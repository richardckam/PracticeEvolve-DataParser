using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.IO.UnitTest
{
    [TestClass]
    public class FileWriterUnitTest : IFileWriterUnitTest
    {
        #region Constructor
        public FileWriterUnitTest() : base(new FileWriter()) { }
        #endregion

        [TestMethod]
        new public void TestSetValidFilePath()
        {
            base.TestSetValidFilePath();
        }

        [TestMethod]
        new public void SetInvalidFilePath()
        {
            base.SetInvalidFilePath();
        }

        [TestMethod]
        new public void WriteFileContents()
        {
            base.WriteFileContents();
        }
    }
}
