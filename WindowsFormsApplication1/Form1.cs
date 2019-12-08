using Stimulsoft.Report;
using Stimulsoft.Report.Export;
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
using weekly_namespace;
using weekly_namespace.Properties;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace WindowsFormsApplication1
{
    public partial class MainWindow_Form : Form
    {

        private Stimulsoft.Report.StiReport report;

        string pathToMrt = Settings.Default.mrtPath;
        string pathToReports = Settings.Default.reportDirPath;
        string pathToXml = Settings.Default.XmlPath;
        public string customCustomerName;

        public MainWindow_Form()
        {
            InitializeComponent();
            {
                this.report = new Stimulsoft.Report.StiReport();
            }

            report.Load(pathToMrt);
            report.Compile();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                    
            var doc = new XmlDocument();
            doc.Load(pathToXml);
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/dataroot/Customers/Customer");
            
            foreach (XmlNode node in nodeList)
            {
                customCustomerName = node.SelectSingleNode("CustomerName").InnerText;
                customIDComboBox.Items.Add(customCustomerName);
            }

            customerCheckListBox.Items.Add("Select All");
            foreach (XmlNode node in nodeList)
            {
                customCustomerName = node.SelectSingleNode("CustomerName").InnerText;
                customerCheckListBox.Items.Add(customCustomerName);
            }

        }

        ///Buttons with Customer INFO

        private void button1_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 93;
            report["InvoiceList"] = 94;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();
                       
            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Tullow Oil - Packaging Summary (VSL10497).Pdf");
            
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
                sf.ShowDialog();
        }

        private void customIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load(pathToXml);

            customCustomerName = customIDComboBox.Text;
            string customInvoiceId;

            XmlNode nodeListCustomer = xml.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/Customer.ID", customCustomerName));
            XmlNode nodeListInvoice = xml.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/Invoice.ID", customCustomerName));
            XmlNode nodeListRepName = xml.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", customCustomerName));
            XmlNodeList nodeList = xml.DocumentElement.SelectNodes(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']", customCustomerName));

            customInvoiceCmBox.Items.Clear();

            foreach (XmlNode node in nodeList)
            {
                customInvoiceId = node.SelectSingleNode("Invoice.ID").InnerText;
                customInvoiceCmBox.Items.Add(customInvoiceId);
            }
            customInvoiceCmBox.SelectedIndex = 0;

            invoiceIdTxtBox.Text = nodeListInvoice.InnerText;
            customerIdTxtBox.Text = nodeListCustomer.InnerText;
            repNameTxtBox.Text = nodeListRepName.InnerText;



        }

        private void genCustRep_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = int.Parse(customerIdTxtBox.Text);
            report["InvoiceList"] = int.Parse(customInvoiceCmBox.Text);

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + repNameTxtBox.Text);
        }

        private void saveCustRep_Click(object sender, EventArgs e)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(pathToXml);
            string newReportName = xmlDoc.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", customCustomerName)).InnerText = repNameTxtBox.Text;
            MessageBox.Show(newReportName,"New report name");
            xmlDoc.Save(pathToXml);
        }

        private void showDataGridBtn_Click(object sender, EventArgs e)
        {
            dg_form_xml_data dgf = new dg_form_xml_data();
            dgf.Show();


        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            customIDBox.Visible = !customIDBox.Visible;
        }

        private void mailButton_Click(object sender, EventArgs e)
        {

            var doc = new XmlDocument();
            doc.Load(Settings.Default.XmlPath);
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/dataroot/Customers/Customer");

            foreach (object itemChecked in customerCheckListBox.CheckedItems)
            {

                string CustomerName = itemChecked.ToString();

                XmlNode nodeListReportName = doc.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", CustomerName));

                Outlook.Application mailApplication = new Outlook.Application();

                Outlook.MailItem mail = mailApplication.CreateItemFromTemplate(Settings.Default.mailTemplatePath) as Outlook.MailItem;
                mail.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
                var ReportName = nodeListReportName.InnerText + ".pdf";
                mail.Attachments.Add(pathToReports + ReportName);
                mail.Subject = "Application Packaging – Weekly Summary";
                CustomerName = "<b>" + CustomerName + "</b> <br>";
                string body = mail.Body;
                string new_body = body.Replace("CustomerName", CustomerName);
                mail.HTMLBody = new_body;
                mail.Display(true);
                //mail.Close(Outlook.OlInspectorClose.olDiscard);

            }
        }

        private void genCheckedBtn_Click(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load(pathToXml);
            customerCheckListBox.SetItemChecked(0, false);
            string CustomerName;

            foreach (object itemChecked in customerCheckListBox.CheckedItems)
            {
                CustomerName = itemChecked.ToString();

                XmlNode nodeListCustomerID = xml.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/Customer.ID", CustomerName));
                XmlNode nodeListInvoiceID = xml.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/Invoice.ID", CustomerName));
                XmlNode nodeListReportName = xml.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", CustomerName));

                var temp = nodeListCustomerID.InnerText;
                var temp1 = nodeListInvoiceID.InnerText;
                var temp2 = nodeListReportName.InnerText;

                report["CustomerList"] = int.Parse(temp);
                report["InvoiceList"] = int.Parse(temp1);

                report.Render();

                StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

                report.ExportDocument(StiExportFormat.Pdf, pathToReports + temp2 + ".pdf");
            }
        }

        private void customerCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (customerCheckListBox.SelectedIndex.Equals(0))
            {
                var checkState = customerCheckListBox.GetItemCheckState(0);
                if (checkState == CheckState.Checked)
                {
                    for (int i = 1; i < customerCheckListBox.Items.Count; i++)
                        customerCheckListBox.SetItemChecked(i, true);
                }
                else
                {
                    for (int i = 1; i < customerCheckListBox.Items.Count; i++)
                        customerCheckListBox.SetItemChecked(i, false);
                }
                
            }
        }
    }
}
