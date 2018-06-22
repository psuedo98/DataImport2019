using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer.ScheduleForms
{
   
    public partial class GenerateSchedule : Form

        
    {

        public string strjobnumber;
        public GenerateSchedule()
        {
            InitializeComponent();
        }

        public GenerateSchedule(string jobnumber)
        {
            InitializeComponent();
            strjobnumber = jobnumber; 
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {

            string tooltype = cmbToolType.Text;

            if (tooltype == "AJ")
            {
                AJSchedule ajform = new AJSchedule(strjobnumber);
                ajform.Show();
            }

        }
    }
}
