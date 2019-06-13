using System;
using Microsoft.Office.Tools.Ribbon;
using Aspose.Tasks.Util;
using Aspose.Tasks;
using System.Windows.Forms;
using MSPROJECT = Microsoft.Office.Interop.MSProject;
using Aspose.Tasks.Saving;
using Aspose.Pdf.Facades;
using Aspose.Tasks.Visualization;
using SaveOptions = Aspose.Tasks.Saving.SaveOptions;

using MailMessage = Aspose.Email.MailMessage;
using Aspose.Email.Clients.Smtp;
using Aspose.Email.Clients;

namespace MSProjectRibbon
{
    public partial class Ribbo
    { public string projectname; 
        private void Ribbo_Load(object sender, RibbonUIEventArgs e)
        {
            Aspose.Tasks.License license = new Aspose.Tasks.License();
            license.SetLicense("R:\\wipviewer2017\\asposelic\\Aspose.Tasks.lic");
            
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            DateTime currentdate = System.DateTime.Now; 
            
            #region get path and project info

            //get active project and path

            MSPROJECT.Project project1 = Globals.ThisAddIn.Application.ActiveProject;

            string projectpath = project1.Path.ToString();
            projectname = project1.Name.ToString();

            string datadir = projectpath;

            bool baseline_ = false; 

            //project1.SaveAs(datadir + "\\" + "temp.mpp");

            DialogResult result = MessageBox.Show("All Projects Will Be Saved and Closed. Proceed?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {

                if (result == DialogResult.Yes)
                {
                    
                    Globals.ThisAddIn.Application.FileCloseAllEx(MSPROJECT.PjSaveType.pjSave);
                   
                    Aspose.Tasks.Project prj = new Aspose.Tasks.Project(datadir + "\\" + projectname);
                   
                    // Declare ChildTasksCollector class object
                    ChildTasksCollector collector = new ChildTasksCollector();

                    // Use TaskUtils to get all children tasks in RootTask
                    TaskUtils.Apply(prj.RootTask, collector, 0);

                    //create entity
                    SchedulingEntities db = new SchedulingEntities();
                    Schedule_Actual actual = new Schedule_Actual();

                    Schedule_Baseline baseline = new Schedule_Baseline();


                    #region view all tasks
                   
                    DialogResult baselineresult = MessageBox.Show("Create/Update Baseline?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (baselineresult == DialogResult.Yes)
                    {
                        baseline_ = true;
                    }
                    else
                    {
                    }


                    foreach (Task tsk2 in collector.Tasks)
                    {
                        Calendar tskCal = tsk2.Get(Tsk.Calendar);
                        string taskinfo = tsk2.ToString();
                        int id1 = tsk2.Get(Tsk.Id);

                        if (id1 == 0)
                        {
                            string jobnumber = tsk2.Get(Tsk.Name);

                            actual.job = jobnumber;
                            actual.createdate = currentdate;

                            if (baseline_ == true)
                            {
                                baseline.job = jobnumber;
                                baseline.createdate = currentdate;
                            }


                        }
                        if (tsk2.Get(Tsk.Name) == "Design")
                        {
                            DateTime designStart = tsk2.Get(Tsk.Start);
                            DateTime designEnd = tsk2.Get(Tsk.Finish);

                            actual.designend = designEnd;
                            actual.designstart = designStart;

                            if (baseline_ == true)
                            {
                                baseline.designstart = designStart;
                                baseline.designend = designEnd;
                            }


                        }

                        if (tsk2.Get(Tsk.Name) == "Processing")
                        {
                            DateTime processingStart = tsk2.Get(Tsk.Start);
                            DateTime processingEnd = tsk2.Get(Tsk.Finish);

                            actual.processingend = processingEnd;
                            actual.processingstart = processingStart;

                            if (baseline_ == true)
                            {
                                baseline.processingend = processingEnd;
                                baseline.processingstart = processingStart;
                            }

                        }

                        if (tsk2.Get(Tsk.Name) == "Weld Fab")
                        {
                            DateTime weldStart = tsk2.Get(Tsk.Start);
                            DateTime weldEnd = tsk2.Get(Tsk.Finish);

                            actual.weldstart = weldStart;
                            actual.weldend = weldEnd;

                            if (baseline_ == true)
                            {
                                baseline.weldstart = weldStart;
                                baseline.weldend = weldEnd;
                            }
                        }

                        if (tsk2.Get(Tsk.Name) == "Machine")
                        {
                            DateTime machineStart = tsk2.Get(Tsk.Start);
                            DateTime machineEnd = tsk2.Get(Tsk.Finish);

                            actual.machineend = machineEnd;
                            actual.machinestart = machineStart;

                            if (baseline_ == true)
                            {
                                baseline.machineend = machineEnd;
                                baseline.machinestart = machineStart;
                            }
                        }

                        if (tsk2.Get(Tsk.Name) == "Assembly")
                        {
                            DateTime assemblyStart = tsk2.Get(Tsk.Start);
                            DateTime assemblyEnd = tsk2.Get(Tsk.Finish);

                            actual.assemblystart = assemblyStart;
                            actual.assemblyend = assemblyEnd;

                            if (baseline_ == true)
                            {
                                baseline.assemblyend = assemblyEnd;
                                baseline.assemblystart = assemblyStart;
                            }

                        }

                        if (tsk2.Get(Tsk.Name) == "QA BUY OFF")
                        {
                            DateTime qaStart = tsk2.Get(Tsk.Start);
                            DateTime qaEnd = tsk2.Get(Tsk.Finish);

                            actual.qastart = qaStart;
                            actual.qaend = qaEnd;

                            if (baseline_ == true)
                            {
                                baseline.qaend = qaEnd;
                                baseline.qastart = qaStart;
                            }
                        }

                        if (tsk2.Get(Tsk.Name) == "Material")
                        {
                            DateTime matStart = tsk2.Get(Tsk.Start);
                            DateTime matEnd = tsk2.Get(Tsk.Finish);

                            actual.materialstart = matStart;
                            actual.materialend = matEnd; 

                            if (baseline_ == true)
                            {
                                baseline.materialstart = matStart;
                                baseline.materialend = matEnd; 
                            }
                        }
                    }

                    db.Schedule_Actual.Add(actual);

                    if (baseline_ == true)
                    {
                        db.Schedule_Baseline.Add(baseline);
                    }
                    db.SaveChanges();

                    SaveOptions saveOptions = new PdfSaveOptions();
                    saveOptions.PageSize = PageSize.Ledger;
                    saveOptions.SaveFormat.Equals(SaveFileFormat.PDF);
                    saveOptions.FitContent = true;
                    saveOptions.Timescale = Timescale.ThirdsOfMonths;
                    saveOptions.PresentationFormat = PresentationFormat.GanttChart;
                    saveOptions.LegendOnEachPage = false;

                    projectname = projectname.Replace("-", "_"); 

                    string filename = "R:\\wipviewer2017\\prjfiles\\" + projectname + ".pdf";


                    prj.Save(filename, saveOptions);

                    email_team(filename);
                    PdfPageEditor pEdit = new PdfPageEditor();

                }

                #endregion







                else if (result == DialogResult.No)
                {
                    // DO NOTHING
                }

            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
                #endregion


            }

        void email_team(string filename)
        {
            
            
            string subject = "An update has been made to: " + projectname;
            string username = Environment.UserName;
            string body = username + " has made changes to the project file for " + projectname + ". According" +
                "to the most recent information in the WIPviewer, you are on the team for this job. To view the full" +
                " project, please see the attached .pdf copy.";

            MailMessage msg = new MailMessage("jrotary@vistool.com", "jrotary@vistool.com", subject, body);
            Aspose.Email.Attachment attachment = new Aspose.Email.Attachment(filename);
            msg.AddAttachment(attachment); 


            SmtpClient client = new SmtpClient();

            client.Host = "mail.vistool.com";
            client.Username = "visioneering\\jrotary";
            client.Password = "blast994";
            client.Port = 587;
            client.SecurityOptions = SecurityOptions.None;



            

           
            try
            {
                // Client.Send will send this message
                client.Send(msg);
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
                
               // Trace.WriteLine(ex.ToString());
            }
        }

    }

   

    }


