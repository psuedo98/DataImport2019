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
    public partial class JobMaterial : Form
    {
        public string strBase;
        public string strLot;
        public JobMaterial()
        {
            InitializeComponent();
        }

        public JobMaterial(string jobnumber)
        {
            InitializeComponent();

            strBase = jobnumber.Split('/').First();
            strBase = strBase.Trim();
            strLot = jobnumber.Split('/').Last();
            strLot = strLot.Trim();
        }

        private void JobMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vIS712DataSet.Material_WIP' table. You can move, or remove it, as needed.
           // this.material_WIPTableAdapter.Fill(this.vIS712DataSet.Material_WIP);

            this.material_WIPTableAdapter.FillBy(this.vIS712DataSet.Material_WIP, strBase, strLot);

            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("WORKORDER_BASE_ID");
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("WORKORDER_LOT_ID");

            this.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = 50;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 80;
            //  this.lABOR_TICKETTableAdapter.FillBy(this.vIS712DataSet.LABOR_TICKET, strBase, strLot);
        }

        private void gridGroupingControl1_TableControlCellClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {

        }
    }
}
