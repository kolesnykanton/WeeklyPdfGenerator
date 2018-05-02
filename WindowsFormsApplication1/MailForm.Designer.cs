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
            this.SuspendLayout();
            // 
            // sentMail_btn
            // 
            this.sentMail_btn.Location = new System.Drawing.Point(9, 161);
            this.sentMail_btn.Name = "sentMail_btn";
            this.sentMail_btn.Size = new System.Drawing.Size(75, 23);
            this.sentMail_btn.TabIndex = 0;
            this.sentMail_btn.Text = "Test ";
            this.sentMail_btn.UseVisualStyleBackColor = true;
            this.sentMail_btn.Click += new System.EventHandler(this.sentMail_btn_Click);
            // 
            // mailTemplateTxtBox
            // 
            this.mailTemplateTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailTemplatePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailTemplateTxtBox.Location = new System.Drawing.Point(130, 34);
            this.mailTemplateTxtBox.Name = "mailTemplateTxtBox";
            this.mailTemplateTxtBox.Size = new System.Drawing.Size(148, 20);
            this.mailTemplateTxtBox.TabIndex = 1;
            this.mailTemplateTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailTemplatePath;
            // 
            // mailSubjTxtBox
            // 
            this.mailSubjTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailSubject", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailSubjTxtBox.Location = new System.Drawing.Point(130, 60);
            this.mailSubjTxtBox.Name = "mailSubjTxtBox";
            this.mailSubjTxtBox.Size = new System.Drawing.Size(148, 20);
            this.mailSubjTxtBox.TabIndex = 2;
            this.mailSubjTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailSubject;
            // 
            // mailSenderTxtBox
            // 
            this.mailSenderTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailSender", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailSenderTxtBox.Location = new System.Drawing.Point(130, 86);
            this.mailSenderTxtBox.Name = "mailSenderTxtBox";
            this.mailSenderTxtBox.Size = new System.Drawing.Size(148, 20);
            this.mailSenderTxtBox.TabIndex = 3;
            this.mailSenderTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailSender;
            // 
            // mailRecievTxtBox
            // 
            this.mailRecievTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::weekly_namespace.Properties.Settings.Default, "mailReceiver", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailRecievTxtBox.Location = new System.Drawing.Point(130, 112);
            this.mailRecievTxtBox.Name = "mailRecievTxtBox";
            this.mailRecievTxtBox.Size = new System.Drawing.Size(148, 20);
            this.mailRecievTxtBox.TabIndex = 4;
            this.mailRecievTxtBox.Text = global::weekly_namespace.Properties.Settings.Default.mailReceiver;
            // 
            // templatePathLbl
            // 
            this.templatePathLbl.AutoSize = true;
            this.templatePathLbl.Location = new System.Drawing.Point(9, 34);
            this.templatePathLbl.Name = "templatePathLbl";
            this.templatePathLbl.Size = new System.Drawing.Size(75, 13);
            this.templatePathLbl.TabIndex = 5;
            this.templatePathLbl.Text = "Template path";
            // 
            // mailSubjLbl
            // 
            this.mailSubjLbl.AutoSize = true;
            this.mailSubjLbl.Location = new System.Drawing.Point(9, 60);
            this.mailSubjLbl.Name = "mailSubjLbl";
            this.mailSubjLbl.Size = new System.Drawing.Size(43, 13);
            this.mailSubjLbl.TabIndex = 6;
            this.mailSubjLbl.Text = "Subject";
            // 
            // SenderLbl
            // 
            this.SenderLbl.AutoSize = true;
            this.SenderLbl.Location = new System.Drawing.Point(9, 86);
            this.SenderLbl.Name = "SenderLbl";
            this.SenderLbl.Size = new System.Drawing.Size(41, 13);
            this.SenderLbl.TabIndex = 7;
            this.SenderLbl.Text = "Sender";
            // 
            // ReceiverLbl
            // 
            this.ReceiverLbl.AutoSize = true;
            this.ReceiverLbl.Location = new System.Drawing.Point(9, 112);
            this.ReceiverLbl.Name = "ReceiverLbl";
            this.ReceiverLbl.Size = new System.Drawing.Size(50, 13);
            this.ReceiverLbl.TabIndex = 8;
            this.ReceiverLbl.Text = "Receiver";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 320);
            this.Controls.Add(this.ReceiverLbl);
            this.Controls.Add(this.SenderLbl);
            this.Controls.Add(this.mailSubjLbl);
            this.Controls.Add(this.templatePathLbl);
            this.Controls.Add(this.mailRecievTxtBox);
            this.Controls.Add(this.mailSenderTxtBox);
            this.Controls.Add(this.mailSubjTxtBox);
            this.Controls.Add(this.mailTemplateTxtBox);
            this.Controls.Add(this.sentMail_btn);
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
    }
}