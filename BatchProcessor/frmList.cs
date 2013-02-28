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

namespace BatchProcessor
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(Program.stDicDir);
            var directories = di.GetFiles("*", SearchOption.AllDirectories);
            string st = "";
            foreach (FileInfo d in directories)
            {
                st = d.Name; 
                st = d.FullName;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = d.Name;
                lvi.Tag = d.FullName;
                lvi.ToolTipText = d.Name;                
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string word = listView1.SelectedItems[0].Name;
            string path = (string)listView1.SelectedItems[0].Tag;
            List<string> l =YourDictionary.GetFromCache(path);
            listView2.Items.Clear(); 
            foreach (string st in l)
            {
                listView2.Items.Add(st); 
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
