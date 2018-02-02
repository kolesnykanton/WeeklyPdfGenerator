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
using Outlook = Microsoft.Office.Interop.Outlook;

namespace WindowsFormsApplication1
{
    public partial class SettingsForm : Form
    {

        Form1 form1 = new Form1();

        public SettingsForm()
        {

            InitializeComponent();
            
        }

        private void mrtFilePath_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.mrtPath = mrtFilePath.Text;
        }

        private void reportDirPath_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.reportDirPath = reportDirPath.Text;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            mrtFilePath_TextChanged(sender, e);
            reportDirPath_TextChanged(sender, e);
            this.Hide();

        }

        private void mailTestBtn_Click(object sender, EventArgs e)
        {
            var doc = new XmlDocument();
            doc.Load(Settings.Default.XmlPath);
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/dataroot/Customers/Customer");

            Random rnd = new Random();

            //MessageBox.Show();
            foreach (XmlNode node in nodeList)
            {
                string CustomerName = node.SelectSingleNode("CustomerName").InnerText;

                string ReportName = node.SelectSingleNode("CustomerName").InnerText + ".pdf";

                Outlook.Application mailApplication = new Outlook.Application();
                
                //Outlook.MailItem mail = mailApplication.CreateItemFromTemplate(@"d:\Friday Report\#TEMPLATES\{0}.oft", CustomerName) as Outlook.MailItem;
                Outlook.MailItem mail = mailApplication.CreateItemFromTemplate(@"d:\Friday Report\#TEMPLATES\aimia.oft") as Outlook.MailItem;
                //mail.Attachments.Add(@"d:\Friday Report\" + ReportName);
                mail.Subject = "Application Packaging – Weekly Summary";
                mail.Body.Replace("CustomerName", CustomerName );
                MessageBox.Show(mail.Body);
                mail.Close(Outlook.OlInspectorClose.olDiscard);
                //mail.Display(true);
                
            }
        }
    }
}
