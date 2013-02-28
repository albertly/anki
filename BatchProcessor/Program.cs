using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BatchProcessor
{
    static class Program
    {
        static public string stDicDir = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
