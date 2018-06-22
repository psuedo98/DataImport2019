using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer.ScheduleForms
{
    public partial class BondSchedule : Form
    {
        public string strjobnumber;
        public string tooltype;

        public DateTime dtDataRelease;
        public DateTime dtReceiveMaterial;
        public DateTime dtStartFab;
        public DateTime dtHeatTreat;
        public DateTime dtStartMachining;
        public DateTime dtMachineComplete;
        public DateTime dtStartAssembly;
        public DateTime dtReadyCheck;
        public DateTime dtReadySource;

        public bool bmaterial;
        public bool bfab;
        public bool bht;
        public bool bsmach;
        public bool bmachcomp;
        public bool bassy;
        public bool bchk;
        public bool bsrc;
        public bool bdesrel;
        

        public BondSchedule()
        {
            InitializeComponent();
        }

        public BondSchedule(string jobnumber, string tooltype)
        {
            InitializeComponent();
            strjobnumber = jobnumber;

            Text = "Schedule for " + strjobnumber;

        }

        private void BondSchedule_Load(object sender, EventArgs e)
        {
            using (var db = new TestEntities())
            {
                ImportantDate iDate = db.ImportantDates.Find(strjobnumber);

                BindingSource bs1 = new BindingSource();

                var row = (from r in db.ImportantDates
                           where (r.BaseID==strjobnumber)
                           select r);
                var list = row.ToList(); 
                //var query = (from r in db.ImportantDates
                //             where (r.BaseID == strjobnumber)
                //             select r;

           //     var list = query.ToList();
                dgvBaseline.DataSource = list; 
                dgvBaseline.Refresh();

                BindingSource bs2 = new BindingSource();

                var row2 = (from r2 in db.BondActuals
                            where (r2.BaseID == strjobnumber)
                            select r2);
                var list2 = row2.ToList();

                dgvActuals.DataSource = list2;
                dgvActuals.Refresh(); 

                        
                
           //     var query = from c in db.ImportantDates.Find(strjobnumber);
            //    var dates = query.ToList(); 

                //if (iDate != null)
                //{
                //    dgvBaseline.DataSource = iDate;
                //}

                var lotlist = db.ActiveJobs
                    .Where(b => b.BaseID.Contains(strjobnumber.Substring(0, 8)));

                int p = lotlist.Count();

                ActiveJob[] array1 = lotlist.ToArray(); 

                for (int i =0; i<p; i++)
                {
                    string name = "chk" + i;
                    string lot = array1[i].BaseID.Substring(11, 2);

                    chklistbox.Items.Add("Lot" + lot);
                }
                
                if (iDate != null)
                {
                    if (iDate.StartAssy == null)
                    {
                        dtpAssy.Value = DateTime.Now;
                        
                        lblStartAssembly.BackColor = Color.Red;
                        lblStartAssembly.ForeColor = Color.White;
                        bassy = false;

                    }
                    else
                    {
                        dtpAssy.MinDate = new System.DateTime(); 
                        dtpAssy.Value = iDate.StartAssy.Value;
                        dtStartAssembly = iDate.StartAssy.Value;                       
                    }

                    if (iDate.DesRel == null)
                    {
                        dtpDataRls.Value = DateTime.Now;
                        lblDataRelease.BackColor = Color.Red;
                        lblDataRelease.ForeColor = Color.White;
                        bdesrel = false; 

                    }
                    else
                    {
                        dtpDataRls.MinDate = new System.DateTime(); 
                        dtpDataRls.Value = iDate.DesRel.Value;
                        dtDataRelease = iDate.DesRel.Value;                     

                    }

                    if (iDate.StartFab == null)
                    {
                        dtpFab.Value = DateTime.Now;
                        lblStartFab.BackColor = Color.Red;
                        lblStartFab.ForeColor = Color.White;
                        bfab = false; 

                    }
                    else
                    {
                        dtpFab.MinDate = new System.DateTime(); 
                        dtpFab.Value = iDate.StartFab.Value;
                        dtStartFab = iDate.StartFab.Value;
                     
                    }


                    if (iDate.HeatTreat == null)
                    {
                        dtpHt.Value = DateTime.Now;
                        lblHeatTreat.BackColor = Color.Red;
                        lblHeatTreat.ForeColor = Color.White;
                        bht = false; 

                    }
                    else
                    {
                        dtpHt.MinDate = new System.DateTime(); 
                        dtpHt.Value = iDate.HeatTreat.Value;
                        dtHeatTreat = iDate.HeatTreat.Value;                     
                    }


                    if (iDate.StartMachining == null)
                    {
                        dtpMach.Value = DateTime.Now;
                        lblStartMachining.BackColor = Color.Red;
                        lblStartMachining.ForeColor = Color.White;
                        bsmach = false; 
                    }
                    else
                    {
                        dtpMach.MinDate = new System.DateTime(); 
                        dtpMach.Value = iDate.StartMachining.Value;
                        dtStartMachining = iDate.StartMachining.Value;                    
                    }


                    if (iDate.RecvMaterial == null)
                    {
                        dtpReceive.Value = DateTime.Now;
                        lblReceiveMaterial.BackColor = Color.Red;
                        lblReceiveMaterial.ForeColor = Color.White;
                        bmaterial = false; 

                    }
                    else
                    {
                        dtpReceive.MinDate = new System.DateTime(); 
                        dtpReceive.Value = iDate.RecvMaterial.Value;
                        dtReceiveMaterial = iDate.RecvMaterial.Value;
                       
                    }


                    if (iDate.MachComp == null)
                    {
                        dtpMachComp.Value = DateTime.Now;
                        lblMachineComplete.BackColor = Color.Red;
                        lblMachineComplete.ForeColor = Color.White;
                        bmachcomp = false; 
                    }
                    else
                    {
                        dtpMachComp.MinDate = new System.DateTime(); 
                        dtpMachComp.Value = iDate.MachComp.Value;
                        dtMachineComplete = iDate.MachComp.Value;
                     
                    }


                    if (iDate.RdyChk == null)
                    {
                        dtpRdyChk.Value = DateTime.Now;
                        lblReadyCheck.BackColor = Color.Red;
                        lblReadyCheck.ForeColor = Color.White;
                        bchk = false; 

                    }
                    else
                    {
                        dtpRdyChk.MinDate = new System.DateTime(); 
                        dtpRdyChk.Value = iDate.RdyChk.Value;
                        dtReadyCheck = iDate.RdyChk.Value;
                       
                    }

                    if (iDate.RdySrc == null)
                    {
                        dtpRdySrc.Value = DateTime.Now;
                        lblReadySource.BackColor = Color.Red;
                        lblReadySource.ForeColor = Color.White;
                        bsrc = false; 
                    }
                    else
                    {
                        dtpRdySrc.MinDate = new System.DateTime(); 
                        dtpRdySrc.Value = iDate.RdySrc.Value;
                        dtReadySource = iDate.RdySrc.Value;
                        
                    }
                    // dtpSrc.Value = iDate.RdySrc.Value; 


                }
                else
                {
                    lblStartAssembly.BackColor = Color.Red;
                    lblStartAssembly.ForeColor = Color.White;
                    lblDataRelease.BackColor = Color.Red;
                    lblDataRelease.ForeColor = Color.White;
                    lblStartFab.BackColor = Color.Red;
                    lblStartFab.ForeColor = Color.White;
                    lblHeatTreat.BackColor = Color.Red;
                    lblHeatTreat.ForeColor = Color.White;
                    lblStartMachining.BackColor = Color.Red;
                    lblStartMachining.ForeColor = Color.White;
                    lblReceiveMaterial.BackColor = Color.Red;
                    lblReceiveMaterial.ForeColor = Color.White;
                    lblMachineComplete.BackColor = Color.Red;
                    lblMachineComplete.ForeColor = Color.White;
                    lblReadyCheck.BackColor = Color.Red;
                    lblReadyCheck.ForeColor = Color.White;
                    lblReadySource.BackColor = Color.Red;
                    lblReadySource.ForeColor = Color.White;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            object[] items = chklistbox.CheckedItems.OfType<object>().ToArray();
            var target = "Lot";
            string baseid = "";
            string jobnumber = strjobnumber.Substring(0, 8);

            if (chklistbox.CheckedItems.Count == 0)
            {
                MessageBox.Show("You didn't check anything dope. TRY AGAIN");

            }
            else
            {
                target += strjobnumber.Substring(11, 2);
                bool has = items.Contains(target);

                if (has == true)
                {

                    string lots = "";

                    TestEntities db = new TestEntities();

                    for (int o = 0; o < items.Length; o++)
                    {
                        baseid = jobnumber;
                        baseid += " / " + items[o].ToString().Substring(3, 2);

                        ImportantDate iDate = db.ImportantDates.Find(strjobnumber);


                        dtDataRelease = dtpDataRls.Value.Date;
                        dtReceiveMaterial = dtpReceive.Value.Date;
                        dtStartFab = dtpFab.Value.Date;
                        dtHeatTreat = dtpHt.Value.Date;
                        dtStartMachining = dtpMach.Value.Date;
                        dtMachineComplete = dtpMachComp.Value.Date;
                        dtStartAssembly = dtpAssy.Value.Date;
                        dtReadyCheck = dtpRdyChk.Value.Date;
                        dtReadySource = dtpRdySrc.Value.Date;


                        try
                        {
                            if (iDate == null)
                            {
                                iDate = new ImportantDate();
                                iDate.BaseID = strjobnumber; 
                                if (bmaterial == true)
                                {
                                    iDate.RecvMaterial = dtReceiveMaterial;
                                }
                                else iDate.RecvMaterial = null;
                                if (bfab == true)
                                {
                                    iDate.StartFab = dtStartFab;
                                }
                                else iDate.StartFab = null;
                                if (bht == true)
                                {
                                    iDate.HeatTreat = dtHeatTreat;
                                }
                                else iDate.HeatTreat = null;
                                if (bsmach == true)
                                {
                                    iDate.StartMachining = dtStartMachining;
                                }
                                else iDate.StartMachining = null;
                                if (bassy == true)
                                {
                                    iDate.StartAssy = dtStartAssembly;
                                }
                                else iDate.StartAssy = null;
                                if (bmachcomp == true)
                                {
                                    iDate.MachComp = dtMachineComplete;
                                }
                                else iDate.MachComp = null; 
                                if (bchk == true)
                                {
                                    iDate.RdyChk = dtReadyCheck;
                                }
                                else iDate.RdyChk = null;
                                if (bsrc == true)
                                {
                                    iDate.RdySrc = dtReadySource;
                                }
                                else iDate.RdySrc = null;
                                if (bdesrel == true)
                                {
                                    iDate.DesRel = dtDataRelease;
                                }
                                else iDate.DesRel = null; 

                                //iDate.BaseID = strjobnumber;
                                //iDate.RecvMaterial = dtReceiveMaterial;
                                //iDate.StartFab = dtStartFab;
                                //iDate.HeatTreat = dtHeatTreat;
                                //iDate.StartMachining = dtStartMachining;
                                //iDate.StartAssy = dtStartAssembly;
                                //iDate.MachComp = dtMachineComplete;
                                //iDate.RdyChk = dtReadyCheck;
                                //iDate.RdySrc = dtReadySource;
                                //iDate.DesRel = dtDataRelease;

                                db.ImportantDates.Add(iDate);
                                db.SaveChanges();
                                
                            }

                            else
                            {
                                iDate.BaseID = strjobnumber;

                                if (bmaterial == true)
                                {
                                    iDate.RecvMaterial = dtReceiveMaterial;
                                }
                                else iDate.RecvMaterial = null;
                                if (bfab == true)
                                {
                                    iDate.StartFab = dtStartFab;
                                }
                                else iDate.StartFab = null;
                                if (bht == true)
                                {
                                    iDate.HeatTreat = dtHeatTreat;
                                }
                                else iDate.HeatTreat = null;
                                if (bsmach == true)
                                {
                                    iDate.StartMachining = dtStartMachining;
                                }
                                else iDate.StartMachining = null;
                                if (bassy == true)
                                {
                                    iDate.StartAssy = dtStartAssembly;
                                }
                                else iDate.StartAssy = null;
                                if (bmachcomp == true)
                                {
                                    iDate.MachComp = dtMachineComplete;
                                }
                                else iDate.MachComp = null;
                                if (bchk == true)
                                {
                                    iDate.RdyChk = dtReadyCheck;
                                }
                                else iDate.RdyChk = null;
                                if (bsrc == true)
                                {
                                    iDate.RdySrc = dtReadySource;
                                }
                                else iDate.RdySrc = null;
                                if (bdesrel == true)
                                {
                                    iDate.DesRel = dtDataRelease;
                                }
                                else iDate.DesRel = null; 
                                // db.ImportantDates.Add(iDate);
                                db.SaveChanges();
                            }
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

                        finally
                        {
                            this.dgvActuals.Refresh();
                            this.dgvActuals.Refresh(); 

                        }


                        //impdate.BaseID;
                    }

                    MessageBox.Show("Successfully Updated " + items.Length + " items. GREAT JOB!!!");


                }
            }


            //dtDataRelease = dtpDataRls.Value.Date;
            //dtReceiveMaterial = dtpReceive.Value.Date;
            //dtStartFab = dtpFab.Value.Date;
            //dtHeatTreat = dtpHt.Value.Date;
            //dtStartMachining = dtpMach.Value.Date;
            //dtMachineComplete = dtpMachComp.Value.Date;
            //dtStartAssembly = dtpAssy.Value.Date;
            //dtReadyCheck = dtpRdyChk.Value.Date;
            //dtReadySource = dtpRdySrc.Value.Date;






            //using (var db = new TestEntities())
            //{
            //    Link link = db.Links.Find(jobnumber); 

            //    if (link != null)
            //    {
            //        MessageBox.Show("A lot link Exists for this job");
            //    }


            //    ImportantDate iDate = db.ImportantDates.Find(strjobnumber);
            //    if (iDate != null)
            //    {
            //        iDate.BaseID = strjobnumber;
            //        iDate.RecvMaterial = dtReceiveMaterial;
            //        iDate.StartFab = dtStartFab;
            //        iDate.HeatTreat = dtHeatTreat;
            //        iDate.StartMachining = dtStartMachining;
            //        iDate.StartAssy = dtStartAssembly;
            //        iDate.MachComp = dtMachineComplete;
            //        iDate.RdyChk = dtReadyCheck;
            //        iDate.RdySrc = dtReadySource;
            //        iDate.DesRel = dtDataRelease;
            //        db.SaveChanges();
            //        MessageBox.Show("Dates Updated. GREAT JOB!");

            //    }
            //    else
            //    {
            //        ImportantDate iDate2 = new ImportantDate();

            //        iDate2.BaseID = strjobnumber;
            //        iDate2.RecvMaterial = dtReceiveMaterial;
            //        iDate2.StartFab = dtStartFab;
            //        iDate2.HeatTreat = dtHeatTreat;
            //        iDate2.StartMachining = dtStartMachining;
            //        iDate2.StartAssy = dtStartAssembly;
            //        iDate2.MachComp = dtMachineComplete;
            //        iDate2.RdyChk = dtReadyCheck;
            //        iDate2.RdySrc = dtReadySource;
            //        iDate2.DesRel = dtDataRelease;
            //        db.ImportantDates.Add(iDate2);
            //        db.SaveChanges();
            //        MessageBox.Show("Dates Saved. GREAT JOB!");

            //    }

        
        }

        private void dgvBaseline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnActual_Click(object sender, EventArgs e)
        {
            object[] items = chklistbox.CheckedItems.OfType<object>().ToArray();
          //  var target = "Lot";
            string baseid = "";
            string jobnumber = strjobnumber;

          
                //target += strjobnumber.Substring(11, 2);
                //bool has = items.Contains(target);

                //if (has == true)
                //{
                    
                    TestEntities db = new TestEntities();

                    //for (int o = 0; o < items.Length; o++)
                    //{
                        baseid = jobnumber;
                        //baseid += " / " + items[o].ToString().Substring(3, 2);

                        BondActual bActual = new BondActual(); 

                     //   ImportantDate iDate = db.ImportantDates.Find(strjobnumber);


                        //dtDataRelease = dtpDataRls.Value.Date;
                        //dtReceiveMaterial = dtpReceive.Value.Date;
                        //dtStartFab = dtpFab.Value.Date;
                        //dtHeatTreat = dtpHt.Value.Date;
                        //dtStartMachining = dtpMach.Value.Date;
                        //dtMachineComplete = dtpMachComp.Value.Date;
                        //dtStartAssembly = dtpAssy.Value.Date;
                        //dtReadyCheck = dtpRdyChk.Value.Date;
                        //dtReadySource = dtpRdySrc.Value.Date;


                      
                              //  bActual = new ImportantDate();
                                bActual.BaseID = strjobnumber;
                                if (bmaterial == true)
                                {
                //                    bActual.RecvMaterial = dtReceiveMaterial;
                bActual.RecvMaterial = dtpReceive.Value.Date; 
                                }
                                else bActual.RecvMaterial = null;
                                if (bfab == true)
                                {
                //bActual.StartFab = dtStartFab;
                bActual.StartFab = dtpFab.Value.Date; 
                                }
                                else bActual.StartFab = null;
                                if (bht == true)
                                {
                //  bActual.HeatTreat = dtHeatTreat;
                bActual.HeatTreat = dtpHt.Value.Date; 
                                }
                                else bActual.HeatTreat = null;
                                if (bsmach == true)
                                {
                //bActual.StartMachining = dtStartMachining;
                bActual.StartMachining = dtpMach.Value.Date; 
                                }
                                else bActual.StartMachining = null;
                                if (bassy == true)
                                {
                //                    bActual.StartAssy = dtStartAssembly;
                bActual.StartAssy = dtpAssy.Value.Date; 
                                }
                                else bActual.StartAssy = null;
                                if (bmachcomp == true)
                                {
                //  bActual.MachComp = dtMachineComplete;
                bActual.MachComp = dtpMachComp.Value.Date; 
                                }
                                else bActual.MachComp = null;
                                if (bchk == true)
                                {
                //bActual.RdyChk = dtReadyCheck;
                bActual.RdyChk = dtpRdyChk.Value.Date; 
                                }
                                else bActual.RdyChk = null;
                                if (bsrc == true)
                                {
                // bActual.RdySrc = dtReadySource;
                bActual.RdySrc = dtpRdySrc.Value.Date; 
                                }
                                else bActual.RdySrc = null;
                                if (bdesrel == true)
                                {
                // bActual.DesRel = dtDataRelease;
                bActual.DesRel = dtpDataRls.Value.Date; 
                                }
                                else bActual.DesRel = null;

                                //bActual.BaseID = strjobnumber;
                                //bActual.RecvMaterial = dtReceiveMaterial;
                                //bActual.StartFab = dtStartFab;
                                //bActual.HeatTreat = dtHeatTreat;
                                //bActual.StartMachining = dtStartMachining;
                                //bActual.StartAssy = dtStartAssembly;
                                //bActual.MachComp = dtMachineComplete;
                                //bActual.RdyChk = dtReadyCheck;
                                //bActual.RdySrc = dtReadySource;
                                //bActual.DesRel = dtDataRelease;

                                db.BondActuals.Add(bActual);
                                db.SaveChanges();
                                  this.dgvActuals.Refresh();
                                  this.dgvBaseline.Refresh(); 
            MessageBox.Show("Successfully Updated " + items.Length + " items. GREAT JOB!!!");



            //else
            //{
            //    bActual.BaseID = strjobnumber;

            //    if (bmaterial == true)
            //    {
            //        bActual.RecvMaterial = dtReceiveMaterial;
            //    }
            //    else bActual.RecvMaterial = null;
            //    if (bfab == true)
            //    {
            //        bActual.StartFab = dtStartFab;
            //    }
            //    else bActual.StartFab = null;
            //    if (bht == true)
            //    {
            //        bActual.HeatTreat = dtHeatTreat;
            //    }
            //    else bActual.HeatTreat = null;
            //    if (bsmach == true)
            //    {
            //        bActual.StartMachining = dtStartMachining;
            //    }
            //    else bActual.StartMachining = null;
            //    if (bassy == true)
            //    {
            //        bActual.StartAssy = dtStartAssembly;
            //    }
            //    else bActual.StartAssy = null;
            //    if (bmachcomp == true)
            //    {
            //        bActual.MachComp = dtMachineComplete;
            //    }
            //    else bActual.MachComp = null;
            //    if (bchk == true)
            //    {
            //        bActual.RdyChk = dtReadyCheck;
            //    }
            //    else bActual.RdyChk = null;
            //    if (bsrc == true)
            //    {
            //        bActual.RdySrc = dtReadySource;
            //    }
            //    else bActual.RdySrc = null;
            //    if (bdesrel == true)
            //    {
            //        bActual.DesRel = dtDataRelease;
            //    }
            //    else bActual.DesRel = null;
            //    // db.ImportantDates.Add(bActual);
            //    db.SaveChanges();
            //}
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        //catch (DbEntityValidationException f)
        //{
        //    foreach (var eve in f.EntityValidationErrors)
        //    {
        //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
        //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
        //        foreach (var ve in eve.ValidationErrors)
        //        {
        //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
        //                ve.PropertyName, ve.ErrorMessage);
        //        }
        //    }
        //    throw;
        //}


        //impdate.BaseID;



    }

                   


                }
            
    

            //dtDataRelease = dtpDataRls.Value.Date;
            //dtReceiveMaterial = dtpReceive.Value.Date;
            //dtStartFab = dtpFab.Value.Date;
            //dtHeatTreat = dtpHt.Value.Date;
            //dtStartMachining = dtpMach.Value.Date;
            //dtMachineComplete = dtpMachComp.Value.Date;
            //dtStartAssembly = dtpAssy.Value.Date;
            //dtReadyCheck = dtpRdyChk.Value.Date;
            //dtReadySource = dtpRdySrc.Value.Date;






            //using (var db = new TestEntities())
            //{
            //    Link link = db.Links.Find(jobnumber); 

            //    if (link != null)
            //    {
            //        MessageBox.Show("A lot link Exists for this job");
            //    }


            //    ImportantDate iDate = db.ImportantDates.Find(strjobnumber);
            //    if (iDate != null)
            //    {
            //        iDate.BaseID = strjobnumber;
            //        iDate.RecvMaterial = dtReceiveMaterial;
            //        iDate.StartFab = dtStartFab;
            //        iDate.HeatTreat = dtHeatTreat;
            //        iDate.StartMachining = dtStartMachining;
            //        iDate.StartAssy = dtStartAssembly;
            //        iDate.MachComp = dtMachineComplete;
            //        iDate.RdyChk = dtReadyCheck;
            //        iDate.RdySrc = dtReadySource;
            //        iDate.DesRel = dtDataRelease;
            //        db.SaveChanges();
            //        MessageBox.Show("Dates Updated. GREAT JOB!");

            //    }
            //    else
            //    {
            //        ImportantDate iDate2 = new ImportantDate();

            //        iDate2.BaseID = strjobnumber;
            //        iDate2.RecvMaterial = dtReceiveMaterial;
            //        iDate2.StartFab = dtStartFab;
            //        iDate2.HeatTreat = dtHeatTreat;
            //        iDate2.StartMachining = dtStartMachining;
            //        iDate2.StartAssy = dtStartAssembly;
            //        iDate2.MachComp = dtMachineComplete;
            //        iDate2.RdyChk = dtReadyCheck;
            //        iDate2.RdySrc = dtReadySource;
            //        iDate2.DesRel = dtDataRelease;
            //        db.ImportantDates.Add(iDate2);
            //        db.SaveChanges();
            //        MessageBox.Show("Dates Saved. GREAT JOB!");

            //    }
        
    
