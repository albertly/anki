using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ParseYourDictionary
{
    public partial class frmSentence : Form
    {
        public frmSentence()
        {
            InitializeComponent();
        }

        private void cmdSay_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = Application.StartupPath + "\\SayStatic.exe";
            ExternalProcess.StartInfo.Arguments = textBox1.Text;
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }
    }
}
