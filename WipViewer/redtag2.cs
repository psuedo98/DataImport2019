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
    public partial class redtag2 : Form
    {
        public redtag2()
        {
            InitializeComponent();
            ggc1.TableModel.ReadOnly = false;
        }

        private void redtag2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'redTagEdit.RedTag2018' table. You can move, or remove it, as needed.
            this.redTag2018TableAdapter.Fill(this.redTagEdit.RedTag2018);

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            //  DataRow tablerow = gridGroupingControl1.Table.AddNew(); 

            DataRow tablerow = redTagEdit.RedTag2018.NewRow();
            redTagEdit.RedTag2018.Rows.InsertAt(tablerow, redTagEdit.RedTag2018.Rows.Count +1);
            redTagEdit.RedTag2018.AcceptChanges();
            this.gdbc1.Refresh();
        }

        private void gdbc1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                DataRow tablerow = redTagEdit.RedTag2018.NewRow();
                redTagEdit.RedTag2018.Rows.InsertAt(tablerow, e.RowIndex);
                
                this.gdbc1.Refresh();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = this.ggc1.DataSource as DataTable;
           // dt.AcceptChanges();
            this.redTag2018TableAdapter.Update(redTagEdit.RedTag2018); 
           // redTagEdit.RedTag2018.AcceptChanges();
            
        }
    }
}

