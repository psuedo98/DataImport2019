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
    public partial class LaborTickets : Form
    {
        public string strBase;
        public string strLot; 
            
        public LaborTickets()
        {
            InitializeComponent();
        }

        public LaborTickets(string jobnumber)
        {
            InitializeComponent(); 

            strBase = jobnumber.Split('/').First();
            strBase = strBase.Trim();
            strLot = jobnumber.Split('/').Last();
            strLot = strLot.Trim(); 

                


        }
        private void LaborTickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIS712DataSet.LABOR_TICKET' table. You can move, or remove it, as needed.
            //   this.lABOR_TICKETTableAdapter.Fill(this.vIS712DataSet.LABOR_TICKET);
            //  this.lABOR_TICKETTableAdapter.FillBy(this.vIS712DataSet.LABOR_TICKET, strBase, strLot); 

            this.wipLaborTicketTableAdapter.Fill(this.vIS712DataSet.wipLaborTicket, strBase, strLot);
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
