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
    public partial class history : Form
    {
        public string strjobnumber; 
        public history()
        {
            InitializeComponent();
        }

        public history(string jobnumber)
        {
            InitializeComponent(); 
            strjobnumber = jobnumber;
            this.Text = "History for " + strjobnumber; 
            job_batchesTableAdapter.FillBatchData(jobBatches.Job_batches, strjobnumber);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobBatches.Job_batches' table. You can move, or remove it, as needed.
           
        }
    }
}
