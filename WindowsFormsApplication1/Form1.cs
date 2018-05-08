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
    public partial class Form1 : Form
    {

        private Stimulsoft.Report.StiReport report;

        string pathToMrt = Settings.Default.mrtPath;
        string pathToReports = Settings.Default.reportDirPath;
        string pathToXml = Settings.Default.XmlPath;
        public string customCustomerName;

        public Form1()
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

        private void button2_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 77;
            report["InvoiceList"] = 71;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Intuit Inc. - Packaging Summary.Pdf");
        }

        private void aimiaButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 106;
            report["InvoiceList"] = 118;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Aimia - Packaging Summary.Pdf");
        }

        private void airbusButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 69;
            report["InvoiceList"] = 60;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Airbus Group - Packaging Summary.Pdf");
        }

        private void cameronButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 71;
            report["InvoiceList"] = 62;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Cameron International Corporation - Packaging Summary (2014).Pdf");
        }

        private void careButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 72;
            report["InvoiceList"] = 63;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Care UK - Packaging Summary.Pdf");
        }

        private void maceButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 81;
            report["InvoiceList"] = 75;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Mace Group - Packaging Summary.Pdf");
        }

        private void MiddlesexButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 82;
            report["InvoiceList"] = 76;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Middlesex Hospital - Packaging Summary.Pdf");
        }

        private void morrisonsButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 105;
            report["InvoiceList"] = 116;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Morrissons - Packaging Summary.Pdf");
        }

        private void munichreButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 85;
            report["InvoiceList"] = 122;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Munich Reinsurance America - Packaging Summary (2017).Pdf");
        }

        private void plymouthButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 88;
            report["InvoiceList"] = 117;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Plymouth University - Packaging Summary (Invoice Custom 100).Pdf");

            report["CustomerList"] = 88;
            report["InvoiceList"] = 99;

            report.Render();

            StiPdfExportSettings pdfSettings1 = new StiPdfExportSettings();
            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Plymouth University - Packaging Summary (Invoice VSL0322).pdf");

            report["CustomerList"] = 88;
            report["InvoiceList"] = 85;

            report.Render();

            StiPdfExportSettings pdfSettings2 = new StiPdfExportSettings();
            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Plymouth University - Packaging Summary (Invoice VSL10351).pdf).pdf");

        }

        private void poloButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 89;
            report["InvoiceList"] = 89;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Polo Ralph Lauren - Packaging Summary.Pdf");
        }

        private void rwjfButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 90;
            report["InvoiceList"] = 111;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Robert Woods Johnson Foundation - Packaging Summary.Pdf");
        }

        private void ssdButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 104;
            report["InvoiceList"] = 115;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Smart Service Desk - Packaging Summary.Pdf");
        }

        private void umassButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 94;
            report["InvoiceList"] = 96;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "UMASS Medical School - Packaging Summary.Pdf");
        }

        private void umgButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 95;
            report["InvoiceList"] = 106;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Universal Music - Packaging Summary.Pdf");
        }

        private void weyerButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 99;
            report["InvoiceList"] = 110;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Weyerhaeuser - Packaging Summary.Pdf");
        }

        private void progressButton_Click(object sender, EventArgs e)
        {
            report["CustomerList"] = 107;
            report["InvoiceList"] = 123;

            report.Render();

            StiPdfExportSettings pdfSettings = new StiPdfExportSettings();

            report.ExportDocument(StiExportFormat.Pdf, pathToReports + "Progressive Insurance - Packaging Summary.Pdf");
        }

        ///Customer info END

        private void button3_Click(object sender, EventArgs e)
        {
            var progressbarAll = new ProgressBar();
            progressbarAll.Style = ProgressBarStyle.Marquee;
            progressbarAll.Visible = true;
            progressbarAll.Location = new System.Drawing.Point(110, 340);
            Controls.Add(progressbarAll);
            button1_Click(sender, e);
            button2_Click(sender, e);
            aimiaButton_Click(sender, e);
            airbusButton_Click(sender, e);
            cameronButton_Click(sender, e);
            careButton_Click(sender, e);
            maceButton_Click(sender, e);
            MiddlesexButton_Click(sender, e);
            morrisonsButton_Click(sender, e);
            munichreButton_Click(sender, e);
            plymouthButton_Click(sender, e);
            poloButton_Click(sender, e);
            rwjfButton_Click(sender, e);
            ssdButton_Click(sender, e);
            umassButton_Click(sender, e);
            umgButton_Click(sender, e);
            weyerButton_Click(sender, e);
            progressButton_Click(sender, e);
            progressbarAll.Hide();
            genAllBtn.BackColor = Color.Green;
            //MessageBox.Show("Reports Created");

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
            var doc = new XmlDocument();
            doc.Load(pathToXml);
            //XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/dataroot/Customers/Customer");
            //doc.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", customCustomerName)).InnerText = "NEW Report Name";
            //doc.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", customCustomerName)).InnerText = "NEW Report Name";
            var test = doc.DocumentElement.SelectSingleNode(string.Format("/dataroot/Customers/Customer[CustomerName='{0}']/ReportName", customCustomerName)).InnerText = repNameTxtBox.Text;

            //MessageBox.Show(customerIdTxtBox.Text);
            //MessageBox.Show(invoiceIdTxtBox.Text);
            MessageBox.Show(test);
            doc.Save(@"d:\Friday Report\testXML.xml");
        }

        private void showDataGridBtn_Click(object sender, EventArgs e)
        {
            DataGridForm dgf = new DataGridForm();
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

                Outlook.MailItem mail = mailApplication.CreateItemFromTemplate(@"d:\Friday Report\#TEMPLATES\template.oft") as Outlook.MailItem;
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
