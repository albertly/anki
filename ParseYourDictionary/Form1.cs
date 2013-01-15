using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParseYourDictionary
{
    public partial class Form1 : Form
    {
        bool f = false;
        public string word;
        public Form1()
        {

            InitializeComponent();
            LogFile.WriteFile("Start 05", LogLevel.Info);
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            webBrowser1.Url = new Uri( @"http://www.yourdictionary.com/" + word);
            LogFile.WriteFile("Start 06", LogLevel.Info);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            f = true;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            LogFile.WriteFile("Start 07", LogLevel.Info);
            if (e.Url.Scheme == "http")
            {
            }
            else
            {
                if (!f)
                e.Cancel = true;
                f = false;
                
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            LogFile.WriteFile("Start 08", LogLevel.Info);
          //  this.webBrowser1.Document.MouseMove += new HtmlElementEventHandler(Document_MouseMove);               
        }

        void Document_MouseMove(object sender, HtmlElementEventArgs e)
        {
            this.webBrowser1.Document.Window.ScrollTo(0, 280);
        }


    }
}
