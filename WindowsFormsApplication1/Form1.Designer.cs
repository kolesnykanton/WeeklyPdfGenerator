namespace WindowsFormsApplication1
{
    partial class MainWindow_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingButton = new System.Windows.Forms.Button();
            this.customIDBox = new System.Windows.Forms.GroupBox();
            this.invoiceIdTxtBox = new System.Windows.Forms.TextBox();
            this.customInvoiceCmBox = new System.Windows.Forms.ComboBox();
            this.showDataGridBtn = new System.Windows.Forms.Button();
            this.saveCustRep = new System.Windows.Forms.Button();
            this.genCustRep = new System.Windows.Forms.Button();
            this.customRepName = new System.Windows.Forms.Label();
            this.repNameTxtBox = new System.Windows.Forms.TextBox();
            this.customIDComboBox = new System.Windows.Forms.ComboBox();
            this.InvoceIDLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerIdTxtBox = new System.Windows.Forms.TextBox();
            this.customerCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.genCheckedBtn = new System.Windows.Forms.Button();
            this.mailButton = new System.Windows.Forms.Button();
            this.customIDBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingButton
            // 
            this.settingButton.Location = new System.Drawing.Point(568, 198);
            this.settingButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(190, 67);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // customIDBox
            // 
            this.customIDBox.Controls.Add(this.invoiceIdTxtBox);
            this.customIDBox.Controls.Add(this.customInvoiceCmBox);
            this.customIDBox.Controls.Add(this.showDataGridBtn);
            this.customIDBox.Controls.Add(this.saveCustRep);
            this.customIDBox.Controls.Add(this.genCustRep);
            this.customIDBox.Controls.Add(this.customRepName);
            this.customIDBox.Controls.Add(this.repNameTxtBox);
            this.customIDBox.Controls.Add(this.customIDComboBox);
            this.customIDBox.Controls.Add(this.InvoceIDLabel);
            this.customIDBox.Controls.Add(this.customerIDLabel);
            this.customIDBox.Controls.Add(this.customerIdTxtBox);
            this.customIDBox.Location = new System.Drawing.Point(568, 279);
            this.customIDBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customIDBox.Name = "customIDBox";
            this.customIDBox.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customIDBox.Size = new System.Drawing.Size(403, 515);
            this.customIDBox.TabIndex = 5;
            this.customIDBox.TabStop = false;
            this.customIDBox.Text = "Custom";
            // 
            // invoiceIdTxtBox
            // 
            this.invoiceIdTxtBox.Location = new System.Drawing.Point(163, 188);
            this.invoiceIdTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.invoiceIdTxtBox.Name = "invoiceIdTxtBox";
            this.invoiceIdTxtBox.Size = new System.Drawing.Size(63, 38);
            this.invoiceIdTxtBox.TabIndex = 1;
            this.invoiceIdTxtBox.Visible = false;
            // 
            // customInvoiceCmBox
            // 
            this.customInvoiceCmBox.FormattingEnabled = true;
            this.customInvoiceCmBox.Location = new System.Drawing.Point(248, 188);
            this.customInvoiceCmBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customInvoiceCmBox.Name = "customInvoiceCmBox";
            this.customInvoiceCmBox.Size = new System.Drawing.Size(100, 39);
            this.customInvoiceCmBox.TabIndex = 23;
            // 
            // showDataGridBtn
            // 
            this.showDataGridBtn.Location = new System.Drawing.Point(24, 434);
            this.showDataGridBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.showDataGridBtn.Name = "showDataGridBtn";
            this.showDataGridBtn.Size = new System.Drawing.Size(331, 55);
            this.showDataGridBtn.TabIndex = 4;
            this.showDataGridBtn.Text = "Show xml data";
            this.showDataGridBtn.UseVisualStyleBackColor = true;
            this.showDataGridBtn.Click += new System.EventHandler(this.showDataGridBtn_Click);
            // 
            // saveCustRep
            // 
            this.saveCustRep.Location = new System.Drawing.Point(197, 365);
            this.saveCustRep.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveCustRep.Name = "saveCustRep";
            this.saveCustRep.Size = new System.Drawing.Size(157, 55);
            this.saveCustRep.TabIndex = 8;
            this.saveCustRep.Text = "Save";
            this.saveCustRep.UseVisualStyleBackColor = true;
            this.saveCustRep.Click += new System.EventHandler(this.saveCustRep_Click);
            // 
            // genCustRep
            // 
            this.genCustRep.Location = new System.Drawing.Point(24, 365);
            this.genCustRep.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.genCustRep.Name = "genCustRep";
            this.genCustRep.Size = new System.Drawing.Size(157, 55);
            this.genCustRep.TabIndex = 7;
            this.genCustRep.Text = "Generate";
            this.genCustRep.UseVisualStyleBackColor = true;
            this.genCustRep.Click += new System.EventHandler(this.genCustRep_Click);
            // 
            // customRepName
            // 
            this.customRepName.AutoSize = true;
            this.customRepName.Location = new System.Drawing.Point(16, 258);
            this.customRepName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.customRepName.Name = "customRepName";
            this.customRepName.Size = new System.Drawing.Size(271, 32);
            this.customRepName.TabIndex = 6;
            this.customRepName.Text = "Custom report name";
            // 
            // repNameTxtBox
            // 
            this.repNameTxtBox.Location = new System.Drawing.Point(24, 300);
            this.repNameTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.repNameTxtBox.MaximumSize = new System.Drawing.Size(527, 40);
            this.repNameTxtBox.Name = "repNameTxtBox";
            this.repNameTxtBox.Size = new System.Drawing.Size(324, 38);
            this.repNameTxtBox.TabIndex = 5;
            // 
            // customIDComboBox
            // 
            this.customIDComboBox.FormattingEnabled = true;
            this.customIDComboBox.Location = new System.Drawing.Point(24, 48);
            this.customIDComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customIDComboBox.Name = "customIDComboBox";
            this.customIDComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customIDComboBox.Size = new System.Drawing.Size(324, 39);
            this.customIDComboBox.TabIndex = 4;
            this.customIDComboBox.SelectedIndexChanged += new System.EventHandler(this.customIDComboBox_SelectedIndexChanged);
            // 
            // InvoceIDLabel
            // 
            this.InvoceIDLabel.AutoSize = true;
            this.InvoceIDLabel.Location = new System.Drawing.Point(16, 196);
            this.InvoceIDLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InvoceIDLabel.Name = "InvoceIDLabel";
            this.InvoceIDLabel.Size = new System.Drawing.Size(125, 32);
            this.InvoceIDLabel.TabIndex = 3;
            this.InvoceIDLabel.Text = "InvoceID";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(16, 122);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(164, 32);
            this.customerIDLabel.TabIndex = 2;
            this.customerIDLabel.Text = "CustomerID";
            // 
            // customerIdTxtBox
            // 
            this.customerIdTxtBox.Location = new System.Drawing.Point(251, 114);
            this.customerIdTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customerIdTxtBox.Name = "customerIdTxtBox";
            this.customerIdTxtBox.Size = new System.Drawing.Size(97, 38);
            this.customerIdTxtBox.TabIndex = 0;
            // 
            // customerCheckListBox
            // 
            this.customerCheckListBox.CheckOnClick = true;
            this.customerCheckListBox.FormattingEnabled = true;
            this.customerCheckListBox.Location = new System.Drawing.Point(32, 19);
            this.customerCheckListBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.customerCheckListBox.Name = "customerCheckListBox";
            this.customerCheckListBox.Size = new System.Drawing.Size(439, 739);
            this.customerCheckListBox.TabIndex = 7;
            this.customerCheckListBox.SelectedIndexChanged += new System.EventHandler(this.customerCheckListBox_SelectedIndexChanged);
            // 
            // genCheckedBtn
            // 
            this.genCheckedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genCheckedBtn.Location = new System.Drawing.Point(568, 112);
            this.genCheckedBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.genCheckedBtn.Name = "genCheckedBtn";
            this.genCheckedBtn.Size = new System.Drawing.Size(397, 69);
            this.genCheckedBtn.TabIndex = 1;
            this.genCheckedBtn.Text = "Generate checked";
            this.genCheckedBtn.UseVisualStyleBackColor = true;
            this.genCheckedBtn.Click += new System.EventHandler(this.genCheckedBtn_Click);
            // 
            // mailButton
            // 
            this.mailButton.Location = new System.Drawing.Point(765, 198);
            this.mailButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(200, 67);
            this.mailButton.TabIndex = 3;
            this.mailButton.Text = "Mail";
            this.mailButton.UseVisualStyleBackColor = true;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            // 
            // MainWindow_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1033, 1100);
            this.Controls.Add(this.mailButton);
            this.Controls.Add(this.genCheckedBtn);
            this.Controls.Add(this.customerCheckListBox);
            this.Controls.Add(this.customIDBox);
            this.Controls.Add(this.settingButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainWindow_Form";
            this.Text = "WeeklyGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customIDBox.ResumeLayout(false);
            this.customIDBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingButton;
        public System.Windows.Forms.GroupBox customIDBox;
        private System.Windows.Forms.TextBox customerIdTxtBox;
        private System.Windows.Forms.ComboBox customIDComboBox;
        private System.Windows.Forms.Label InvoceIDLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox invoiceIdTxtBox;
        private System.Windows.Forms.Label customRepName;
        private System.Windows.Forms.TextBox repNameTxtBox;
        private System.Windows.Forms.Button saveCustRep;
        private System.Windows.Forms.Button genCustRep;
        private System.Windows.Forms.Button showDataGridBtn;
        private System.Windows.Forms.CheckedListBox customerCheckListBox;
        private System.Windows.Forms.Button genCheckedBtn;
        private System.Windows.Forms.ComboBox customInvoiceCmBox;
        private System.Windows.Forms.Button mailButton;
    }
}

