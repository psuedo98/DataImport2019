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
    public partial class jobview2 : Form
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

        public bool bmaterial;
        public bool bfab;
        public bool bht;
        public bool bsmach;
        public bool bmachcomp;
        public bool bassy;
        public bool bchk;
        public bool bsrc;
        public bool bdesrel;


        public jobview2()
        {
            InitializeComponent();
        }

        public jobview2(string content, string tooltype, DateTime shipdate)
        {
            InitializeComponent();
            strJobNumber = content.ToString();
            strToolType = tooltype;
            strShipdate = "Job Ships on: ";
            strShipdate += shipdate.Date.ToString("d");

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void jobview2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobBatches.Job_batches' table. You can move, or remove it, as needed.
            //  this.job_batchesTableAdapter.Fill(this.jobBatches.Job_batches);
            // TODO: This line of code loads data into the 'dsComments.comments' table. You can move, or remove it, as needed.
            //   this.commentsTableAdapter.Fill(this.dsComments.comments);
            job_batchesTableAdapter.FillBatchData(jobBatches.Job_batches, strJobNumber);
            commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);

            // importantDatesTableAdapter.FillBy(importantDates._ImportantDates, strJobNumber);

            lblJobNumber.Text = strJobNumber;
            lblTooltype.Text = strToolType;
            lblShipdate.Text = strShipdate;

            using (var db = new CommentEntities())
            {
                ImportantDate iDate = db.ImportantDates.Find(strJobNumber);
                if (iDate != null)
                {
                    if (iDate.StartAssy.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpAssy.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpAssy.Value = iDate.StartAssy.Value;
                    }
                    //dtpDesRel.Value = iDate.DesRel.Value;
                    //dtpFab.Value = iDate.StartFab.Value;
                    //dtpHt.Value = iDate.HeatTreat.Value;
                    //dtpMachine.Value = iDate.StartMachining.Value;
                    //dtpMaterial.Value = iDate.RecvMaterial.Value;
                    //dtpMachineComp.Value = iDate.MachComp.Value;
                    //dtpRdyChk.Value = iDate.RdyChk.Value;

                    if (iDate.RdySrc.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpSrc.Value = DateTime.Now; 
                    }
                    else
                    { 
                        dtpSrc.Value = iDate.RdySrc.Value; 
                    }
                    dtpSrc.Value = iDate.RdySrc.Value; 


                }
                else
                {
                 
                }

                //db.SaveChanges();
                //MessageBox.Show("Dates Saved. GREAT JOB!");

            }

        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmComment pgComment = new WipViewer.frmComment(strJobNumber);
            pgComment.Show();

        }

        private void dtpMaterial_changed(object sender, EventArgs e)
        {
            bmaterial = true;
        }

        private void dtpFab_changed(object sender, EventArgs e)
        {
            bfab = true;
        }

        private void dtpht_changed(object sender, EventArgs e)
        {
            bht = true;
        }

        private void dtpsmach_changed(object sender, EventArgs e)
        {
           bsmach = true;
        }

        private void dtpmachcomp_changed(object sender, EventArgs e)
        {
            bmachcomp = true;
        }

        private void dtpassy_changed(object sender, EventArgs e)
        {
            bassy = true;
        }

        private void dtpchk_changed(object sender, EventArgs e)
        {
            bchk = true;
        }

        private void dtpsrc_changed(object sender, EventArgs e)
        {
            bsrc = true;
        }

        private void dtpdesrel_changed(object sender, EventArgs e)
        {
           bdesrel = true;
        }

        private void btnDates_Click(object sender, EventArgs e)
        {
            if (bmaterial == true)
            {
                dtMaterial = dtpMaterial.Value.Date;
            }
            if (bfab == true)
            {
                dtFabrication = dtpFab.Value.Date;
            }
            if (bht == true)
            {
                dtHeat = dtpHt.Value.Date;
            }
            if (bsmach == true)
            {
                dtMachining = dtpMachine.Value.Date;
            }
            if (bassy == true)
            {
                dtAssembly = dtpAssy.Value.Date;
            }
            if (bmachcomp == true)
            {
                dtMachComplete = dtpMachineComp.Value.Date;
            }
            if (bchk == true)
            {
                dtCheck = dtpRdyChk.Value.Date;
            }
            if (bsrc == true)
            {
                dtSrc = dtpSrc.Value.Date;
            }
            if (bdesrel == true)
            {
                dtDesRel = dtpDesRel.Value.Date;
            }

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
                    db.SaveChanges();
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
                    db.SaveChanges();
                    MessageBox.Show("Dates Saved. GREAT JOB!");

                }

                
               

            }
        }
    }
}
