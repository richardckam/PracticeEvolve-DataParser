using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.IO.UnitTest
{
    public abstract class IFileWriterUnitTest : UnitTestBase
    {
        private IFileWriter _writer;
        public IFileWriterUnitTest(IFileWriter writer)
        {
            _writer = writer;
        }
        public void TestSetValidFilePath()
        {
            EnsureTargetFileDoesNotExist();

            AssertExtension.DoesNotThrow<FileNotFoundException>(() => _writer.SetFilePath(TargetFilePath));
        }

        public void SetInvalidFilePath()
        {
            EnsureTargetFileExists();

            Assert.ThrowsException<FileAlreadyExistsException>(() => _writer.SetFilePath(TargetFilePath));
        }

        public void WriteFileContents()
        {
            EnsureTargetFileDoesNotExist();
            string message = "Newly created test content.";

            _writer.SetFilePath(TargetFilePath);
            _writer.WriteFileContents(message);

            string readMessage = System.IO.File.ReadAllText(TargetFilePath);

            Assert.AreEqual(message, readMessage);
        }
    }

}
