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
    public partial class InputFilePathComponent : UserControl
    {
        new public event EventHandler InputFilePathChanged;
        public string InputFilePath { get { return txtInputFilePath.Text; } set { txtInputFilePath.Text = value; } }
        public InputFilePathComponent()
        {
            InitializeComponent();
        }

        private void BtnFileSearch_Click(object sender, EventArgs e)
        {
            string newFilePath = FileSearchPopup.SearchExistingFilePath(InputFilePath);
            InputFilePath = newFilePath;
        }

        private void TxtInputFilePath_TextChanged(object sender, EventArgs e)
        {
            if (this.InputFilePathChanged != null)
                this.InputFilePathChanged(this, e);
        }
    }
}
