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
            // TODO: This line of code loads data into the 'ds_ActionItems.ActionItems' table. You can move, or remove it, as needed.
            this.actionItemsTableAdapter.Fill(this.ds_ActionItems.ActionItems);

            

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
    }
}
