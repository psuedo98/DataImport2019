using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using outlook = Microsoft.Office.Interop.Outlook; 

namespace MessageExport
{
    public partial class info : Form
    {
        public outlook.MailItem email; 
        public info()
        {
            InitializeComponent();
        }

        public info(outlook.MailItem mail)
        {
            InitializeComponent();


           //mbJobNumber.AutoCompleteCustomSource = activeJobsBindingSource; 
            email = mail;

            txtFileName.Text = email.Subject.ToString();

           
        }
        private void info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activeJobs_JobNumbers.ActiveJobs' table. You can move, or remove it, as needed.
            this.activeJobsTableAdapter.Fill(this.activeJobs_JobNumbers.ActiveJobs);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string strJob = cmbJobNumber.Text.Replace("/", "_").Replace(" ", "");
            strJob.Trim(); 

            string path = "R:\\wipviewer2017\\jobfiles\\";
            path += strJob + "\\Emails\\";

            System.IO.Directory.CreateDirectory(path); 

            path += txtFileName.Text + ".msg"; 
             
            

            if (chkAttach.Checked == true)
            {
                email.SaveAs(path, outlook.OlSaveAsType.olMSG);

                MessageBox.Show("Success! Email Exported");
            }
            else
            {
                for (int i = 0; i < email.Attachments.Count;)
                {

                    email.Attachments.Remove(i+1); 
                    i++;
                    
                }

                email.SaveAs(path, outlook.OlSaveAsType.olMSG);
                MessageBox.Show("Success! Email Exported");
            }
        }

        private void cmbJobNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblFilename_Click(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAttach_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblJob_Click(object sender, EventArgs e)
        {

        }
    }
}
