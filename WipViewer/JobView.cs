using System;
using System.Windows.Forms;

namespace WipViewer
{
    public partial class JobView : Form
    {
        public string strJobNumber;
        public string strToolType;
        
        public string strShipdate;

        public DateTime dtMaterial;
        public DateTime dtFabrication;
        public DateTime dtHeat;
        public DateTime dtMachining;
        public DateTime dtAssembly;
        public DateTime dtCheck;
        public DateTime dtMachComplete;
        public DateTime dtSrc;
        public DateTime dtDesRel; 



        
        public JobView()
        {
            InitializeComponent();
            
        }

        public JobView(string content, string tooltype, DateTime shipdate)
        {
            InitializeComponent(); 
             strJobNumber = content.ToString();
            strToolType = tooltype;
            strShipdate = "Job Ships on: ";
            strShipdate += shipdate.Date.ToString("d");

        }

        private void JobView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'importantDates._ImportantDates' table. You can move, or remove it, as needed.
           // this.importantDatesTableAdapter.Fill(this.importantDates._ImportantDates);
            // TODO: This line of code loads data into the 'dsComments.comments' table. You can move, or remove it, as needed.
            // this.commentsTableAdapter.Fill(this.dsComments.comments);


            // activeJobsTableAdapter.BetweenDateFill(ds_activejobs.ActiveJobs, start.ToString(), end.ToString());

            job_batchesTableAdapter.FillBatchData(jobBatches.Job_batches, strJobNumber);
            commentsTableAdapter.fillComments(dsComments.comments,strJobNumber);
            importantDatesTableAdapter.FillBy(importantDates._ImportantDates, strJobNumber); 

          //  var dates = new 
           
            //// TODO: This line of code loads data into the 'jobBatches.Job_batches' table. You can move, or remove it, as needed.
            //this.job_batchesTableAdapter.Fill(this.jobBatches.Job_batches);
            //// TODO: This line of code loads data into the 'jobDataFull.JobHours' table. You can move, or remove it, as needed.
            //this.jobHoursTableAdapter.Fill(this.jobDataFull.JobHours);

            lblJobNumber.Text = strJobNumber;
            lblTooltype.Text = strToolType;
            
            lblShipdate.Text = strShipdate;

         

            // ImportantDate iDateo = new ImportantDate();

          
            
            //            for each (ImportantDate idateo in )

           

            //iDateo.BaseID = strJobNumber;
            //iDateo.RecvMaterial = dtMaterial;
            //iDateo.StartFab = dtFabrication;
            //iDateo.HeatTreat = dtHeat;
            //iDateo.StartMachining = dtMachining;
            //iDateo.StartAssy = dtAssembly;




        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobHoursTableAdapter.FillBy(this.jobDataFull.JobHours);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobHoursTableAdapter.FillBy1(this.jobDataFull.JobHours);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.jobHoursTableAdapter.FillBy2(this.jobDataFull.JobHours, strJobNumberToolStripTextBox.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void strJobNumberToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmComment pgComment = new WipViewer.frmComment(strJobNumber);
            pgComment.Show(); 

        }

        private void btnDates_Click(object sender, EventArgs e)
        {
            //    dtMaterial;
            //public DateTime dtFabrication;
            //public DateTime dtHeat;
            //public DateTime dtMachining;
            //public DateTime dtAssembly;

            dtMaterial = dtpMaterial.Value.Date;
            dtFabrication = dtpFab.Value.Date;
            dtHeat = dtpHt.Value.Date;
            dtMachining = dtpMachine.Value.Date;
            dtAssembly = dtpAssy.Value.Date;
            dtMachComplete = dtpMachineComp.Value.Date;
            dtCheck = dtpRdyChk.Value.Date;
            dtSrc = dtpSrc.Value.Date;
            dtDesRel = dtpDesRel.Value.Date; 

            //CommentEntities db = new CommentEntities();
         //   ImportantDate iDate = new ImportantDate();

            using (var db = new CommentEntities())
            {
                ImportantDate iDate = db.ImportantDates.Find(strJobNumber); 
                if (iDate != null)
                {
                    iDate.BaseID = strJobNumber;
                    iDate.RecvMaterial = dtMaterial;
                    iDate.StartFab = dtFabrication;
                    iDate.HeatTreat = dtHeat;
                    iDate.StartMachining = dtMachining;
                    iDate.StartAssy = dtAssembly;
                    iDate.MachComp = dtMachComplete;
                    iDate.RdyChk = dtCheck;
                    iDate.RdySrc = dtSrc;
                    iDate.DesRel = dtDesRel;
                    MessageBox.Show("Dates Updates. GREAT JOB!");

                }
                else
                {
                    ImportantDate iDate2 = new ImportantDate();
                    iDate2.BaseID = strJobNumber;
                    iDate2.RecvMaterial = dtMaterial;
                    iDate2.StartFab = dtFabrication;
                    iDate2.HeatTreat = dtHeat;
                    iDate2.StartMachining = dtMachining;
                    iDate2.StartAssy = dtAssembly;
                    iDate2.MachComp = dtMachComplete;
                    iDate2.RdyChk = dtCheck;
                    iDate2.RdySrc = dtSrc;
                    iDate2.DesRel = dtDesRel;
                    db.ImportantDates.Add(iDate2);
                }

                db.SaveChanges();
                MessageBox.Show("Dates Saved. GREAT JOB!");
            }

               







           

            //try
            //{
            //    db.SaveChanges();
            //    MessageBox.Show("Dates Saved. GREAT JOB!"); 
            //}
           
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Something went wrong. Call Jacob. Give him this error: " + ex);

            //}

        }

        private void dgvDates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JobView_Load_1(object sender, EventArgs e)
        {

        }





        //private void fillCommentsToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.commentsTableAdapter.fillComments(this.dsComments.comments, strjobnumberToolStripTextBox1.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
