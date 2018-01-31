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
    }
}
