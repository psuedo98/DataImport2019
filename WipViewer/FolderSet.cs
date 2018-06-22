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

namespace WipViewer
{
  

    public partial class FolderSet : Form
    {
        // public jobNumber; 
        
        string jobnumber;
        public bool bPM;
        public bool bProc;
        public bool bWeld;
        public bool bMach;
        public bool bBuild;

       

        DateTime dtMach;
        DateTime dtWeld;
        DateTime dtPM;
        DateTime dtProc;
        DateTime dtBuild; 
       
        

        public FolderSet()
        {
            InitializeComponent();
        }

        public FolderSet(string content)
        {

            
            InitializeComponent(); 
         jobnumber = content;


            using (var db = new TestEntities())
            {
                
                 Folder fFolder = db.Folders.Find(jobnumber.Trim());
                

                if (fFolder != null)

                {
                    if (fFolder.BuildFolder != null)
                    {
                        dtpBuild.Value = fFolder.BuildFolder.Value;
                    }

                    if (fFolder.PMFolder != null)
                    {
                        dtpPM.Value = fFolder.PMFolder.Value;
                    }

                    if (fFolder.MachineFolder != null)
                    {
                        dtpMachine.Value = fFolder.MachineFolder.Value;
                    }

                    if (fFolder.ProcessingFolder != null)
                    {
                        dtpProcessor.Value = fFolder.ProcessingFolder.Value;
                    }

                    if (fFolder.WeldFolder != null)
                    {
                        dtpWeld.Value = fFolder.WeldFolder.Value;
                    }
                }
            }
        }
            

            



        private void FolderSet_Load(object sender, EventArgs e)
        {

        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
           TestEntities db = new TestEntities();
            Folder fFolder = db.Folders.Find(jobnumber.Substring(0,15));

            dtPM = dtpPM.Value.Date; 

            

            if (fFolder == null)

            { 
                fFolder = new Folder();
                fFolder.JobNumber = jobnumber.Substring(0,15); 
                if (bPM == true)
                {
                    fFolder.PMFolder = dtpPM.Value.Date; 
                }

                if (bProc == true)
                {
                    fFolder.ProcessingFolder = dtpProcessor.Value.Date;
                }

                if (bWeld == true)
                {
                    fFolder.WeldFolder = dtpWeld.Value.Date;
                }

                if (bMach == true)
                {
                    fFolder.MachineFolder = dtpMachine.Value.Date;

                }

                if (bBuild == true)
                {
                    fFolder.BuildFolder = dtpBuild.Value.Date;
                }

                try
                {

                    db.Folders.Add(fFolder);
                    db.SaveChanges();

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


                else 

                {


                if (bPM == true)
                {
                    fFolder.PMFolder = dtpPM.Value.Date;
                }

                if (bProc == true)
                {
                    fFolder.ProcessingFolder = dtpProcessor.Value.Date;
                }

                if (bWeld == true)
                {
                    fFolder.WeldFolder = dtpWeld.Value.Date;
                }

                if (bMach == true)
                {
                    fFolder.MachineFolder = dtpMachine.Value.Date;

                }

                if (bBuild == true)
                {
                    fFolder.BuildFolder = dtpBuild.Value.Date;
                }

                db.SaveChanges();

            }
            

           
            MessageBox.Show("Folder Updated. NICE JOB!");

        }

        private void dtpPM_changed(object sender, EventArgs e)
        {
            bPM = true;
        }
        private void dtpProcessing_changed(object sender, EventArgs e)
        {
            bProc = true;
        }
        private void dtpWeld_changed(object sender, EventArgs e)
        {
            bWeld = true;
        }
        private void dtpMachine_changed(object sender, EventArgs e)
        {
            bMach = true;
        }
        private void dtpBuild_changed(object sender, EventArgs e)
        {
            bBuild  = true;
        }
    }
}
