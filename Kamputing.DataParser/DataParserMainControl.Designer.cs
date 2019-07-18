namespace Kamputing.DataParser
{
    partial class DataParserMainControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputFile = new System.Windows.Forms.Label();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.outputFilePathSearch = new Kamputing.DataParser.OutputFilePathComponent();
            this.inputFilePathSearch = new Kamputing.DataParser.InputFilePathComponent();
            this.lblBtnProcessDisabled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Location = new System.Drawing.Point(3, 0);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(55, 26);
            this.lblInputFile.TabIndex = 0;
            this.lblInputFile.Text = "Input CSV\r\nFile Path";
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Location = new System.Drawing.Point(3, 29);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(64, 26);
            this.lblOutputFile.TabIndex = 1;
            this.lblOutputFile.Text = "Output XML\r\nFile Path";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(73, 61);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Convert Data";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // outputFilePathSearch
            // 
            this.outputFilePathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFilePathSearch.Location = new System.Drawing.Point(73, 32);
            this.outputFilePathSearch.Name = "outputFilePathSearch";
            this.outputFilePathSearch.OutputFilePath = "";
            this.outputFilePathSearch.Size = new System.Drawing.Size(301, 23);
            this.outputFilePathSearch.TabIndex = 3;
            // 
            // inputFilePathSearch
            // 
            this.inputFilePathSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFilePathSearch.InputFilePath = "";
            this.inputFilePathSearch.Location = new System.Drawing.Point(73, 3);
            this.inputFilePathSearch.Name = "inputFilePathSearch";
            this.inputFilePathSearch.Size = new System.Drawing.Size(301, 23);
            this.inputFilePathSearch.TabIndex = 2;
            // 
            // lblBtnProcessDisabled
            // 
            this.lblBtnProcessDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBtnProcessDisabled.ForeColor = System.Drawing.Color.Red;
            this.lblBtnProcessDisabled.Location = new System.Drawing.Point(155, 61);
            this.lblBtnProcessDisabled.Name = "lblBtnProcessDisabled";
            this.lblBtnProcessDisabled.Size = new System.Drawing.Size(217, 59);
            this.lblBtnProcessDisabled.TabIndex = 5;
            this.lblBtnProcessDisabled.Text = "The Convert button will be enabled when:\r\n(1) the Input File exists;\r\n(2) the Out" +
    "put Folder exists; and \r\n(3) the Input File does NOT exist.";
            // 
            // DataParserMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBtnProcessDisabled);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.outputFilePathSearch);
            this.Controls.Add(this.inputFilePathSearch);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.lblInputFile);
            this.MinimumSize = new System.Drawing.Size(0, 120);
            this.Name = "DataParserMainControl";
            this.Size = new System.Drawing.Size(375, 120);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.Label lblOutputFile;
        private InputFilePathComponent inputFilePathSearch;
        private OutputFilePathComponent outputFilePathSearch;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblBtnProcessDisabled;
    }
}
