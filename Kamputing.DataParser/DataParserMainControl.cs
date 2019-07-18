using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kamputing.DataParser
{
    public partial class DataParserMainControl : UserControl
    {
        public DataParserMainControl()
        {
            InitializeComponent();
            inputFilePathSearch.InputFilePathChanged += InputFilePathSearch_InputFilePathChanged;
            outputFilePathSearch.OutputFilePathChanged += OutputFilePathSearch_OutputFilePathChanged;

            UpdateProcessButtonEnblement();
        }

        private bool isValidInputFilePath()
        {
            if (string.IsNullOrWhiteSpace(inputFilePathSearch.InputFilePath))
                return false;

            FileInfo fi = new FileInfo(inputFilePathSearch.InputFilePath);
            return fi.Exists;
        }

        private bool isValidOutputFilePath()
        {
            if (string.IsNullOrWhiteSpace(outputFilePathSearch.OutputFilePath))
                return false;

            FileInfo fi = new FileInfo(outputFilePathSearch.OutputFilePath);
            return Directory.Exists(fi.DirectoryName) && !fi.Exists;
        }

        private void UpdateProcessButtonEnblement()
        {
            bool canProcess = isValidInputFilePath() && isValidOutputFilePath();
            btnProcess.Enabled = canProcess;
            lblBtnProcessDisabled.Visible = !canProcess;
        }

        private void InputFilePathSearch_InputFilePathChanged(object sender, EventArgs e)
        {
            UpdateProcessButtonEnblement();
        }

        private void OutputFilePathSearch_OutputFilePathChanged(object sender, EventArgs e)
        {
            UpdateProcessButtonEnblement();
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            CsvToXmlProcessor.ProcessData(inputFilePathSearch.InputFilePath, outputFilePathSearch.OutputFilePath);
        }
    }
}
