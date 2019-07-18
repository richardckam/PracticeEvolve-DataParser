namespace Kamputing.DataParser
{
    partial class InputFilePathComponent
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
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputFilePath.Location = new System.Drawing.Point(0, 1);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(268, 20);
            this.txtInputFilePath.TabIndex = 0;
            this.txtInputFilePath.TextChanged += new System.EventHandler(this.TxtInputFilePath_TextChanged);
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
            // InputFilePathComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFileSearch);
            this.Controls.Add(this.txtInputFilePath);
            this.Name = "InputFilePathComponent";
            this.Size = new System.Drawing.Size(300, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Button btnFileSearch;
    }
}
