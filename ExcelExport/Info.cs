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
    public partial class Info : Form
    {

        public excel.Workbook wBook; 
     //   public outlook.MailItem email;
        public Info()
        {
            InitializeComponent();
        }

        public Info(excel.Workbook workbook)
        {
            InitializeComponent();
            wBook = Globals.ThisAddIn.Application.ActiveWorkbook;
            txtFileName.Text = wBook.Name.ToString(); 

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {



            string strJob = cmbJobNumber.Text.Replace("/", "_").Replace(" ", "");
            strJob.Trim();
            string path = "R:\\wipviewer2017\\jobfiles\\";
            path += strJob + "\\" + cmbDept.Text + "\\";

            System.IO.Directory.CreateDirectory(path);

            if (path.Contains(".xls"))
            {
                wBook.SaveAs(path);
                MessageBox.Show("Success! File Saved");
            }

            else
            {
                path += txtFileName.Text + ".xlsx";
                wBook.SaveAs(path);
                MessageBox.Show("Success! File Saved");
            }

         
         

            //if (chkAttach.Checked == true)
            //{

               
            //   // email.SaveAs(path, outlook.OlSaveAsType.olMSG);

            //    MessageBox.Show("Success! Email Exported");
            //}
            //else
            //{
            //    for (int i = 0; i < email.Attachments.Count;)
            //    {

            //        //    email.Attachments.Remove(i + 1);
            //        wBook.SaveAs(path); 
            //        i++;

            //    }

            //    email.SaveAs(path, outlook.OlSaveAsType.olMSG);
            //    MessageBox.Show("Success! Email Exported");
            //}
        }

        private void Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ActiveJobs' table. You can move, or remove it, as needed.
            this.activeJobsTableAdapter.Fill(this.dataSet1.ActiveJobs);

        }
    }
}
