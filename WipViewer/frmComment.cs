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

        private void btnComment_Click(object sender, EventArgs e)
        {
            CommentEntities db = new CommentEntities();
            comment dbComment = new comment(); 
            //WipEntities db = new WipEntities();
           // commentDB dbComment = new commentDB();


            
            dbComment.baseid = strJobNumber;
            dbComment.date = DateTime.Now.Date;
            dbComment.comment1 = txtComment.Text;

            db.comments.Add(dbComment);
            try
            {
                db.SaveChanges();
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
                MessageBox.Show("Comment Saved.");
                this.Close(); 

            }


            //adoEntities db = new adoEntities();

            //JobHour batch = new JobHour();

        }
    }
}
