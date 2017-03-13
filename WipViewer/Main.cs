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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void openJobToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllActiveJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView activedata = new DataView();
            activedata.Show(); 

             

        }

        private void lblWip_Click(object sender, EventArgs e)
        {

        }
    }
}
