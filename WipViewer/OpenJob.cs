using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer
{
    public partial class OpenJob : Form
    {
        public OpenJob()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string jobnumber = txtJob.Text;

            jobview2 jobview = new jobview2(jobnumber);
            jobview.Show();
        }
    }
}
