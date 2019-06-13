using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer
{
    public partial class ActionItemReport : Form
    {
        public ActionItemReport()
        {
            InitializeComponent();
        }

        private void ActionItemReport_Load(object sender, EventArgs e)
        {
            
            this.actionItemsTableAdapter.FillbyOpen(this.ds_ActionItems.ActionItems);

            

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.IndianRed;
            style.ForeColor = Color.White;

            dgvActionItems.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvActionItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            for (int i = 0; i < dgvActionItems.RowCount; i++)
            {

                if (Convert.ToString(dgvActionItems.Rows[i].Cells[6].Value) == "true")
                {

                    dgvActionItems.Rows[i].DefaultCellStyle = style;
                }
            }
        }

        private void dgvActionItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvActionItems.SelectedRows[0].Cells[0].Value;

            DialogResult result = MessageBox.Show("Close Action Item?", "Close Action Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TestEntities db1 = new TestEntities();
                ActionItem action = db1.ActionItems.Find(id);

                action.openitem = "false";

                db1.SaveChanges();

                PerformRefresh();


            }

            //DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[6].Value);



            //jobview2 jobview = new jobview2(content, tooltype, shipdate);
            //jobview.Show();
        }

        private void dgvActionItems_CellClick1(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvActionItems.Rows[index].Selected = true;
        }

        public void PerformRefresh()
        {
          //  commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);
         //   actionItemsTableAdapter.FillBy(ds_ActionItems.ActionItems, strJobNumber);
            // this.commentsTableAdapter.Fill(); 
          //  this.dataGridView1.Refresh();
            this.dgvActionItems.Refresh();


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.actionItemsTableAdapter.FillbyOpen(ds_ActionItems.ActionItems); 
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.actionItemsTableAdapter.FillbyClosed(ds_ActionItems.ActionItems); 
        }
    }
}
