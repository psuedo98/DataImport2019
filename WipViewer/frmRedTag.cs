using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using System.Linq;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace WipViewer
{
    public partial class frmRedTag : Form
    {
        public frmRedTag()
        {
            InitializeComponent();

            using (var db2 = new TestEntities())
            {

                var defectCodes = (from em in db2.Reasons
                                   where em.Code.StartsWith("D")
                                   select new { Code = em.Code, Description = em.Detail });


                var scripts = (from em in db2.Reasons
                               where em.Code.StartsWith("D")
                               select em.Detail).ToArray(); 

                // cmbDefect.DataSource = (from em in db2.Reasons
                //                            where em.Code.StartsWith("D")
                //                         select em).ToList(); 
                cmbDefect.DataSource = defectCodes.ToList();
                cmbDefect.DisplayMember = "Description";

                AutoCompleteStringCollection autoc = new AutoCompleteStringCollection();

                autoc.AddRange(scripts);

                cmbDefect.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbDefect.AutoCompleteCustomSource = autoc;
                cmbDefect.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var causeCodes = (from em in db2.Reasons
                                  where em.Code.StartsWith("C")
                                  select new { Code = em.Code, Description = em.Detail });
                scripts = (from em in db2.Reasons
                           where em.Code.StartsWith("C")
                           select em.Detail).ToArray();

                cmbCause.DataSource = causeCodes.ToList();
                cmbCause.DisplayMember = "Description";

                AutoCompleteStringCollection autoc2 = new AutoCompleteStringCollection();


                autoc2.AddRange(scripts);

                cmbCause.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCause.AutoCompleteCustomSource = autoc2;
                cmbCause.AutoCompleteSource = AutoCompleteSource.CustomSource;












                var deptCodes = (from em in db2.Reasons
                                  where em.Code.StartsWith("R")
                                  select new { Code = em.Code, Description = em.Detail });
                scripts = (from em in db2.Reasons
                           where em.Code.StartsWith("R")
                           select em.Detail).ToArray();

                

                cmbDept.DataSource = deptCodes.ToList();
                cmbDept.DisplayMember = "Description";

                AutoCompleteStringCollection autoc3 = new AutoCompleteStringCollection();


                autoc3.AddRange(scripts);

                cmbDept.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbDept.AutoCompleteCustomSource = autoc3;
                cmbDept.AutoCompleteSource = AutoCompleteSource.CustomSource;





            }
        }


        public frmRedTag(int tagnumber)
        {
            InitializeComponent();
            int iTagnumber = Convert.ToInt16(tagnumber); 

            TestEntities db = new TestEntities();

            tblRedTag rt1 = db.tblRedTags.Find(iTagnumber);

            Reason rs1 = new Reason();

            using (var db2 = new TestEntities())
            {
                cmbDefect.DataSource = db2.Reasons.SqlQuery("select Code from dbo.reasons where code like '%D'"); 
            }

                if (rt1 != null)
                {
                    txtTag.Text = rt1.ID.ToString();

                    if (rt1.JOB != null)
                    {
                        txtJob.Text = rt1.JOB;
                    }

                    if (rt1.Detail != null)
                    {
                        txtTool.Text = rt1.Detail;
                    }

                    if (rt1.Initiator != null)
                    {
                        cmbInitiator.Text = rt1.Initiator;
                    }
                    if (rt1.Dept != null)
                    {

                        cmbDept.Text = rt1.Dept;
                    }
                    if (rt1.Spec != null)
                    {

                        txtSpec.Text = rt1.Spec;
                    }

                    if (rt1.Condition != null)
                    {

                        txtCondition.Text = rt1.Condition;

                    }


                    if (rt1.Date != null)
                    {

                        dtpInspection.Text = rt1.Date.ToString();

                    }

                    if (rt1.Defect != null)
                    {

                        cmbDefect.Text = rt1.Defect;

                    }

                    if (rt1.Cause != null)
                    {

                        cmbCause.Text = rt1.Cause;

                    }

                    if (rt1.Reinspection != null)
                    {

                        dtpReinspection.Text = rt1.Reinspection.ToString();

                    }

                    if (rt1.Cost != null)
                    {

                        txtRework.Text = rt1.Cost.ToString();

                    }


                    if (rt1.InstanceCost != null)
                    {

                        txtInstance.Text = rt1.InstanceCost.ToString();

                    }


                    if (rt1.ScrapCost != null)
                    {


                        txtScrap.Text = rt1.ScrapCost.ToString();

                    }

                    if (rt1.VendorPO != null)
                    {


                        txtVendor.Text = rt1.VendorPO;

                    }

                    if (rt1.Instructions != null)
                    {


                        txtInstructions.Text = rt1.Instructions;

                    }

                    if (rt1.Comment != null)
                    {


                        txtComments.Text = rt1.Comment;

                    }






                    // cmbDisposition.Text = rt1.










                }



        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            int strTag = Convert.ToInt16(txtTag.Text);
            string strJob = txtJob.Text;
            string strTool = txtTool.Text;
            string strInitiator = cmbInitiator.Text;
            string strDept = cmbDept.Text;
            string strSpec = txtSpec.Text;
            string strCondition = txtCondition.Text;
            string strDefect = cmbDefect.Text;
            string strCause = cmbCause.Text;
            string strDisposition = cmbDisposition.Text; 
          //  string strDisposition = cmbDisposition.Text;

            bool bCar = chkCar.Checked; 

            int strRework = 0; 

            if (txtRework == null)
            {
                strRework = 0;
                    
            }
            else
            {

                //  strRework = Convert.ToInt16(txtRework.Text);
                strRework = 0; 
            }
            
            
            int strInstance = Convert.ToInt16(txtInstance.Text);
            int strScrap = Convert.ToInt16(txtScrap.Text);
            string strVendor = txtVendor.Text;
            string strInstructions = txtInstructions.Text;
            string strComments = txtComments.Text;





            DateTime dtInspection = dtpInspection.Value.Date;
            DateTime dtReinspection = dtpReinspection.Value.Date;

            var db = new TestEntities();

            tblRedTag rt = db.tblRedTags.Find(strTag);    
            Job check = db.Jobs.Find(strJob);

            if (rt != null)
            {
                DialogResult dialogResult = MessageBox.Show("This Tag ID Already Exists. Update?", "Tag Exists!", MessageBoxButtons.YesNo); 

                if (dialogResult == DialogResult.Yes)
                {
                    if (check != null)
                    {


                        rt.ID = strTag;
                        rt.JOB = strJob;
                        rt.Detail = strTool;
                        rt.Initiator = strInitiator;
                        rt.Dept = strDept;
                        rt.Spec = strSpec;
                        rt.Condition = strCondition;
                        rt.Date = dtInspection;
                        rt.Defect = strDefect;
                        rt.Cause = strCause;
                        rt.Instructions = strInstructions;
                        rt.Comment = strComments;
                        rt.Reinspection = dtReinspection;
                        rt.Cost = strRework;
                        rt.InstanceCost = strInstance;
                        rt.ScrapCost = strScrap;
                        rt.VendorPO = strVendor;


                        try
                        {
                         //   db.tblRedTags(rt)
                            db.SaveChanges();
                            bool bEmail = true;
                            Team jobTeam = db.Teams.Find(strJob);

                            if (jobTeam != null)
                            {

                                bEmail = true;
                                string strSubject = "Red Tag # " + strTag + " Updated";
                                string strBody = "A red tag has been updated. <br> You are receiving this email because you are part of the job team. <br><br><b>THIS IS A TEST OF THE WIPVIEWER RED TAG EMAIL SYSTEM.</b> <br><br>";
                                strBody += "<br>Here is some information about the Tag: <br>Tag Number: " + strTag + "<br>Job Number: " + strJob + "<br>Tool #: " + strTool + "<br>Initiator: " + strInitiator + "<br>Department #: " + strDept;


                                Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();

                                MailItem eMail = (MailItem)oApp.CreateItem(OlItemType.olMailItem);


                                Recipients oRecips = (Recipients)eMail.Recipients;
                                eMail.Subject = strSubject;
                                eMail.Body = strBody;
                                eMail.Importance = OlImportance.olImportanceLow;

                                eMail.BodyFormat = OlBodyFormat.olFormatHTML;



                                if (jobTeam.ProgramManager != null)
                                {



                                    Recipient oRecip = (Recipient)oRecips.Add("jrotary@vistool.com");




                                }


                                if (jobTeam.Processor != null)
                                {

                                    //eMail.To = "jrotary@vistool.com";

                                    Recipient oRecip = (Recipient)oRecips.Add("mkazhukauskas@vistool.com");
                                }


                                if (jobTeam.BuildLeader != null)
                                {
                                    Recipient oRecip = (Recipient)oRecips.Add("jfranz@vistool.com");
                                }

                                eMail.HTMLBody = strBody;


                                eMail.Send();


                            }

                            else
                            {
                                bEmail = false;
                            }


                            if (bEmail == true)
                            {
                                MessageBox.Show("Success. Email Sent");
                            }

                            else
                            {
                                MessageBox.Show("Red Tag created, but no Team for job present. No Email sent.");

                            }


                        }

                        catch(System.Exception ex)
                        { }


                    }

                    else
                    {
                        MessageBox.Show("That Job Does not exist. You may have your formatting wrong. In WipViewer, Jobs are always formatted 'XXXX9999 / 9'. If you have any questions, please contact Jacob Rotary");

                    }
                }
                else
                {
                    
                }
            }

            else
            {
                if (check != null)
                {
                    tblRedTag rt2 = new tblRedTag(); 


                    rt2.ID = strTag;
                    rt2.JOB = strJob;
                    rt2.Detail = strTool;
                    rt2.Initiator = strInitiator;
                    rt2.Dept = strDept;
                    rt2.Spec = strSpec;
                    rt2.Condition = strCondition;
                    rt2.Date = dtInspection;
                    rt2.Defect = strDefect;
                    rt2.Cause = strCause;
                    rt2.Instructions = strInstructions;
                    rt2.Comment = strComments;
                    rt2.Reinspection = dtReinspection;
                    rt2.Cost = strRework;
                    rt2.InstanceCost = strInstance;
                    rt2.ScrapCost = strScrap;
                    rt2.VendorPO = strVendor;
                    rt2.Disposition = strDisposition;
                    rt2.CAR = Convert.ToString(bCar); 
                        


                    try
                    {
                        db.tblRedTags.Add(rt2);
                        db.SaveChanges();
                        bool bEmail = true;
                        Team jobTeam = db.Teams.Find(strJob);

                        if (jobTeam != null)
                        {

                            bEmail = true;
                            string strSubject = "New Red Tag created for " + strJob + " IGNORE THIS - ITS A TEST EMAIL";
                            string strBody = "A new red tag has been created. <br> You are receiving this email because you are part of the job team. <br><br><b>THIS IS A TEST OF THE WIPVIEWER RED TAG EMAIL SYSTEM.</b> <br><br>";
                            strBody += "<br>Here is some information about the Tag: <br>Tag Number: " + strTag + "<br>Job Number: " + strJob + "<br>Tool #: " + strTool + "<br>Initiator: " + strInitiator + "<br>Department #: " + strDept;


                            Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();

                            MailItem eMail = (MailItem)oApp.CreateItem(OlItemType.olMailItem);


                            Recipients oRecips = (Recipients)eMail.Recipients;
                            eMail.Subject = strSubject;
                            eMail.Body = strBody;
                            eMail.Importance = OlImportance.olImportanceLow;

                            eMail.BodyFormat = OlBodyFormat.olFormatHTML;



                            if (jobTeam.ProgramManager != null)
                            {



                                Recipient oRecip = (Recipient)oRecips.Add("jrotary@vistool.com");




                            }


                            if (jobTeam.Processor != null)
                            {

                                //eMail.To = "jrotary@vistool.com";

                                Recipient oRecip = (Recipient)oRecips.Add("mkazhukauskas@vistool.com");
                            }


                            if (jobTeam.BuildLeader != null)
                            {
                                Recipient oRecip = (Recipient)oRecips.Add("jfranz@vistool.com");
                            }

                            eMail.HTMLBody = strBody;


                            eMail.Send();


                        }

                        else
                        {
                            bEmail = false;
                        }


                        if (bEmail == true)
                        {
                            MessageBox.Show("Success. Email Sent");
                        }

                        else
                        {
                            MessageBox.Show("Red Tag created, but no Team for job present. No Email sent.");

                        }


                    }

                    //catch (System.Exception ex)
                   // { }

                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                Trace.TraceInformation("Property: {0} Error: {1}",
                                                        validationError.PropertyName,
                                                        validationError.ErrorMessage);
                            }
                        }
                    }


                }

                else
                {
                    MessageBox.Show("That Job Does not exist. You may have your formatting wrong. In WipView, Jobs are always formatted 'XXXX9999 / 9'. If you have any questions, please contact Jacob Rotary");

                }
            }

          
        }

        private void frmRedTag_Load(object sender, EventArgs e)
        {
            

        }

      

        
    }
}
