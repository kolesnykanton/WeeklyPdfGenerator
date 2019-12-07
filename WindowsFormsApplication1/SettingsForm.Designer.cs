namespace WindowsFormsApplication1
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrtPathLabel = new System.Windows.Forms.Label();
            this.reportDirPathLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathXmlLabel = new System.Windows.Forms.Label();
            this.mailTestBtn = new System.Windows.Forms.Button();
            this.xmlPathTxtBox = new System.Windows.Forms.TextBox();
            this.reportDirPath = new System.Windows.Forms.TextBox();
            this.mrtFilePath = new System.Windows.Forms.TextBox();
            this.btn_browse_mrt = new System.Windows.Forms.Button();
            this.op_diag_mrt = new System.Windows.Forms.OpenFileDialog();
            this.btn_browse_repo_dir = new System.Windows.Forms.Button();
            this.btn_browse_xml = new System.Windows.Forms.Button();
            this.op_diag_xml = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // mrtPathLabel
            // 
            this.mrtPathLabel.AutoSize = true;
            this.mrtPathLabel.Location = new System.Drawing.Point(32, 62);
            this.mrtPathLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.mrtPathLabel.Name = "mrtPathLabel";
            this.mrtPathLabel.Size = new System.Drawing.Size(235, 32);
            this.mrtPathLabel.TabIndex = 1;
            this.mrtPathLabel.Text = "Path To MRT File";
            // 
            // reportDirPathLabel
            // 
            this.reportDirPathLabel.AutoSize = true;
            this.reportDirPathLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportDirPathLabel.Location = new System.Drawing.Point(32, 154);
            this.reportDirPathLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.reportDirPathLabel.Name = "reportDirPathLabel";
            this.reportDirPathLabel.Size = new System.Drawing.Size(249, 32);
            this.reportDirPathLabel.TabIndex = 3;
            this.reportDirPathLabel.Text = "Path To Report Dir";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(32, 589);
            this.applyButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(296, 76);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 5;
            // 
            // pathXmlLabel
            // 
            this.pathXmlLabel.AutoSize = true;
            this.pathXmlLabel.Location = new System.Drawing.Point(32, 237);
            this.pathXmlLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pathXmlLabel.Name = "pathXmlLabel";
            this.pathXmlLabel.Size = new System.Drawing.Size(224, 32);
            this.pathXmlLabel.TabIndex = 7;
            this.pathXmlLabel.Text = "Path To Xml File";
            // 
            // mailTestBtn
            // 
            this.mailTestBtn.Location = new System.Drawing.Point(429, 589);
            this.mailTestBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mailTestBtn.Name = "mailTestBtn";
            this.mailTestBtn.Size = new System.Drawing.Size(243, 76);
            this.mailTestBtn.TabIndex = 9;
            this.mailTestBtn.Text = "Mail Settings";
            this.mailTestBtn.UseVisualStyleBackColor = true;
            this.mailTestBtn.Click += new System.EventHandler(this.mailTestBtn_Click);
            // 
            // xmlPathTxtBox
            // 
            this.xmlPathTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "XmlPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xmlPathTxtBox.Location = new System.Drawing.Point(291, 231);
            this.xmlPathTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.xmlPathTxtBox.Name = "xmlPathTxtBox";
            this.xmlPathTxtBox.Size = new System.Drawing.Size(356, 38);
            this.xmlPathTxtBox.TabIndex = 8;
            this.xmlPathTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.XmlPath;
            // 
            // reportDirPath
            // 
            this.reportDirPath.BackColor = System.Drawing.SystemColors.Window;
            this.reportDirPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "reportDirPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reportDirPath.Location = new System.Drawing.Point(291, 148);
            this.reportDirPath.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.reportDirPath.Name = "reportDirPath";
            this.reportDirPath.Size = new System.Drawing.Size(356, 38);
            this.reportDirPath.TabIndex = 2;
            this.reportDirPath.Text = global::weekly_namespace.Properties.Settings.Default.reportDirPath;
            this.reportDirPath.TextChanged += new System.EventHandler(this.reportDirPath_TextChanged);
            // 
            // mrtFilePath
            // 
            this.mrtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.mrtFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mrtPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mrtFilePath.Location = new System.Drawing.Point(291, 55);
            this.mrtFilePath.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mrtFilePath.Name = "mrtFilePath";
            this.mrtFilePath.Size = new System.Drawing.Size(356, 38);
            this.mrtFilePath.TabIndex = 0;
            this.mrtFilePath.Text = global::weekly_namespace.Properties.Settings.Default.mrtPath;
            this.mrtFilePath.TextChanged += new System.EventHandler(this.mrtFilePath_TextChanged);
            // 
            // btn_browse_mrt
            // 
            this.btn_browse_mrt.Location = new System.Drawing.Point(658, 48);
            this.btn_browse_mrt.Name = "btn_browse_mrt";
            this.btn_browse_mrt.Size = new System.Drawing.Size(130, 46);
            this.btn_browse_mrt.TabIndex = 10;
            this.btn_browse_mrt.Text = "browse";
            this.btn_browse_mrt.UseVisualStyleBackColor = true;
            this.btn_browse_mrt.Click += new System.EventHandler(this.button1_Click);
            // 
            // op_diag_mrt
            // 
            this.op_diag_mrt.DefaultExt = "*.mrt";
            // 
            // btn_browse_repo_dir
            // 
            this.btn_browse_repo_dir.Location = new System.Drawing.Point(658, 144);
            this.btn_browse_repo_dir.Name = "btn_browse_repo_dir";
            this.btn_browse_repo_dir.Size = new System.Drawing.Size(130, 46);
            this.btn_browse_repo_dir.TabIndex = 11;
            this.btn_browse_repo_dir.Text = "browse";
            this.btn_browse_repo_dir.UseVisualStyleBackColor = true;
            this.btn_browse_repo_dir.Click += new System.EventHandler(this.btn_browse_repo_dir_Click);
            // 
            // btn_browse_xml
            // 
            this.btn_browse_xml.Location = new System.Drawing.Point(658, 226);
            this.btn_browse_xml.Name = "btn_browse_xml";
            this.btn_browse_xml.Size = new System.Drawing.Size(130, 46);
            this.btn_browse_xml.TabIndex = 12;
            this.btn_browse_xml.Text = "browse";
            this.btn_browse_xml.UseVisualStyleBackColor = true;
            this.btn_browse_xml.Click += new System.EventHandler(this.btn_browse_xml_Click);
            // 
            // op_diag_xml
            // 
            this.op_diag_xml.DefaultExt = "*.xml";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 957);
            this.Controls.Add(this.btn_browse_xml);
            this.Controls.Add(this.btn_browse_repo_dir);
            this.Controls.Add(this.btn_browse_mrt);
            this.Controls.Add(this.mailTestBtn);
            this.Controls.Add(this.xmlPathTxtBox);
            this.Controls.Add(this.pathXmlLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.reportDirPathLabel);
            this.Controls.Add(this.reportDirPath);
            this.Controls.Add(this.mrtPathLabel);
            this.Controls.Add(this.mrtFilePath);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mrtPathLabel;
        private System.Windows.Forms.Label reportDirPathLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pathXmlLabel;
        public System.Windows.Forms.TextBox xmlPathTxtBox;
        public System.Windows.Forms.TextBox mrtFilePath;
        public System.Windows.Forms.TextBox reportDirPath;
        private System.Windows.Forms.Button mailTestBtn;
        private System.Windows.Forms.Button btn_browse_mrt;
        private System.Windows.Forms.OpenFileDialog op_diag_mrt;
        private System.Windows.Forms.Button btn_browse_repo_dir;
        private System.Windows.Forms.Button btn_browse_xml;
        private System.Windows.Forms.OpenFileDialog op_diag_xml;
    }
}