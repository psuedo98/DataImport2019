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
    public partial class SupplierDB : Form
    {
        public SupplierDB()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SupplierAdd supplierAdd = new SupplierAdd();
            supplierAdd.MdiParent = this;
            supplierAdd.Show(); 

            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
         

            string reporttype = "supplier";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);

            mach.MdiParent = this; 

            mach.Show();
        }
    }
}
