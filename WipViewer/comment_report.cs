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
    public partial class comment_report : Form
    {
        public comment_report()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value;
            DateTime finish = dtpFinish.Value; 
            Comment_report_grid rpt_grid = new Comment_report_grid(start, finish);

            rpt_grid.Show(); 

            

        }
    }
}
