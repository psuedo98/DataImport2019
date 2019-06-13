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
    public partial class MeetingRunning : Form
    {
        public MeetingRunning()
        {
            InitializeComponent();
        }

        public MeetingRunning(string Title)
        {
            string strTitle = Title;
            InitializeComponent();

            this.Text = strTitle; 
        }

        private void MeetingRunning_Load(object sender, EventArgs e)
        {

        }
    }
}
