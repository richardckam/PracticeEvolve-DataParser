using Kamputing.DataParser.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamputing.DataParser.IO
{
    public interface IFileWriter
    {
        void SetFilePath(string filePath);
        void WriteFileContents(string contents);
    }
}
