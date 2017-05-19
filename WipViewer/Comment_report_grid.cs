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
    public partial class Comment_report_grid : Form
    {
        public Comment_report_grid()
        {
            InitializeComponent();
        }

        private void Comment_report_grid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_Comments.comments' table. You can move, or remove it, as needed.
            this.commentsTableAdapter.Fill(this.ds_Comments.comments);

        }

        public Comment_report_grid(DateTime start, DateTime finish)
        {
            DateTime Start = start;
            DateTime Finish = finish; 
            InitializeComponent();

            commentsTableAdapter.BetweenFillBy(ds_Comments.comments, Start.ToString(), Finish.ToString());

      //      activeJobsTableAdapter.BetweenDateFill(ds_activejobs.ActiveJobs, start.ToString(), end.ToString());
        }

        private void betweenFillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
           //     this.commentsTableAdapter.BetweenFillBy(this.ds_Comments.comments, date1ToolStripTextBox.Text, date2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
