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

        private void commentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comment_report Comment_report = new comment_report();
            Comment_report.Show(); 

        }

        private void fabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string department = "fab";
            schedule Schedule = new schedule(department);
            Schedule.Show(); 
        }

        private void machineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string department = "machine";
            schedule Schedule = new schedule(department);
            Schedule.Show(); 

        }

        private void actionItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionItemReport actionitemreport = new ActionItemReport();
            actionitemreport.Show(); 
        }

        private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comment_report commentreport = new comment_report();
            commentreport.Show(); 

        }
    }
}
