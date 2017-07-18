using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using PhotobucketNet;

namespace PhotobucketBatchUpload
{
    public partial class frmMain : Form
    {

        private frmWait wait=null;
        private Photobucket pb;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        static int i = 1;

        private void frmMain_Shown(object sender, EventArgs e)
        {
            
        }

        void process(String title, String message, ThreadStart threadStart)
        {
            wait = new frmWait(title, message);
            Thread thread = new Thread(threadStart);
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
            wait.ShowDialog(this);
        }

        private void panWindow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
