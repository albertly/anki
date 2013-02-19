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

        public string word;
        public Form1()
        {

            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            webBrowser1.Url = new Uri( @"http://www.yourdictionary.com/" + word);


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
               
        }

        void Document_MouseMove(object sender, HtmlElementEventArgs e)
        {
   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(@"http://www.yourdictionary.com/" + word);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {            
            webBrowser1.Url = new Uri(@"http://americanheritage.yourdictionary.com/" + word);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {            
            webBrowser1.Url = new Uri(@"http://dictionary.reference.com/browse/" + word);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            webBrowser1.Url = new Uri(@"http://www.memidex.com/" + word);
        }


    }
}
