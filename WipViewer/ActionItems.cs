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
    public partial class ActionItems : Form
    {
        jobview2 _owner;
        public string strjobnumber; 
        public ActionItems()
        {
            InitializeComponent();
        }

        public ActionItems(jobview2 owner, string jobnumber)
        {

            strjobnumber = jobnumber;
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmActionItems_FormClosing);
            InitializeComponent();

        }

        private void frmActionItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh();
        }

        private void ActionItems_Load(object sender, EventArgs e)
        {
            this.Text = "Enter New Action Item for " + strjobnumber; 


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TestEntities db1 = new TestEntities(); 
           // CommentEntities db = new CommentEntities();
            ActionItem action = new ActionItem();

            string critical;
            string asignee;

            asignee = txtAssignedto.Text; 

            if (chkCritical.Checked == true)

            {
                critical = "true"; 
            }
            else
            {
                critical = "false"; 
            }


            action.Asignee = asignee; 
            action.Base = strjobnumber;
            action.CreateDate = DateTime.Now;
            action.critical = critical;
            action.Duedate = dtpDueDate.Value.Date; 
            action.Submitter = Environment.UserName;
            action.ActionRequired = txtActionReq.Text; 
            


            db1.ActionItems.Add(action);


            try
            {
                db1.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                   .SelectMany(x => x.ValidationErrors)
                   .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);

                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }


            finally
            {
              //  MessageBox.Show("Action item saved. GET TO WORK " + asignee);
                this.Close(); 

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
