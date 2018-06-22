using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;
using System.Data.Entity.Validation;
using excel = Microsoft.Office.Interop.Excel; 



namespace WipViewer
{
    public partial class jobview2 : Form
    {

        public string strJobNumber;
        public string strToolType;
        public string strShipdate;

        public Nullable<DateTime> dtMaterial;
        public Nullable<DateTime> dtFabrication;
        public Nullable<DateTime> dtHeat;
        public Nullable<DateTime> dtMachining;
        public Nullable<DateTime> dtAssembly;
        public Nullable<DateTime> dtCheck;
        public Nullable<DateTime> dtMachComplete;
        public Nullable<DateTime> dtSrc;
        public Nullable<DateTime> dtDesRel;

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

        public jobview2(string content)
        {
            InitializeComponent();

            strJobNumber = content.ToString(); 


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

            this.Text = strJobNumber;


            //check for red tag 

            //using (var db = new TestEntities())
            //{
            //    tblRedTag rt = db.tblRedTags.Find(strJobNumber);

            //    if (rt != null)
            //    {
            //        pbLight.Visible = true;
            //    }


            //}


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

            if (userName == "VISIONEERING\\bhallett")
            {
                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\ashinsky")
            {

                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\bdobleske")
            {
                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\smoore")
            {
                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\jfranz")
            {
                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\nhanna")
            {
                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\ANielsen")
            {
                btnGuys.Visible = true;
            }

            if (userName == "VISIONEERING\\cbacon")
            {
                btnGuys.Visible = true; 
            }

            if (userName == "VISIONEERING\\dconrad")
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
                    if (iDate.StartAssy != null)
                    {
                        dtpAssy.Value = iDate.StartAssy.Value;
                    }

                    else

                    {
                    //    dtpAssy.Value = DateTime.Now;
                        lblStartAssembly.BackColor = Color.Red;
                        lblStartAssembly.ForeColor = Color.White;
                    }
                   
                    if (iDate.DesRel != null)
                    {
                        dtpDesRel.Value = iDate.DesRel.Value;
                    }

                    else
                    {
                       // dtpDesRel.Value = DateTime.Now;
                        lblDesignRelease.BackColor = Color.Red;
                        lblDesignRelease.ForeColor = Color.White;
                    }

                   
                    if (iDate.StartFab != null)
                    {
                        dtpFab.Value = iDate.StartFab.Value;
                    }

                    else
                    {
                    //    dtpFab.Value = DateTime.Now;
                        lblStartFab.BackColor = Color.Red;
                        lblStartFab.ForeColor = Color.White;
                    }
                   
                    if (iDate.HeatTreat != null)
                    {
                        dtpHt.Value = iDate.HeatTreat.Value;
                    }

                    else
                    {
                    //    dtpHt.Value = DateTime.Now;
                        lblHeatTreat.BackColor = Color.Red;
                        lblHeatTreat.ForeColor = Color.White;
                    }

                   if (iDate.StartMachining !=null)
                    {
                        dtpMachine.Value = iDate.StartMachining.Value;
                    }

                   else
                    {
                  //      dtpMachine.Value = DateTime.Now;
                        lblStartMachining.BackColor = Color.Red;
                        lblStartMachining.ForeColor = Color.White;
                    }

                   
                    if (iDate.RecvMaterial != null)
                    {
                        dtpMaterial.Value = iDate.RecvMaterial.Value;
                    }
                    else
                    {
                   //     dtpMaterial.Value = DateTime.Now;
                        lblRecvMaterial.BackColor = Color.Red;
                        lblRecvMaterial.ForeColor = Color.White;
                    }

                    if (iDate.MachComp != null)
                    {
                        dtpMachineComp.Value = iDate.MachComp.Value;
                    }
                    else
                    {
                   //     dtpMachineComp.Value = DateTime.Now;
                        lblMachineComplete.BackColor = Color.Red;
                        lblMachineComplete.ForeColor = Color.White;
                    }
                    
                    if (iDate.RdyChk !=null)
                    {
                        dtpRdyChk.Value = iDate.RdyChk.Value;
                    }
                    else
                    {
                  //      dtpRdyChk.Value = DateTime.Now;
                        lblRdyCheck.BackColor = Color.Red;
                        lblRdyCheck.ForeColor = Color.White;
                    }

                    if (iDate.RdySrc !=null)
                    {
                        dtpSrc.Value = iDate.RdySrc.Value;
                    }
                    else
                    {
                  //      dtpSrc.Value = DateTime.Now;
                        lblRdySource.BackColor = Color.Red;
                        lblRdySource.ForeColor = Color.White;

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



                //TestEntities jobteam1 = new TestEntities();
                Team jobteam1 = new Team(); 
                bool check1 = db.Teams.Any(u => u.JobNumber == strJobNumber);

               
           


                if (check1 == true)
                {

                    jobteam1 = db.Teams.Find(strJobNumber); 
                    
                    if (jobteam1.ProgramManager != null)
                    {
                        lblPm.Text = "Program Manager: " + jobteam1.ProgramManager;
                    }

                    if (jobteam1.Processor != null)
                    {
                        lblProcessor.Text = "Processor: " + jobteam1.Processor;
                    }

                    if (jobteam1.BuildLeader != null)
                    {
                        lblBuldLeader.Text = "Build Leader: " + jobteam1.BuildLeader;
                    }

                    if (jobteam1.KickOff != null)
                    {
                        lblKickoff.Text = "Job Kicks Off: " + jobteam1.KickOff.Value.ToString("MM-dd-yyyy");
                    }

                    if (jobteam1.DataRelease != null)
                    {
                        lblData.Text = "Data Received: " + jobteam1.DataRelease.Value.ToString("MM-dd-yyyy");
                    }

                    if (jobteam1.Folder != null)
                    {
                        lblFolder.Text = "Folder Received: " + jobteam1.Folder.Value.ToString("MM-dd-yyyy");

                    }

                    if (jobteam1.Folder != null)
                    {
                        lblPoDate.Text = "PO Date: " + jobteam1.PODate.Value.ToString("MM-dd-yyyy");
                    }

                }

                Folder fFolder = db.Folders.Find(strJobNumber.Substring(0,15));




                //      bool check2 = db.Folders.Any(u => u.JobNumber.Substring(0,15) == strJobNumber.Substring(0,15)); 

                if (fFolder != null)

                {
                    if (fFolder.PMFolder != null)
                    {
                        lblPMFolder.Text = "PM Folder: " + fFolder.PMFolder.Value.ToString("MM/dd/yyyy");  
                    }

                    else
                    {
                        lblPMFolder.Text = "PM Folder Not Received";
                    }

                    if (fFolder.ProcessingFolder != null)
                    {
                        lblProcessorFolder.Text = "Processor Folder: " + fFolder.ProcessingFolder.Value.ToString("MM/dd/yyyy");
                    }

                    else
                    {
                        lblProcessorFolder.Text = "Processor Folder Not Received";
                    }

                    if (fFolder.WeldFolder != null)
                    {
                        lblWeldFolder.Text = "Weld Folder: " + fFolder.WeldFolder.Value.ToString("MM/dd/yyyy");
                    }

                    else
                    {
                        lblWeldFolder.Text = "Weld Folder Not Received";
                    }

                    if (fFolder.MachineFolder != null)
                    {
                        lblMachineFolder.Text = "Machine Folder" + fFolder.MachineFolder.Value.ToString("MM/dd/yyyy"); 
                    }

                    else
                    {
                        lblMachineFolder.Text = "Machine Folder Not Received";

                    }

                    if (fFolder.BuildFolder != null)
                    {
                        lblBuildFolder.Text = "Build Folder: " + fFolder.BuildFolder.Value.ToString("MM/dd/yyyy"); 
                    }

                    else
                    {
                        lblBuildFolder.Text = "Build Folder Not Received"; 
                    }
                }


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
            else
            {
                dtMaterial = null; 
                 
            }

            if (bfab == true)
            {
                dtFabrication = dtpFab.Value.Date;
            }
            else
            {
                dtFabrication = null; 
            }

            if (bht == true)
            {
                dtHeat = dtpHt.Value.Date;
            }
            else
            {
                dtHeat = null; 
            }

            if (bsmach == true)
            {
                dtMachining = dtpMachine.Value.Date;
            }
            else
            {
                dtMachining = null; 
            }
            if (bassy == true)
            {
                dtAssembly = dtpAssy.Value.Date;
            }
            else
            {
                dtAssembly = null; 
            }

            if (bmachcomp == true)
            {
                dtMachComplete = dtpMachineComp.Value.Date;
            }
            else
            {
                dtMachComplete = null; 
            }

            if (bchk == true)
            {
                dtCheck = dtpRdyChk.Value.Date;
            }
            else
            {
                dtCheck = null; 
            }

            if (bsrc == true)
            {
                dtSrc = dtpSrc.Value.Date;
            }
            else
            {
                dtSrc = null; 
            }

            if (bdesrel == true)
            {
                dtDesRel = dtpDesRel.Value.Date;
            }

            else
            {
                dtDesRel = null; 
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
                    try
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

                    catch (DbEntityValidationException f)
                    {
                        foreach (var eve in f.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }

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


        private void dgvActionItems_CellClick1(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvActionItems.Rows[index].Selected = true;
        }

        private void dgvComments(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvActionItems.SelectedRows[0].Cells[7].Value;

            DialogResult result = MessageBox.Show("Close Action Item?", "Close Action Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TestEntities db1 = new TestEntities();
                ActionItem action = db1.ActionItems.Find(id);

                action.openitem = "false";

                db1.SaveChanges();

                PerformRefresh();


            }

            //DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[6].Value);



            //jobview2 jobview = new jobview2(content, tooltype, shipdate);
            //jobview.Show();
        }


        private void dgvActionItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvActionItems.SelectedRows[0].Cells[7].Value; 

            DialogResult result = MessageBox.Show("Close Action Item?", "Close Action Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TestEntities db1 = new TestEntities();
                ActionItem action = db1.ActionItems.Find(id);

                action.openitem = "false";

                db1.SaveChanges();

                PerformRefresh(); 


            }

            //DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[6].Value);



            //jobview2 jobview = new jobview2(content, tooltype, shipdate);
            //jobview.Show();
        }

        private void btnRfq_Click(object sender, EventArgs e)
        {
            Rfq rfq = new Rfq(strJobNumber);
            rfq.Show(); 
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            history frmHistory = new history(strJobNumber);
            frmHistory.Show(); 

        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            job_comments frmJobComments = new job_comments(strJobNumber);
            frmJobComments.Show(); 

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
           
            if (strToolType.Trim() == "BOND TOOL" || strToolType.Trim() == "MILL FIXTURE")
            {
                ScheduleForms.BondSchedule bondschedule = new ScheduleForms.BondSchedule(strJobNumber, strToolType);
                bondschedule.Show(); 
            }
          //  jobSchedule schedule = new jobSchedule(strJobNumber, strToolType);
          //  schedule.Show(); 
        }

        private void btnname_Click(object sender, EventArgs e) 
        {
            MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().Name); 
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {

            string jobnumber = strJobNumber;
            FolderSet frmFolder = new FolderSet(jobnumber);

            
            frmFolder.Show(); 

        }

        private void pbLight_Click(object sender, EventArgs e)
        {

        }

        private void pbjob_click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            //pProcess.StartInfo.FileName = @"C:\\3dpdf\\test.pdf";
            ////pProcess.Start(); 

        }

        private void btnRA_Click(object sender, EventArgs e)
        {
           
            
            string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");

            string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\riskassessment.xlsx";

            //  excel.Application ap1 = new excel.Application();
            //    excel.Workbook wb = ap1.Workbooks.Open(path);

            System.Diagnostics.Process.Start(path); 


         //   File.Open(path,FileMode.Open);
        }

        private void btnAQP_Click(object sender, EventArgs e)
        {
            string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");

            string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\aqp.xlsx";

            //  excel.Application ap1 = new excel.Application();
            //    excel.Workbook wb = ap1.Workbooks.Open(path);

            System.Diagnostics.Process.Start(path);


            //   File.Open(path,FileMode.Open);
        }
    }
}
