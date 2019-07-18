using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Kamputing.DataParser.Business;

namespace Kamputing.DataParser.IO
{
    public class FileWriter : IFileWriter
    {
        #region Private Variables
        private string _filePath;
        #endregion

        #region IFileWriter Implementation
        void IFileWriter.SetFilePath(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            if (!fi.Directory.Exists)
                throw new DirectoryNotFoundException(String.Format("The output directory ({0}) does not exist.", fi.DirectoryName));
            if (fi.Exists)
                throw new FileAlreadyExistsException(String.Format("An output file with the same name ({0}) already exists.", fi.Name));
            _filePath = filePath;
        }

        void IFileWriter.WriteFileContents(string contents)
        {
            File.WriteAllText(_filePath, contents);
        }
        #endregion
    }
}
