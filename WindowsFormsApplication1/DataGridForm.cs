using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weekly_namespace.Properties;

namespace weekly_namespace
{
    public partial class dg_form_xml_data : Form
    {
        public dg_form_xml_data()
        {
            InitializeComponent();
        }
        string xmlFilePath = Settings.Default.XmlPath;
        private void DataGridForm_Load(object sender, EventArgs e)
        {
            

            XmlDataSet.ReadXml(xmlFilePath);

            dataGridView1.DataSource = XmlDataSet;
            dataGridView1.DataMember = "Customer";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDataSet.WriteXml(xmlFilePath);
        }
    }
}
