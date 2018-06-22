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
    public partial class job_comments : Form
    {
        public job_comments()
        {
            InitializeComponent();
        }

        public job_comments(string jobnumber)
        {
            InitializeComponent();
            string strjobnumber = jobnumber;
            Text = "Comments for " + strjobnumber;
            commentsTableAdapter.fillComments(dsComments.comments, strjobnumber);


        }
        private void job_comments_Load(object sender, EventArgs e)
        {
         

        }
    }
}
