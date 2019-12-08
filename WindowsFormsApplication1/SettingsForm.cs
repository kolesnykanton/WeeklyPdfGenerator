using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyHtm =System.Net.Mail;
using System.Windows.Forms;
using System.Xml;
using weekly_namespace;
using weekly_namespace.Properties;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WindowsFormsApplication1
{
    public partial class SettingsForm : Form
    {

        //Form1 form1 = new Form1();

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
            Settings.Default.Save();
            Close();

        }
        
        private void mailTestBtn_Click(object sender, EventArgs e)
        {
            MailForm mf = new MailForm();
            mf.ShowDialog(); 
            /**
            var doc = new XmlDocument();
            doc.Load(Settings.Default.XmlPath);
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/dataroot/Customers/Customer");

            foreach (XmlNode node in nodeList)
            {
                string CustomerName = node.SelectSingleNode("CustomerName").InnerText;
                
                string ReportName = node.SelectSingleNode("ReportName").InnerText + ".pdf";

                Outlook.Application mailApplication = new Outlook.Application();
                
                Outlook.MailItem mail = mailApplication.CreateItemFromTemplate(@"d:\Friday Report\#TEMPLATES\template.oft") as Outlook.MailItem;
                mail.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
                mail.Attachments.Add(@"d:\Friday Report\" + ReportName);
                mail.Subject = "Application Packaging – Weekly Summary";
                CustomerName = "<b>" + CustomerName + "</b> <br>";
                string body = mail.Body;
                string new_body = body.Replace("CustomerName", CustomerName );
                mail.HTMLBody = new_body;
                mail.Display(true);
                mail.Close(Outlook.OlInspectorClose.olDiscard);
                
            } **/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = op_diag_mrt.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                mrtFilePath.Text = op_diag_mrt.FileName;
                
            }
        }
        private void btn_browse_repo_dir_Click(object sender, EventArgs e)
        {
            //DialogResult result = fb_diag_repo_dir.ShowDialog(); // Show the dialog.
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "c:\\users";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                reportDirPath.Text = dialog.FileName;
            }
        }
        private void btn_browse_xml_Click(object sender, EventArgs e)
        {
            DialogResult result = op_diag_xml.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                xmlPathTxtBox.Text = op_diag_xml.FileName;

            }
        }

    }
}
