using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;
using System.Data.Entity.Validation;
using excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

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



           
            using (var db = new TestEntities())
            {
                ImportantDate iDate = db.ImportantDates.Find(strJobNumber);
                picture findpic = db.pictures.Find(strJobNumber);

                NewestBaseline baseline = db.NewestBaselines.Find(strJobNumber);
                NewestActual actual = db.NewestActuals.Find(strJobNumber); 

                if (baseline != null)
                {
                   

                    // lblMachineEndBase.Text = Convert.ToString(baseline.machineend);

                    DateTime processingstart = Convert.ToDateTime(baseline.processingstart).Date;
                    string processingstart1 = processingstart.ToString("d");
                    lblProcessingStartBase.Text = processingstart1;

                    // lblProcessingStartBase.Text = Convert.ToString(baseline.processingstart);

                    DateTime processingend = Convert.ToDateTime(baseline.processingend).Date;
                    string processingend1 = processingend.ToString("d");
                    lblProcessingEndBase.Text = processingend1;

                    DateTime materialstart = Convert.ToDateTime(baseline.materialstart).Date;
                    string materialstart1 = materialstart.ToString("d");
                    lblMaterialOrderBase.Text = materialstart1;

                    DateTime materialend = Convert.ToDateTime(baseline.materialend).Date;
                    string materialend1 = materialend.ToString("d");
                    lblMaterialReceivedBase.Text = materialend1;

                    DateTime machinestart = Convert.ToDateTime(baseline.machinestart).Date;
                    string machinestart1 = machinestart.ToString("d");
                    lblMachineStartBase.Text = machinestart1;

                    DateTime machineend = Convert.ToDateTime(baseline.machineend).Date;
                    string machineend1 = machineend.ToString("d");
                    lblMachineEndBase.Text = machineend1;

                    DateTime fabstart = Convert.ToDateTime(baseline.weldstart).Date;
                    string fabstart1 = fabstart.ToString("d");
                    lblFabStartBase.Text = fabstart1;

                    DateTime fabend = Convert.ToDateTime(baseline.weldend).Date;
                    string fabend1 = fabend.ToString("d");
                    lblFabFinishBase.Text = fabend1;

                    DateTime assemblystart = Convert.ToDateTime(baseline.assemblystart).Date;
                    string assemblystart1 = assemblystart.ToString("d");
                    lblAssemblyStartBase.Text = assemblystart1;

                    DateTime assemblyend  = Convert.ToDateTime(baseline.assemblyend).Date;
                    string assemblyend1 = assemblyend.ToString("d");
                    lblAssemblyFinishBase.Text = assemblyend1;
                }

                if (actual != null)
                {
                    DateTime processingstart = Convert.ToDateTime(actual.processingstart).Date;
                    string processingstart1 = processingstart.ToString("d");
                    lblProcessingStartAct.Text = processingstart1;

                    DateTime processingend = Convert.ToDateTime(actual.processingend).Date;
                    string processingsend1 = processingend.ToString("d");
                    lblProcessingEndAct.Text = processingsend1;

                    DateTime materialstart = Convert.ToDateTime(actual.materialstart).Date;
                    string materialstart1 = materialstart.ToString("d");
                    lblMaterialOrderAct.Text = materialstart1;

                    DateTime materialfinish = Convert.ToDateTime(actual.materialend).Date;
                    string materialfinish1 = materialfinish.ToString("d");
                    lblMaterialReceivedAct.Text = materialfinish1; 

                   

                    DateTime machinestart = Convert.ToDateTime(actual.machinestart).Date;
                    string machinestart1 = machinestart.ToString("d");
                    lblMachineStartAct.Text = machinestart1;

                    DateTime machineend = Convert.ToDateTime(actual.machineend).Date;
                    string machineend1 = machineend.ToString("d");
                    lblMachineEndAct.Text = machineend1;

                   DateTime fabstart = Convert.ToDateTime(actual.weldstart).Date;
                    string fabstart1 = fabstart.ToString("d");
                    lblFabStartAct.Text = fabstart1;

                    DateTime fabend = Convert.ToDateTime(actual.weldend).Date;
                    string fabend1 = fabend.ToString("d");
                    lblFabFinishAct.Text = fabend1;

                    DateTime assemblystart = Convert.ToDateTime(actual.assemblystart).Date;
                    string assemblystart1 = assemblystart.ToString("d");
                  lblAssemblyStartAct.Text = assemblystart1;

                    DateTime assemblyfinish = Convert.ToDateTime(actual.assemblyend).Date;
                    string assemblyfinish1 = assemblyfinish.ToString("d");
                   lblAssemblyFinishAct.Text = assemblyfinish1;




                }



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
               
                //db.SaveChanges();
                //MessageBox.Show("Dates Saved. GREAT JOB!");

              //  dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            


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

                  

                    if (jobteam1.Folder != null)
                    {
                        lblPoDate.Text = "PO Date: " + jobteam1.PODate.Value.ToString("MM-dd-yyyy");
                    }

                }

                //Folder fFolder = db.Folders.Find(strJobNumber.Substring(0,15));




                //      bool check2 = db.Folders.Any(u => u.JobNumber.Substring(0,15) == strJobNumber.Substring(0,15)); 

            


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
           
        }

        private void dgvComments(object sender, DataGridViewCellEventArgs e)
        {
        
            DialogResult result = MessageBox.Show("Close Action Item?", "Close Action Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TestEntities db1 = new TestEntities();
             

                

                db1.SaveChanges();

                PerformRefresh();


            }

            //DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[6].Value);



            //jobview2 jobview = new jobview2(content, tooltype, shipdate);
            //jobview.Show();
        }


        private void dgvActionItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Close Action Item?", "Close Action Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TestEntities db1 = new TestEntities();
           


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

        private void btnStatus_Click(object sender, EventArgs e)
        {
            string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");

            string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\status.pdf";

            //  excel.Application ap1 = new excel.Application();
            //    excel.Workbook wb = ap1.Workbooks.Open(path);

            System.Diagnostics.Process.Start(path);


            //   File.Open(path,FileMode.Open)
        }

        private void btnStatusImport_Click(object sender, EventArgs e)
        {
            

            if (ofdStatus.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = ofdStatus.FileName;
                string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");
                
                string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\status.pdf";
                File.Copy(filename, path); 
          
            }
        }

        private void btnViewProject_Click(object sender, EventArgs e)
        {
            //string path = "R:\\wipviewer2017\\prjfiles\\" + strJobNumber + ".pdf";
            string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");
            string path = "R:\\wipviewer2017\\prjfiles\\" + strJob + ".pdf"; 

            if (File.Exists(path))
            {
                // This path is a file
                Process.Start(path);      
            }
        }
    }
}
