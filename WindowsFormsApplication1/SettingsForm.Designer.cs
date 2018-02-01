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
            this.mrtFilePath = new System.Windows.Forms.TextBox();
            this.mrtPathLabel = new System.Windows.Forms.Label();
            this.reportDirPathLabel = new System.Windows.Forms.Label();
            this.reportDirPath = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathXmlLabel = new System.Windows.Forms.Label();
            this.xmlPathTxtBox = new System.Windows.Forms.TextBox();
            this.mailTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mrtFilePath
            // 
            this.mrtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.mrtFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mrtPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mrtFilePath.Location = new System.Drawing.Point(109, 23);
            this.mrtFilePath.Name = "mrtFilePath";
            this.mrtFilePath.Size = new System.Drawing.Size(136, 20);
            this.mrtFilePath.TabIndex = 0;
            this.mrtFilePath.Text = global::weekly_namespace.Properties.Settings.Default.mrtPath;
            this.mrtFilePath.TextChanged += new System.EventHandler(this.mrtFilePath_TextChanged);
            // 
            // mrtPathLabel
            // 
            this.mrtPathLabel.AutoSize = true;
            this.mrtPathLabel.Location = new System.Drawing.Point(12, 26);
            this.mrtPathLabel.Name = "mrtPathLabel";
            this.mrtPathLabel.Size = new System.Drawing.Size(91, 13);
            this.mrtPathLabel.TabIndex = 1;
            this.mrtPathLabel.Text = "Path To MRT File";
            // 
            // reportDirPathLabel
            // 
            this.reportDirPathLabel.AutoSize = true;
            this.reportDirPathLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportDirPathLabel.Location = new System.Drawing.Point(12, 65);
            this.reportDirPathLabel.Name = "reportDirPathLabel";
            this.reportDirPathLabel.Size = new System.Drawing.Size(96, 13);
            this.reportDirPathLabel.TabIndex = 3;
            this.reportDirPathLabel.Text = "Path To Report Dir";
            // 
            // reportDirPath
            // 
            this.reportDirPath.BackColor = System.Drawing.SystemColors.Window;
            this.reportDirPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "reportDirPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.reportDirPath.Location = new System.Drawing.Point(109, 62);
            this.reportDirPath.Name = "reportDirPath";
            this.reportDirPath.Size = new System.Drawing.Size(136, 20);
            this.reportDirPath.TabIndex = 2;
            this.reportDirPath.Text = global::weekly_namespace.Properties.Settings.Default.reportDirPath;
            this.reportDirPath.TextChanged += new System.EventHandler(this.reportDirPath_TextChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(12, 247);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(111, 32);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // pathXmlLabel
            // 
            this.pathXmlLabel.AutoSize = true;
            this.pathXmlLabel.Location = new System.Drawing.Point(12, 104);
            this.pathXmlLabel.Name = "pathXmlLabel";
            this.pathXmlLabel.Size = new System.Drawing.Size(84, 13);
            this.pathXmlLabel.TabIndex = 7;
            this.pathXmlLabel.Text = "Path To Xml File";
            // 
            // xmlPathTxtBox
            // 
            this.xmlPathTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "XmlPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.xmlPathTxtBox.Location = new System.Drawing.Point(109, 97);
            this.xmlPathTxtBox.Name = "xmlPathTxtBox";
            this.xmlPathTxtBox.Size = new System.Drawing.Size(136, 20);
            this.xmlPathTxtBox.TabIndex = 8;
            this.xmlPathTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.XmlPath;
            // 
            // mailTestBtn
            // 
            this.mailTestBtn.Location = new System.Drawing.Point(15, 149);
            this.mailTestBtn.Name = "mailTestBtn";
            this.mailTestBtn.Size = new System.Drawing.Size(75, 23);
            this.mailTestBtn.TabIndex = 9;
            this.mailTestBtn.Text = "mail_test";
            this.mailTestBtn.UseVisualStyleBackColor = true;
            this.mailTestBtn.Click += new System.EventHandler(this.mailTestBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 291);
            this.Controls.Add(this.mailTestBtn);
            this.Controls.Add(this.xmlPathTxtBox);
            this.Controls.Add(this.pathXmlLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.reportDirPathLabel);
            this.Controls.Add(this.reportDirPath);
            this.Controls.Add(this.mrtPathLabel);
            this.Controls.Add(this.mrtFilePath);
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
    }
}