using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerCosturaApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VistaLogin vl = new VistaLogin();
            vl.FormClosed += VistaLogin_Closed;
            vl.Show();
            Application.Run();
        }

        private static void VistaLogin_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= VistaLogin_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += VistaLogin_Closed;
            }
        }
    }
}
