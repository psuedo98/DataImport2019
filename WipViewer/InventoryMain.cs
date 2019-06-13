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
    public partial class InventoryMain : Form
    {
        public InventoryMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            AddNewPart addNewPart = new AddNewPart();
            addNewPart.MdiParent = this; 
            addNewPart.Show(); 

        }

        private void tsbAddPart_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void tsbInventoryIn_Click(object sender, EventArgs e)
        {
            InventoryIn inventory = new InventoryIn();
            inventory.MdiParent = this; 
            inventory.Show(); 

        }

        private void tsbInventoryOut_Click(object sender, EventArgs e)
        {
            string direction = "out";
            InventoryIn inventory1 = new InventoryIn(direction);
            inventory1.MdiParent = this; 
            inventory1.Show(); 

        }

        private void toolStripEx2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            string reporttype = "inventoryreport";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void InventoryMain_Load(object sender, EventArgs e)
        {

        }
    }
}
