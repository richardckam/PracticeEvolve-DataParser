using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kamputing.DataParser.IO.UnitTest
{
    [TestClass]
    public class FileReaderUnitTest : IFileReaderUnitTest
    {
        #region Constructor
        public FileReaderUnitTest() : base(new FileReader()) { }
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
        new public void ReadFileContents()
        {
            base.ReadFileContents();
        }
    }
}
