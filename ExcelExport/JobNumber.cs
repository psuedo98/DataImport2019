using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace ExcelExport
{




    public partial class JobNumber : Form
    {

        public excel.Workbook wBook;
        public excel.Application eapp;
        public string doctype; 
        public JobNumber()
        {
            InitializeComponent();
        }

        public JobNumber(string type)
        {
            doctype = type;
            InitializeComponent(); 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            wBook = Globals.ThisAddIn.Application.ActiveWorkbook;

            if (doctype == "riskassessment")
            {
               
                string strJob = cmbJn.Text.Replace("/", "_").Replace(" ", "");
                strJob.Trim();
                string path = "R:\\wipviewer2017\\jobfiles\\";
                path += strJob + "\\" + "riskassessment";
               

                System.IO.Directory.CreateDirectory(path);

                if (path.Contains(".xls"))
                {
                    wBook.SaveAs(path);
                    MessageBox.Show("Success! File Saved");
                }

                else
                {                 
                    wBook.SaveAs(path);                  
                    MessageBox.Show("Success! File Saved");
                }
            }

            else if (doctype == "aqp")
            {
                string strJob = cmbJn.Text.Replace("/", "_").Replace(" ", "");
                strJob.Trim();
                string path = "R:\\wipviewer2017\\jobfiles\\";
                path += strJob + "\\" + "aqp";
                System.IO.Directory.CreateDirectory(path);

                if (path.Contains(".xls"))
                {
                    wBook.SaveAs(path);
                    MessageBox.Show("Success! File Saved");
                }

                else
                {
                    wBook.SaveAs(path);
                    MessageBox.Show("Success! File Saved");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void JobNumber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ActiveJobs' table. You can move, or remove it, as needed.
            this.activeJobsTableAdapter.Fill(this.dataSet1.ActiveJobs);
            

        }

        private void cmbJn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
