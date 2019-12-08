using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using weekly_namespace.Properties;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            openFirstRunSettings();
            try
            {
                Application.Run(new MainWindow_Form());
            }
            catch (Exception ex)
            {
                Application.Run(new SettingsForm());

                try { Application.Run(new MainWindow_Form()); }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(),"Error");
                }
            }
            
            
        }

        private static void openFirstRunSettings()
        {
            if (Settings.Default.isFirstRun == true)
            {
                Settings.Default.isFirstRun = false;
                Application.Run(new SettingsForm());
            }
        }
    }
}
