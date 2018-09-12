using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AlertNotify
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
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.Run(new NotifyForm());
        }
        static void OnApplicationExit(object sender, EventArgs e)
        {
        }
    }
}
