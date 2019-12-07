using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using weekly_namespace.Properties;

namespace weekly_namespace
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void mailTemplateTxtBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.mailTemplatePath = mailTemplateTxtBox.Text;
        }

        private void mailSubjTxtBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.mailSubject = mailSubjTxtBox.Text;
        }

        private void mailSenderTxtBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.mailSender = mailSenderTxtBox.Text;
        }

        private void mailRecievTxtBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.mailReceiver = mailRecievTxtBox.Text;
        }

        private void sentMail_btn_Click(object sender, EventArgs e)
        {
            var doc = new XmlDocument();
            doc.Load(Settings.Default.XmlPath);
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/dataroot/Customers/Customer");

            foreach (XmlNode node in nodeList)
            {
                string CustomerName = node.SelectSingleNode("CustomerName").InnerText;

                string ReportName = node.SelectSingleNode("ReportName").InnerText + ".pdf";

                Microsoft.Office.Interop.Outlook.Application mailApplication = new Microsoft.Office.Interop.Outlook.Application();

                Microsoft.Office.Interop.Outlook.MailItem mail = mailApplication.CreateItemFromTemplate(mailTemplateTxtBox.Text) as Microsoft.Office.Interop.Outlook.MailItem;
                mail.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML;
                mail.Attachments.Add(Settings.Default.reportDirPath + ReportName);
                mail.Subject = mailSubjTxtBox.Text;
                mail.To  = mailRecievTxtBox.Text;
                CustomerName = "<b>" + CustomerName + "</b> <br>";
                string body = mail.Body;
                string new_body = body.Replace("CustomerName", CustomerName);
                mail.HTMLBody = new_body;
                mail.Display(true);
                mail.Close(Microsoft.Office.Interop.Outlook.OlInspectorClose.olDiscard);

            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
