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
    public partial class frmWait : Form
    {
        private Bitmap bmp;
        public frmWait()
        {
            InitializeComponent();
        }

        private void frmWait_Load(object sender, EventArgs e)
        {
            bmp = Properties.Resources.loading29;
            ImageAnimator.Animate(bmp, new EventHandler(this.OnFrameChanged));
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }

        private void frmWait_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();
            e.Graphics.DrawImage(this.bmp, new Point(0, 0));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (System.Threading.Interlocked.Read(ref Program.bWork) <= 0) this.Close();  
        }
    }
}
