using System;
using System.Linq;
using Microsoft.Office.Tools.Ribbon;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace DataImport
{
    public partial class Ribbon1
    {


        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=desktop-v09rgin\sqlexpress;Initial Catalog=Wip;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "";

        }

        private void btmImport_Click(object sender, RibbonControlEventArgs e)
        {

            Excel.Workbook xlBook = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Application xlApp = new Excel.Application();
            Excel.Worksheet xlSheet = xlBook.Sheets[1];
            Excel.Range xlRange = xlSheet.UsedRange;

            adoEntities db = new adoEntities();

            JobHour batch = new JobHour();
            


            bool check = db.JobHours.Any(u => u.Batch > 0); 


            int intID = new int();

            if (check == true)
            {
                intID = db.JobHours.Max(u => u.Batch) + 1; 
            }
            else
            {
                intID = 1;

            }

            Batch batchinfo = new Batch();
            batchinfo.Batch1 = intID;
            batchinfo.BatchDate = DateTime.Now.Date;
            batchinfo.BatchTime = DateTime.Now; 
            db.Batches.Add(batchinfo);


            for (int i = 2; i < 900; i++)
            {
               
                try
                {
                    if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                    {
                        if (xlRange.Cells[i, 1].value.ToString() != "End")
                        {
                            Job job = new Job();
                            JobMetric metrics = new JobMetric();
                            JobHour hours = new JobHour();

                            job.Base = xlRange.Cells[i, 1].Value.ToString();
                           
                            try
                            {

                                hours.BaseID = xlRange.Cells[i, 1].value();
                                hours.Batch = intID;
                                hours.Machine = (int)xlRange.Cells[i, 8].value();
                                hours.Build = (int)xlRange.Cells[i, 9].value();
                                hours.Weld = (int)xlRange.Cells[i, 10].value();
                                hours.Design = (int)xlRange.Cells[i, 11].value();
                                hours.Tracker = (int)xlRange.Cells[i, 12].value();

                                metrics.Comp = (decimal)xlRange.Cells[i, 6].Value();
                                metrics.ShipDate = xlRange.Cells[i, 7].value();
                                metrics.POValue = (decimal)xlRange.Cells[i, 4].value();
                                metrics.Actual = (decimal)xlRange.Cells[i, 5].value();
                                metrics.BaseID = xlRange.Cells[i, 1].value();
                                metrics.Type = xlRange.Cells[i, 2].value();
                                metrics.batch = intID;
                                metrics.Margin = (int)xlRange.Cells[i, 15].value();
                                metrics.RemainingRev = (int)xlRange.Cells[i, 16].value();
                                metrics.Projected = (int)xlRange.Cells[i, 14].value();
                                metrics.ContractDate = xlRange.Cells[i, 17].value(); 


                                if (db.Jobs.Any(Job => Job.Base.ToString() == job.Base) == false)
                                {
                                    db.Jobs.Add(job);
                                    db.JobMetrics.Add(metrics);
                                    db.JobHours.Add(hours);
                                    

                                }

                                else
                                {
                                    db.JobMetrics.Add(metrics);
                                    db.JobHours.Add(hours);

                                    
                                }

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show("There is an issue with the data you are trying to import. Check for data formatting issues!");
                                break;
                            }

                                                       
                        }

                        else
                        {
                            int count = i - 1;
                            MessageBox.Show("Success! " + count.ToString() + " records imported successfully");
                            break;
                        }
                    }

                    
                    else break;

                    db.SaveChanges();
                    

                }
                

              
                catch (DbUpdateException dbup)
                {
                    Debug.WriteLine(dbup.Entries.ToString());
                    Debug.WriteLine(dbup.InnerException.ToString());


                }
              
                   
                
            }
            
        }

        private void btnData_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RibbonControlEventArgs e)
        {
           // WipViewer.Main openMenu = new WipViewer.Main();
           //openMenu.Show(); 
        }

        private void btnKickoff_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Workbook xlBook = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Application xlApp = new Excel.Application();
            Excel.Worksheet xlSheet = xlBook.Sheets[1];
            Excel.Range xlRange = xlSheet.UsedRange;

            adoEntities db = new adoEntities();


            try
            {
                for (int i = 2; i < 900; i++)
                {

                    try
                    {
                        if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                        {
                            if (xlRange.Cells[i, 1].value.ToString() != "End")
                            {

                                try
                                {

                                    string jobnumber = xlRange.Cells[i, 1].Value.ToString();
                                    var jobs = from b in db.ActualsReps
                                               where b.BaseID.Equals(jobnumber)
                                               select b;
                                    if (jobs.Count() > 0)
                                    {
                                        db.ActualsReps.Remove(db.ActualsReps.Single(b => b.BaseID == jobnumber));
                                    }

                                    ActualsRep act = new ActualsRep();
                                    act.BaseID = xlRange.Cells[i, 1].Value.ToString();

                                    act.BaseID = Convert.ToString(xlRange.Cells[i, 1].value());
                                    act.Design = Convert.ToString(xlRange.Cells[i, 7].value());
                                    act.Planning = Convert.ToString(xlRange.Cells[i, 8].value());
                                    act.Waterjet = Convert.ToString(xlRange.Cells[i, 9].value());
                                    act.Weld = Convert.ToString(xlRange.Cells[i, 10].value());
                                    act.Nc = Convert.ToString(xlRange.Cells[i, 11].value());
                                    act.Machining = Convert.ToString(xlRange.Cells[i, 12].value());
                                    act.Assy = Convert.ToString(xlRange.Cells[i, 13].value());
                                    act.Inspection = Convert.ToString(xlRange.Cells[i, 14].value());
                                    act.DesignCost = Convert.ToDecimal(xlRange.Cells[i, 15].value());
                                    act.PlanningCost = Convert.ToDecimal(xlRange.Cells[i, 16].value());
                                    act.WaterJetCost = Convert.ToDecimal(xlRange.Cells[i, 17].value());
                                    act.WeldCost = Convert.ToDecimal(xlRange.Cells[i, 18].value());
                                    act.NcCost = Convert.ToDecimal(xlRange.Cells[i, 18].value());
                                    act.MachiningCost = Convert.ToDecimal(xlRange.Cells[i, 20].value());
                                    act.AssyCost = Convert.ToDecimal(xlRange.Cells[i, 21].value());
                                    act.InspectionCost = Convert.ToDecimal(xlRange.Cells[i, 22].value());
                                    act.LaborCost = Convert.ToDecimal(xlRange.Cells[i, 23].value());
                                    act.BurdenCost = Convert.ToDecimal(xlRange.Cells[i, 24].value());
                                    act.MaterialCost = Convert.ToDecimal(xlRange.Cells[i, 25].value());
                                    act.ServiceCost = 0;

                                    db.ActualsReps.Add(act);



                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.InnerException.ToString());
                                    MessageBox.Show("There is an issue with the data you are trying to import. Check for data formatting issues!");
                                    break;
                                }


                            }

                            else
                            {
                                int count = i - 1;
                                MessageBox.Show("Success! " + count.ToString() + " records imported successfully");
                                break;
                            }
                        }
                        
                        else break;

                        db.SaveChanges();

                    }
                    catch (DbEntityValidationException fe)
                    {
                        foreach (var eve in fe.EntityValidationErrors)
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

            catch (Exception enhh)
            {
                MessageBox.Show(enhh.Message.ToString());
            }
            
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application app = Globals.ThisAddIn.Application;
            Excel.Workbook wkbook = app.ActiveWorkbook;
            Excel.Worksheet wksheet = wkbook.ActiveSheet;


            string item = wksheet.Name.ToString();
            string lot = item.Substring(item.Length - 1);


            int iPlanning = 0;
            int iDesign = 0;
            int iWaterjet = 0;
            int iWeld = 0;
            int iNC = 0;
            int iConventional = 0;
            int iOutsource = 0;
            int iAssembly = 0;
            int iInspection = 0;
            int iShipping = 0;

            int iPlanningEst = 0;
            int iDesignEst = 0;
            int iWaterjetEst = 0;
            int iWeldEst = 0;
            int iNCEst = 0;
            int iConventionalEst = 0;
            int iOutsourceEst = 0;
            int iAssemblyEst = 0;
            int iInspectionEst = 0;
            int iShippingEst = 0;

            int z = 8;


            string jobnumber = wksheet.Cells[5, "BV"].Value;

            iPlanning += Convert.ToInt32(wksheet.Cells[7, "BV"].Value);
            iPlanningEst += Convert.ToInt32(wksheet.Cells[7, "BI"].Value);
            iDesign += Convert.ToInt32(wksheet.Cells[12, "BV"].Value);
            iDesignEst += Convert.ToInt32(wksheet.Cells[12, "BI"].Value);
            iWaterjet += Convert.ToInt32(wksheet.Cells[16, "BV"].Value);
            iWaterjetEst += Convert.ToInt32(wksheet.Cells[16, "BI"].Value);
            iWeld += Convert.ToInt32(wksheet.Cells[20, "BV"].Value);
            iWeldEst += Convert.ToInt32(wksheet.Cells[20, "BI"].Value);
            iNC += Convert.ToInt32(wksheet.Cells[28, "BV"].Value);
            iNCEst += Convert.ToInt32(wksheet.Cells[28, "BI"].Value);
            iConventional += Convert.ToInt32(wksheet.Cells[36, "BV"].Value);
            iConventionalEst += Convert.ToInt32(wksheet.Cells[36, "BI"].Value);
            iOutsource += Convert.ToInt32(wksheet.Cells[40, "BW"].Value);
            iOutsourceEst += Convert.ToInt32(wksheet.Cells[40, "BJ"].Value);
            iAssembly += Convert.ToInt32(wksheet.Cells[53, "BV"].Value);
            iAssemblyEst += Convert.ToInt32(wksheet.Cells[53, "BI"].Value);
            iInspection += Convert.ToInt32(wksheet.Cells[60, "BV"].Value);
            iInspectionEst += Convert.ToInt32(wksheet.Cells[60, "BI"].Value);
            iShipping += Convert.ToInt32(wksheet.Cells[67, "BV"].Value);
            iShippingEst += Convert.ToInt32(wksheet.Cells[67, "BI"].Value);

            var wip = new adoEntities(); 

            Kickoff ko = new Kickoff();

            ko.Assy = iAssembly;
            ko.AssemblyEst = iAssemblyEst;
            ko.BaseID = jobnumber;
            ko.Convetional = iConventional;
            ko.ConventionalEst = iConventionalEst;
            ko.Shipping = iShipping;
            ko.ShippingEst = iShippingEst;
            ko.Planning = iPlanning;
            ko.PlanningEst = iPlanningEst;
            ko.Design = iDesign;
            ko.DesignEst = iDesignEst;
            ko.Waterjet = iWaterjet;
            ko.WaterjetEst = iWaterjetEst;
            ko.Weld = iWeld;
            ko.WeldEst = iWeldEst;
            ko.NC = iNC;
            ko.NCEst = iNCEst;
            ko.Outsource = iOutsource;
            ko.OutsourceEst = iOutsourceEst;
            ko.Inspection = iInspection;
            ko.InspectionEst = iInspectionEst;
            ko.Design = iDesign;
            ko.DesignEst = iDesignEst;
            try
            {


                wip.Kickoffs.Add(ko);

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            try
            {
                wip.SaveChanges();
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }

            finally
            {
                MessageBox.Show("SUCCESS!!! FUCK YEA");

            }

        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
           

                try
                {
                    Excel.Application app = Globals.ThisAddIn.Application;
                    Excel.Workbook wkbook = app.ActiveWorkbook;
                    Excel.Worksheet wksheet = wkbook.ActiveSheet;

                    string jobnumber = wksheet.Cells[1, "A"].Value;

                    var wip = new adoEntities();

                    Kickoff ko = wip.Kickoffs.Find(jobnumber);
                    ActualsRep act = wip.ActualsReps.Find(jobnumber);

                    //RecordDataView recorddataview = db.RecordDataView.SingleOrDefault(m => m.Record_number == id);

                    JobMetric jo = wip.JobMetrics.FirstOrDefault(m => m.BaseID == jobnumber);
                    // JobMetric jo = wip.JobMetrics.Find(jobnumber);



                    //Quoted Hours 
                    wksheet.Cells[16, "B"].Value = ko.DesignEst;
                    wksheet.Cells[17, "B"].Value = ko.PlanningEst;
                    wksheet.Cells[18, "B"].Value = ko.WaterjetEst;
                    wksheet.Cells[19, "B"].Value = ko.WeldEst;
                    wksheet.Cells[20, "B"].Value = ko.NCEst;
                    wksheet.Cells[21, "B"].Value = ko.ConventionalEst;
                    wksheet.Cells[22, "B"].Value = ko.AssemblyEst;
                    wksheet.Cells[23, "B"].Value = ko.InspectionEst;

                    //Adjusted Hours 

                    wksheet.Cells[16, "E"].Value = ko.Design;
                    wksheet.Cells[17, "E"].Value = ko.Planning;
                    wksheet.Cells[18, "E"].Value = ko.Waterjet;
                    wksheet.Cells[19, "E"].Value = ko.Weld;
                    wksheet.Cells[20, "E"].Value = ko.NC;
                    wksheet.Cells[21, "E"].Value = ko.Convetional;
                    wksheet.Cells[22, "E"].Value = ko.Assy;
                    wksheet.Cells[23, "E"].Value = ko.Inspection;

                    //Actual Hours 
                    MessageBox.Show("Time for the Actuals");
                    try
                    {
                        wksheet.Cells[16, "H"].Value = act.Design;
                        wksheet.Cells[17, "H"].Value = act.Planning;
                        wksheet.Cells[18, "H"].Value = act.Waterjet;
                        wksheet.Cells[19, "H"].Value = act.Weld;
                        wksheet.Cells[20, "H"].Value = act.Nc;
                        wksheet.Cells[21, "H"].Value = act.Machining;
                        wksheet.Cells[22, "H"].Value = act.Assy;
                        wksheet.Cells[23, "H"].Value = act.Inspection;

                        wksheet.Cells[16, "I"].Value = act.DesignCost;
                        wksheet.Cells[17, "I"].Value = act.PlanningCost;
                        wksheet.Cells[18, "I"].Value = act.WaterJetCost;
                        wksheet.Cells[19, "I"].Value = act.WeldCost;
                        wksheet.Cells[20, "I"].Value = act.NcCost;
                        wksheet.Cells[21, "I"].Value = act.MachiningCost;
                        wksheet.Cells[22, "I"].Value = act.AssyCost;
                        wksheet.Cells[23, "I"].Value = act.InspectionCost;
                    }

                    catch (Exception ef)
                    {
                        MessageBox.Show(ef.ToString());
                    }


                    //Margin

                    wksheet.Cells[8, "I"].Value = jo.Margin;
                    wksheet.Cells[9, "I"].Value = jo.Actual;
                    wksheet.Cells[1, "F"].Value = jo.POValue;
                    wksheet.Cells[2, "F"].Value = jo.ContractDate;
                    wksheet.Cells[1, "I"].Value = "FUCKIFIKNOW";
                    wksheet.Cells[2, "I"].Value = jo.ShipDate;

                }

                catch (Exception ef)
                {
                    MessageBox.Show(ef.Message.ToString());
                }

                //Convert.ToInt32(wksheet.Cells[20, "BV"].Value);

            }
        }
    
    }

