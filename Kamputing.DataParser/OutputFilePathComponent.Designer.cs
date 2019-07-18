namespace Kamputing.DataParser
{
    partial class OutputFilePathComponent
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
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFilePath.Location = new System.Drawing.Point(0, 1);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(268, 20);
            this.txtOutputFilePath.TabIndex = 0;
            this.txtOutputFilePath.TextChanged += new System.EventHandler(this.TxtOutputFilePath_TextChanged);
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSearch.Location = new System.Drawing.Point(270, 0);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(30, 22);
            this.btnFileSearch.TabIndex = 1;
            this.btnFileSearch.Text = "...";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.BtnFileSearch_Click);
            // 
            // OutputFilePathComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFileSearch);
            this.Controls.Add(this.txtOutputFilePath);
            this.Name = "OutputFilePathComponent";
            this.Size = new System.Drawing.Size(300, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.Button btnFileSearch;
    }
}
