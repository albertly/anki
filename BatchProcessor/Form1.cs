using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ParseYourDictionary;
using System.Threading;  
namespace BatchProcessor
{
    public partial class Form1 : Form
    {
        int current = 0;
        bool stop = false;
        bool resumed = false;
        bool relax = false;
        String[] st1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdChooseDicDir_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {                 
                Program.stDicDir = folderBrowserDialog1.SelectedPath;
                lblDicDir.Text = Program.stDicDir;
            }
        }

        private void cmdFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblFile.Text = openFileDialog1.FileName; 
            }
        }

        private void process()
        {
            int i;
            int current_local = 0;
            string html;
            List<string> l;
            relax = false;
            timer1.Enabled = false;            

            foreach (string word in st1)
            {
                
                
                current_local++;
                if (resumed)
                {
                    if (current != current_local)
                    {
                        continue; 
                    }
                    else
                    {
                        resumed = false;
                    }
                }
                current++;
                lblWord.Text = word;
                lblProgress.Text = (Math.Round(current / Convert.ToDecimal(lblCount.Text), 2) * 100).ToString() + " %";   
                Application.DoEvents();
                if (!YourDictionary.CheckCache(word, folderBrowserDialog1.SelectedPath))
                {
                    l = new List<string>(); 
                    html = YourDictionary.GetHTML(word, 'E');
                    if (html.Length > 0)
                    {
                        l = YourDictionary.ParseExamples(html);
                    }
                    i = l.Count;
                    lblDic1Count.Text = i.ToString();
                    Application.DoEvents();

                    html = YourDictionary.GetHTML(word, 'D');
                    if (html.Length > 0)
                    {
                        l.AddRange(YourDictionary.ParseExamplesD(html));
                    }

                    lblDic2Count.Text = (l.Count - i).ToString();

                    if (i > 0)
                        YourDictionary.StoreInCache(l, word, folderBrowserDialog1.SelectedPath);

                    Application.DoEvents();
                    
                    if (stop) break;

                    if (current % Convert.ToInt32(txtAfter.Text) == 0)
                    {
                        timer1.Interval = Convert.ToInt32(txtSleepTime.Text) * 1000;
                        timer1.Enabled = true;
                        timer1.Start(); 
                        relax = true;
                        while (relax)
                        {
                            Thread.Sleep(100);
                            Application.DoEvents();
                        }
                        
                    }
                        
                }
            }

        }
        private void cmdStart_Click(object sender, EventArgs e)
        {            
            
            String[] st  = File.ReadAllLines(openFileDialog1.FileName);

            st1  = st.Select(x => x.Split('\t')[0]).ToArray(); 

            lblCount.Text  = st.Length.ToString() ;
            cmdPause.Enabled = true;
            cmdResume.Enabled = false;
            cmdStop.Enabled = true;
            cmdStart.Enabled = false;
            current = 0;
            resumed = false;
            stop = false;
            process();
        }

        private void cmdPause_Click(object sender, EventArgs e)
        {
            cmdPause.Enabled = false;
            cmdResume.Enabled = true;
            stop = true;
            resumed = true;
        }

        private void cmdResume_Click(object sender, EventArgs e)
        {
            cmdPause.Enabled = true;
            cmdResume.Enabled = false;
            stop = false;
            process();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            current = 0;
            cmdStart.Enabled = true;
            cmdStop.Enabled = false;
            cmdResume.Enabled = false;
            cmdPause.Enabled = false;
            stop = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            relax = false;
            timer1.Stop(); 
        }

        private void cmdList_Click(object sender, EventArgs e)
        {
            frmList f = new frmList();
            f.ShowDialog(); 
        }
    }
}
