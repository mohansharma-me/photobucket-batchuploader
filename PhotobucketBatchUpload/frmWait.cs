using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotobucketBatchUpload
{
    public partial class frmWait : Form
    {
        public frmWait(String title, String message)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            this.lblMessage.Text = message;
        }

        private void frmWait_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure to cancel this operation ?", "Cancel operation ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
