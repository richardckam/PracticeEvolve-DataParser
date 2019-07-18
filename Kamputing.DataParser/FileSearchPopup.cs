using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamputing.DataParser
{
    public class FileSearchPopup
    {
        public static string SearchExistingFilePath(string currentFilePath)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.CheckFileExists = true;
            d.CheckPathExists = true;
            d.FileName = currentFilePath;
            if (d.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = d.FileName;
            }
            return currentFilePath;
        }

        public static string SearchNewFilePath(string currentFilePath)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.FileName = currentFilePath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = ofd.FileName;
            }
            return currentFilePath;
        }
    }
}
