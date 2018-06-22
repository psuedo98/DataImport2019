using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel; 

namespace WipViewer
{
    public partial class Rfq : Form
    {
        public string strJobnumber; 
        public Rfq()
        {
            InitializeComponent();
        }

        public Rfq(string jobnumber)
        {
            InitializeComponent(); 

            
            strJobnumber = jobnumber;

            string baseid = strJobnumber.Substring(0, 8);
            string lotid = strJobnumber.Substring(11, 1);
            string customer = strJobnumber.Substring(0, 4); 

            txtBaseId.Text = baseid;
            txtLot.Text = lotid; 

            switch(customer)
            {
                case "BOSE":
                    txtCustomerSpec.Text = "This is the Spec for Boeing Seattle";
                    break;
                default:
                    txtCustomerSpec.Text = "No Customer Spec has been created. Type it in";
                    break; 

            }
            
           // string lot = n
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rfq_Load(object sender, EventArgs e)
        {

        }

        private void selection_changed(object sender, EventArgs e)
        {
            if (cmbSupplier.Text == "Norcote")
            {
                txtSupContact.Text = "Cecil Black";
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ofd1.ShowDialog();
            Bitmap bmpTemp = new Bitmap(ofd1.FileName);
            pbTool.Image = bmpTemp; 
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Bitmap bmpTemp = new Bitmap(ofd1.FileName);
            pbTool.Image = bmpTemp;

            //    Workbook wb = xlapp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

            Workbook wb = xlapp.Workbooks.Open("R:\\wipviewer2017\\ht.xlsx"); 
            Worksheet ws = (Worksheet)wb.Worksheets[1];
            Range rng = (Range)ws.Cells[10, 8]; 
            
            ws.Cells[6, 2] = txtRfq.Text;          
            ws.Cells[7, 2] = cmbSupplier.Text;
            ws.Cells[8, 2] = txtSupContact.Text;
            ws.Cells[9, 2] = txtTool.Text;
            ws.Cells[10, 2] = txtDetail.Text;
            ws.Cells[11, 2] = cmbMaterial.Text;
            ws.Cells[12, 2] = cmbCerts.Text;
            ws.Cells[13, 2] = txtQty.Text;
            ws.Cells[14, 2] = txtStock.Text;
            ws.Cells[15, 2] = txtWeight.Text;
            ws.Cells[16, 2] = txtQuote.Text;
            ws.Cells[6, 11] = dtpReq.Value.ToString();

            Clipboard.SetImage(bmpTemp);
            ws.Paste(rng, false); 

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
