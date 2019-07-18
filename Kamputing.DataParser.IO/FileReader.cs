using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Kamputing.DataParser.Business;

namespace Kamputing.DataParser.IO
{
    public class FileReader : IFileReader
    {
        #region Private Variables
        private string _filePath;
        #endregion

        #region IFileReader Implementation
        void IFileReader.SetFilePath(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(String.Format("The input file {0} does not exist.", filePath));
            _filePath = filePath;
        }

        string IFileReader.ReadFileContents()
        {
            return File.ReadAllText(_filePath);
        }
        #endregion
    }

    public class FileAlreadyExistsException : Exception
    {
        public FileAlreadyExistsException() : base() { }
        public FileAlreadyExistsException(string message) : base(message) { }
        public FileAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }

        protected FileAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
