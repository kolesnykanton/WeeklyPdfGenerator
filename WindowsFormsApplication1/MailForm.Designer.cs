namespace weekly_namespace
{
    partial class MailForm
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
            this.sentMail_btn = new System.Windows.Forms.Button();
            this.mailTemplateTxtBox = new System.Windows.Forms.TextBox();
            this.mailSubjTxtBox = new System.Windows.Forms.TextBox();
            this.mailSenderTxtBox = new System.Windows.Forms.TextBox();
            this.mailRecievTxtBox = new System.Windows.Forms.TextBox();
            this.templatePathLbl = new System.Windows.Forms.Label();
            this.mailSubjLbl = new System.Windows.Forms.Label();
            this.SenderLbl = new System.Windows.Forms.Label();
            this.ReceiverLbl = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sentMail_btn
            // 
            this.sentMail_btn.Location = new System.Drawing.Point(24, 384);
            this.sentMail_btn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sentMail_btn.Name = "sentMail_btn";
            this.sentMail_btn.Size = new System.Drawing.Size(200, 55);
            this.sentMail_btn.TabIndex = 0;
            this.sentMail_btn.Text = "Test ";
            this.sentMail_btn.UseVisualStyleBackColor = true;
            this.sentMail_btn.Click += new System.EventHandler(this.sentMail_btn_Click);
            // 
            // mailTemplateTxtBox
            // 
            this.mailTemplateTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailTemplatePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailTemplateTxtBox.Location = new System.Drawing.Point(347, 81);
            this.mailTemplateTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mailTemplateTxtBox.Name = "mailTemplateTxtBox";
            this.mailTemplateTxtBox.Size = new System.Drawing.Size(388, 38);
            this.mailTemplateTxtBox.TabIndex = 1;
            this.mailTemplateTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailTemplatePath;
            this.mailTemplateTxtBox.TextChanged += new System.EventHandler(this.mailTemplateTxtBox_TextChanged);
            // 
            // mailSubjTxtBox
            // 
            this.mailSubjTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailSubject", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailSubjTxtBox.Location = new System.Drawing.Point(347, 143);
            this.mailSubjTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mailSubjTxtBox.Name = "mailSubjTxtBox";
            this.mailSubjTxtBox.Size = new System.Drawing.Size(388, 38);
            this.mailSubjTxtBox.TabIndex = 2;
            this.mailSubjTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailSubject;
            this.mailSubjTxtBox.TextChanged += new System.EventHandler(this.mailSubjTxtBox_TextChanged);
            // 
            // mailSenderTxtBox
            // 
            this.mailSenderTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailSender", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailSenderTxtBox.Location = new System.Drawing.Point(347, 205);
            this.mailSenderTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mailSenderTxtBox.Name = "mailSenderTxtBox";
            this.mailSenderTxtBox.Size = new System.Drawing.Size(388, 38);
            this.mailSenderTxtBox.TabIndex = 3;
            this.mailSenderTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailSender;
            this.mailSenderTxtBox.TextChanged += new System.EventHandler(this.mailSenderTxtBox_TextChanged);
            // 
            // mailRecievTxtBox
            // 
            this.mailRecievTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailReceiver", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailRecievTxtBox.Location = new System.Drawing.Point(347, 267);
            this.mailRecievTxtBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mailRecievTxtBox.Name = "mailRecievTxtBox";
            this.mailRecievTxtBox.Size = new System.Drawing.Size(388, 38);
            this.mailRecievTxtBox.TabIndex = 4;
            this.mailRecievTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailReceiver;
            this.mailRecievTxtBox.TextChanged += new System.EventHandler(this.mailRecievTxtBox_TextChanged);
            // 
            // templatePathLbl
            // 
            this.templatePathLbl.AutoSize = true;
            this.templatePathLbl.Location = new System.Drawing.Point(24, 81);
            this.templatePathLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.templatePathLbl.Name = "templatePathLbl";
            this.templatePathLbl.Size = new System.Drawing.Size(197, 32);
            this.templatePathLbl.TabIndex = 5;
            this.templatePathLbl.Text = "Template path";
            // 
            // mailSubjLbl
            // 
            this.mailSubjLbl.AutoSize = true;
            this.mailSubjLbl.Location = new System.Drawing.Point(24, 143);
            this.mailSubjLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.mailSubjLbl.Name = "mailSubjLbl";
            this.mailSubjLbl.Size = new System.Drawing.Size(111, 32);
            this.mailSubjLbl.TabIndex = 6;
            this.mailSubjLbl.Text = "Subject";
            // 
            // SenderLbl
            // 
            this.SenderLbl.AutoSize = true;
            this.SenderLbl.Location = new System.Drawing.Point(24, 205);
            this.SenderLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SenderLbl.Name = "SenderLbl";
            this.SenderLbl.Size = new System.Drawing.Size(107, 32);
            this.SenderLbl.TabIndex = 7;
            this.SenderLbl.Text = "Sender";
            // 
            // ReceiverLbl
            // 
            this.ReceiverLbl.AutoSize = true;
            this.ReceiverLbl.Location = new System.Drawing.Point(24, 267);
            this.ReceiverLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ReceiverLbl.Name = "ReceiverLbl";
            this.ReceiverLbl.Size = new System.Drawing.Size(127, 32);
            this.ReceiverLbl.TabIndex = 8;
            this.ReceiverLbl.Text = "Receiver";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(541, 384);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(200, 55);
            this.applyBtn.TabIndex = 9;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 763);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.ReceiverLbl);
            this.Controls.Add(this.SenderLbl);
            this.Controls.Add(this.mailSubjLbl);
            this.Controls.Add(this.templatePathLbl);
            this.Controls.Add(this.mailRecievTxtBox);
            this.Controls.Add(this.mailSenderTxtBox);
            this.Controls.Add(this.mailSubjTxtBox);
            this.Controls.Add(this.mailTemplateTxtBox);
            this.Controls.Add(this.sentMail_btn);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MailForm";
            this.Text = "Mail Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sentMail_btn;
        private System.Windows.Forms.TextBox mailTemplateTxtBox;
        private System.Windows.Forms.TextBox mailSubjTxtBox;
        private System.Windows.Forms.TextBox mailSenderTxtBox;
        private System.Windows.Forms.TextBox mailRecievTxtBox;
        private System.Windows.Forms.Label templatePathLbl;
        private System.Windows.Forms.Label mailSubjLbl;
        private System.Windows.Forms.Label SenderLbl;
        private System.Windows.Forms.Label ReceiverLbl;
        private System.Windows.Forms.Button applyBtn;
    }
}