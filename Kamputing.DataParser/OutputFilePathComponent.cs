using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kamputing.DataParser
{
    public partial class OutputFilePathComponent : UserControl
    {
        public event EventHandler OutputFilePathChanged;

        public string OutputFilePath { get { return txtOutputFilePath.Text; } set { txtOutputFilePath.Text = value; } }
        public OutputFilePathComponent()
        {
            InitializeComponent();
        }

        private void BtnFileSearch_Click(object sender, EventArgs e)
        {
            string newFilePath = FileSearchPopup.SearchNewFilePath(OutputFilePath);
            OutputFilePath = newFilePath;
        }

        private void TxtOutputFilePath_TextChanged(object sender, EventArgs e)
        {
            if (this.OutputFilePathChanged != null)
                this.OutputFilePathChanged(this, e);
        }
    }
}
