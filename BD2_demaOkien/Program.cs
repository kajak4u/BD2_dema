using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2_demaOkien
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new MainWindow());
            }
            catch(Exception e)
            {
                string message = e.Message;
                for (Exception e1 = e.InnerException; e1 != null; e1 = e1.InnerException)
                    message += "\n\n" + e1.Message;
                MessageBox.Show(message + Environment.NewLine + Environment.NewLine + e.StackTrace, "Wyjątek!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
