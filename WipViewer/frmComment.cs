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
    public partial class frmComment : Form
    {

        jobview2 _owner;
        testjobview _owner1;
        JobView4 __owner;
      

        public frmComment(jobview2 owner, string jobnumber)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComment_FormClosing);
            strJobNumber = jobnumber;
        }

        public frmComment(JobView4 owner, string jobnumber)
        {
            InitializeComponent();
            __owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComment_FormClosing);
            strJobNumber = jobnumber;
        }


        public frmComment(testjobview owner, string jobnumber)
        {
            InitializeComponent();
            _owner1 = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComment_FormClosing);
            strJobNumber = jobnumber;
        }

        private void frmComment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_owner != null)
            {
                _owner.PerformRefresh();
            }
            else if( __owner != null)
            {
                __owner.PerformRefresh();
            }
        }

        public string strJobNumber;
        public frmComment()
        {
            InitializeComponent();
        }

        public frmComment(string jobnumber)
        {
            InitializeComponent();
            strJobNumber = jobnumber; 

        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            this.Text = "Enter a comment for: " + strJobNumber; 

        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnComment_Click(this, new EventArgs());
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            TestEntities db1 = new TestEntities(); 
          //  CommentEntities db = new CommentEntities();
            comment dbComment = new comment(); 
                       
            dbComment.baseid = strJobNumber;
            dbComment.date = DateTime.Now.Date;
            dbComment.comment1 = txtComment.Text;
            dbComment.commenter = Environment.UserName; 

            db1.comments.Add(dbComment);
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

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Call Jacob. Give him this error: " + ex);

            }

            finally
            {
             //   MessageBox.Show("Comment Saved.");
                this.Close(); 
                

            }


            //adoEntities db = new adoEntities();

            //JobHour batch = new JobHour();

        }
    }
}
