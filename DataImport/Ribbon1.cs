using System;
using System.Linq;
using Microsoft.Office.Tools.Ribbon;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace DataImport
{
    public partial class Ribbon1
    {


        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Wip;Integrated Security=True";
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
            db.Batches.Add(batchinfo);


            for (int i = 2; i < 600; i++)
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
                

                //catch (DbEntityValidationException eeee)
                //{
                //    foreach (var eve in eeee.EntityValidationErrors)
                //    {

                //        MessageBox.Show(eve.Entry.Entity.GetType().Name.ToString(), eve.Entry.State.ToString());

                //    }

                //}

                //catch (DbEntityValidationException dbEx)
                //{
                //    foreach (var validationErrors in dbEx.EntityValidationErrors)
                //    {
                //        foreach (var validationError in validationErrors.ValidationErrors)
                //        {
                //            Trace.TraceInformation("Property: {0} Error: {1}",
                //                                    validationError.PropertyName,
                //                                    validationError.ErrorMessage);
                //        }
                //    }
                //}
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
            WipViewer.Main openMenu = new WipViewer.Main();
           openMenu.Show(); 
        }
    }
}
