using Kamputing.DataParser.Business;
using Kamputing.DataParser.Data;
using Kamputing.DataParser.IO;
using Kamputing.DataParser.Service;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Kamputing.DataParser
{
    public partial class FrmMain : Form
    {


        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            //MainProcessor.Process(inputFilePathSearch.InputFilePath, outputFilePathSearch.OutputFilePath);
        }
    }
}
