using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kamputing.DataParser.IO.UnitTest
{
    public abstract class IFileReaderUnitTest : UnitTestBase
    {
        private IFileReader _reader;
        public IFileReaderUnitTest(IFileReader reader)
        {
            _reader = reader;
        }
        public void TestSetValidFilePath()
        {
            EnsureTargetFileExists();
            AssertExtension.DoesNotThrow<FileNotFoundException>(() => _reader.SetFilePath(TargetFilePath));
        }

        public void SetInvalidFilePath()
        {
            EnsureNonExistantFileDoesNotExist();
            
            Assert.ThrowsException<FileNotFoundException>(() => _reader.SetFilePath(NonExistantFilePath));
        }

        public void ReadFileContents()
        {
            EnsureTargetFileExists();
            _reader.SetFilePath(SourceFilePath);
            string targetContents = _reader.ReadFileContents();

            Assert.AreEqual("Test content", targetContents);
        }
    }
}
