using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamputing.DataParser.IO.UnitTest
{
    public class UnitTestBase
    {
        private const string sourceDirectory = ".\\";
        private const string targetDirectory = "C:\\UnitTest\\";
        private const string testFileName = "SampleInput.csv";
        private const string nonExistantFileName = "there is no way that there could be a file name like this.txt";
        public string SourceFilePath { get { return sourceDirectoryFullPath + testFileName; } }
        public string TargetFilePath { get { return targetDirectory + testFileName; } }
        public string NonExistantFilePath { get { return targetDirectory + nonExistantFileName; } }
        public string sourceDirectoryFullPath
        {
            get
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(sourceDirectory);
                return di.FullName;
            }
        }

        public void EnsureTargetFileExists()
        {
            if (!System.IO.Directory.Exists(targetDirectory))
            {
                System.IO.Directory.CreateDirectory(targetDirectory);
            }
            if (!System.IO.File.Exists(TargetFilePath))
                System.IO.File.Copy(SourceFilePath, TargetFilePath);
        }

        public void EnsureTargetFileDoesNotExist()
        {
            if (!System.IO.Directory.Exists(targetDirectory))
            {
                System.IO.Directory.CreateDirectory(targetDirectory);
            }
            if (System.IO.File.Exists(TargetFilePath))
                System.IO.File.Delete(TargetFilePath);
        }

        public void EnsureNonExistantFileDoesNotExist()
        {
            //if (!System.IO.Directory.Exists(targetDirectory))
            //{
            //    System.IO.Directory.CreateDirectory(targetDirectory);
            //}
            if (System.IO.File.Exists(NonExistantFilePath))
                System.IO.File.Delete(NonExistantFilePath);
        }
    }
}
