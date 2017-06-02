using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity; 

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

        public bool bmaterial = false;
        public bool bfab = false;
        public bool bht = false;
        public bool bsmach = false;
        public bool bmachcomp = false;
        public bool bassy = false;
        public bool bchk = false;
        public bool bsrc = false;
        public bool bdesrel = false;
        
        public Stream stream;
        public Image image; 


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
           
            this.actionItemsTableAdapter.FillBy(this.ds_ActionItems.ActionItems, strJobNumber);
         
            job_batchesTableAdapter.FillBatchData(jobBatches.Job_batches, strJobNumber);
            commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);

          

            lblJobNumber.Text = strJobNumber;
            lblTooltype.Text = strToolType;
            lblShipdate.Text = strShipdate;

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name; 
            if (userName == "VISIONEERING\\zhallett")
            {
                btnGuys.Visible = true; 
            }
          

            if (userName == "VISIONEERING\\jrotary")
            {
                btnGuys.Visible = true; 
            }

            if (userName == "visioneering\\bhallett")
            {
                btnGuys.Visible = true; 
            }

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Orange; 
            style.ForeColor = Color.White; 



            for (int i = 0; i < dgvActionItems.RowCount; i++ )
            {

                if (Convert.ToString(dgvActionItems.Rows[i].Cells[5].Value) == "true")
                {

                    dgvActionItems.Rows[i].DefaultCellStyle = style;
                }
            }
            using (var db = new TestEntities())
            {
                ImportantDate iDate = db.ImportantDates.Find(strJobNumber);
                picture findpic = db.pictures.Find(strJobNumber); 

                if (findpic != null)
                {
                    using (var bmpTemp = new Bitmap(findpic.Path))
                    {

                        image = new Bitmap(bmpTemp);
                        pbJob.Image = image; 

                    }
                    //stream.Read(findpic.Path,0);
                    //image = System.Drawing.Image.FromStream(stream);
                    //image = (Image.FromFile(findpic.Path));
                    //pbJob.Image = image; 
                   
                }
                else
                {
                    pbJob.Image = Image.FromFile(@"r:\wippictures\na.jpg");
                    
                }
                if (iDate != null)
                {
                    if (iDate.StartAssy.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpAssy.Value = DateTime.Now;
                        lblStartAssembly.BackColor = Color.Red;
                        lblStartAssembly.ForeColor = Color.White; 


                    }
                    else
                    {
                        dtpAssy.Value = iDate.StartAssy.Value;
                    }

                    if (iDate.DesRel.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpDesRel.Value = DateTime.Now;
                        lblDesignRelease.BackColor = Color.Red;
                        lblDesignRelease.ForeColor = Color.White; 

                    }
                    else
                    {
                        dtpDesRel.Value = iDate.DesRel.Value;

                    }

                    if (iDate.StartFab.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpFab.Value = DateTime.Now;
                        lblStartFab.BackColor = Color.Red;
                        lblStartFab.ForeColor = Color.White;
                    }
                    else
                    {
                        dtpFab.Value = iDate.StartFab.Value;
                    }


                    if (iDate.HeatTreat.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpHt.Value = DateTime.Now;
                        lblHeatTreat.BackColor = Color.Red;
                        lblHeatTreat.ForeColor = Color.White; 

                    }
                    else
                    {
                        dtpHt.Value = iDate.HeatTreat.Value;
                    }


                    if (iDate.StartMachining.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpMachine.Value = DateTime.Now;
                        lblStartMachining.BackColor = Color.Red;
                        lblStartMachining.ForeColor = Color.White; 

                    }
                    else
                    {
                        dtpMachine.Value = iDate.StartMachining.Value;
                    }


                    if (iDate.RecvMaterial.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpMaterial.Value = DateTime.Now;
                        lblRecvMaterial.BackColor = Color.Red;
                        lblRecvMaterial.ForeColor = Color.White; 
                    }
                    else
                    {
                        dtpMaterial.Value = iDate.RecvMaterial.Value;
                    }


                    if (iDate.MachComp.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpMachineComp.Value = DateTime.Now;
                        lblMachineComplete.BackColor = Color.Red;
                        lblMachineComplete.ForeColor = Color.White; 
                    }
                    else
                    {
                        dtpMachineComp.Value = iDate.MachComp.Value;
                    }


                    if (iDate.RdyChk.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpRdyChk.Value = DateTime.Now;
                        lblRdyCheck.BackColor = Color.Red;
                        lblRdyCheck.ForeColor = Color.White; 
                    }
                    else
                    {
                        dtpRdyChk.Value = iDate.RdyChk.Value;
                    }
                    
                    if (iDate.RdySrc.Value.Date.ToString() == "1/1/0001 12:00:00 AM")
                    {
                        dtpSrc.Value = DateTime.Now;
                        lblRdySource.BackColor = Color.Red;
                        lblRdySource.ForeColor = Color.White; 
                    }
                    else
                    { 
                        dtpSrc.Value = iDate.RdySrc.Value; 
                    }
                   // dtpSrc.Value = iDate.RdySrc.Value; 


                }
                else
                {
                    lblStartAssembly.BackColor = Color.Red;
                    lblStartAssembly.ForeColor = Color.White;
                    lblDesignRelease.BackColor = Color.Red;
                    lblDesignRelease.ForeColor = Color.White;
                    lblStartFab.BackColor = Color.Red;
                    lblStartFab.ForeColor = Color.White;
                    lblHeatTreat.BackColor = Color.Red;
                    lblHeatTreat.ForeColor = Color.White;
                    lblStartMachining.BackColor = Color.Red;
                    lblStartMachining.ForeColor = Color.White;
                    lblRecvMaterial.BackColor = Color.Red;
                    lblRecvMaterial.ForeColor = Color.White;
                    lblMachineComplete.BackColor = Color.Red;
                    lblMachineComplete.ForeColor = Color.White;
                    lblRdyCheck.BackColor = Color.Red;
                    lblRdyCheck.ForeColor = Color.White;
                    lblRdySource.BackColor = Color.Red;
                    lblRdySource.ForeColor = Color.White;
                }

                //db.SaveChanges();
                //MessageBox.Show("Dates Saved. GREAT JOB!");

              //  dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                dgvActionItems.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvActionItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells; 

                

               TestEntities jobteam1 = new TestEntities();

                bool check1 = db.Teams.Any(u => u.JobNumber == strJobNumber);



                //if (check1 == true)
                //{
                //    jobteam1 = db.TeamEFs.Find(strJobNumber);

                //    if (jobteam1.ProgramManager != null)
                //    {
                //        lblPm.Text = "Program Manager: " + jobteam1.ProgramManager;
                //    }

                //    if (jobteam1.Processor != null)
                //    {
                //        lblProcessor.Text = "Processor: " + jobteam1.Processor;
                //    }

                //    if (jobteam1.BuildLeader != null)
                //    {
                //        lblBuldLeader.Text = "Build Leader: " + jobteam1.BuildLeader;
                //    }

                //    if (jobteam1.KickOff != null)
                //    {
                //        lblKickoff.Text = "Job Kicks Off: " + jobteam1.KickOff.Value.ToString("MM-dd-yyyy");
                //    }

                //    if (jobteam1.DataRelease != null)
                //    {
                //        lblData.Text = "Data Received: " + jobteam1.DataRelease.Value.ToString("MM-dd-yyyy");
                //    }

                //    if (jobteam1.Folder != null)
                //    {
                //        lblFolder.Text = "Folder Received: " + jobteam1.Folder.Value.ToString("MM-dd-yyyy");

                //    }

                //    if (jobteam1.Folder != null)
                //    {
                //        lblPoDate.Text = "PO Date: " + jobteam1.PODate.Value.ToString("MM-dd-yyyy");
                //    }

                //}
                    


                }

        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            //  frmComment pgComment = new WipViewer.frmComment(strJobNumber, dataGridView1);

            frmComment pgComment = new WipViewer.frmComment(this, strJobNumber);
            pgComment.Show();
            

        }



        public void PerformRefresh()
        {
            commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);
            actionItemsTableAdapter.FillBy(ds_ActionItems.ActionItems, strJobNumber);
            // this.commentsTableAdapter.Fill(); 
            this.dataGridView1.Refresh();
            this.dgvActionItems.Refresh(); 

            
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

            using (var db = new TestEntities())
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

        private void btnUpdatePicture_Click(object sender, EventArgs e)
        {
            ofdPicture.ShowDialog();
            string strPicture = ofdPicture.FileName.ToString();
            pbJob.Image = Image.FromFile(strPicture);
            string jobfilename = strJobNumber.Trim();
            jobfilename = jobfilename.Replace(@"/", "-"); 
            File.Copy(ofdPicture.FileName, "R:\\wippictures\\" + jobfilename + ".jpg", true);

            using (var db = new TestEntities())
            {
                picture jobPicture = db.pictures.Find(strJobNumber); 
                if (jobPicture != null)
                {
                                        
                    jobPicture.BaseId = strJobNumber;
                    jobPicture.Path = "R:\\wippictures\\" + jobfilename + ".jpg";
                    db.SaveChanges();
                    MessageBox.Show("Picture Updated. GREAT JOB!!");

                }
                else
                {
                    picture pic2 = new picture();
                    pic2.BaseId = strJobNumber;
                    pic2.Path = "R:\\wippictures\\" + jobfilename + ".jpg";
                    db.pictures.Add(pic2);
                    db.SaveChanges();
                    MessageBox.Show("Image Saved. GREAT JOB!!"); 
                }
            }
            //using (var db = new CommentEntities())
            //{
            //    ImportantDate iDate = db.ImportantDates.Find(strJobNumber);
            //    if (iDate != null)
            //    {
            //        iDate.BaseID = strJobNumber;
            //        iDate.RecvMaterial = dtMaterial;
            //        iDate.StartFab = dtFabrication;
            //        iDate.HeatTreat = dtHeat;
            //        iDate.StartMachining = dtMachining;
            //        iDate.StartAssy = dtAssembly;
            //        iDate.MachComp = dtMachComplete;
            //        iDate.RdyChk = dtCheck;
            //        iDate.RdySrc = dtSrc;
            //        iDate.DesRel = dtDesRel;
            //        db.SaveChanges();
            //        MessageBox.Show("Dates Updates. GREAT JOB!");

            //    }
            //    else
            //    {
            //        ImportantDate iDate2 = new ImportantDate();
            //        iDate2.BaseID = strJobNumber;
            //        iDate2.RecvMaterial = dtMaterial;
            //        iDate2.StartFab = dtFabrication;
            //        iDate2.HeatTreat = dtHeat;
            //        iDate2.StartMachining = dtMachining;
            //        iDate2.StartAssy = dtAssembly;
            //        iDate2.MachComp = dtMachComplete;
            //        iDate2.RdyChk = dtCheck;
            //        iDate2.RdySrc = dtSrc;
            //        iDate2.DesRel = dtDesRel;
            //        db.ImportantDates.Add(iDate2);
            //        db.SaveChanges();
            //        MessageBox.Show("Dates Saved. GREAT JOB!");

            //    }

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStartMachining_Click(object sender, EventArgs e)
        {

        }

        private void lblHeatTreat_Click(object sender, EventArgs e)
        {

        }

        private void btnGuys_Click(object sender, EventArgs e)
        {
            //Team frmTeam = new Team(strJobNumber);
            //frmTeam.Show();
            team2 frmTeam = new WipViewer.team2(strJobNumber);
            frmTeam.Show(); 
                      
        }

        private void lblShipdate_Click(object sender, EventArgs e)
        {

        }

        private void lblFolder_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblKickoff_Click(object sender, EventArgs e)
        {

        }

        private void btnActionItems_Click(object sender, EventArgs e)
        {
            

            ActionItems actionitems = new ActionItems(this, strJobNumber);
            actionitems.Show(); 
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actionItemsTableAdapter.Fill(this.ds_ActionItems.ActionItems);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void actionItemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvActionItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
