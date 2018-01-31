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
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();
        }

        private void DataGridForm_Load(object sender, EventArgs e)
        {
            string filePath = Settings.Default.XmlPath;

            XmlDataSet.ReadXml(filePath);

            dataGridView1.DataSource = XmlDataSet;
            dataGridView1.DataMember = "Customer";
        }
    
    }
}
