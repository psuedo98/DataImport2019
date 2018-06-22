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
    public partial class JobHistory : Form
    {
        public JobHistory()
        {
            InitializeComponent();
        }

        public JobHistory(string JobNumber)
        {
            InitializeComponent();

            string strJobNumber = JobNumber; 

        }

        private void JobHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
