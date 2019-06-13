using Syncfusion.Data.Extensions;
using Syncfusion.DataSource.Extensions;
using Syncfusion.Linq;
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
    public partial class AddNewPart : Form
    {
        public AddNewPart()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strPartNumber = txtPartNumber.Text;
            string strJobNumber = txtJobNumber.Text;
            int strLotNumber = Convert.ToInt32(txtLotNumber.Text);
            string strDetailNumber = txtDetailNumber.Text;
            string strMfg = txtMfg.Text;
            string strNomen = txtNomenclature.Text;
            string strSupplier = txtSupplier.Text;
            int strQtyUnit = Convert.ToInt32(txtQtyUnit.Text);
            int strQtyTotal = Convert.ToInt32(txtQtyTotal.Text);
            string strPO = txtPO.Text; 


            try
            {
                InventoryEntity entity = new InventoryEntity();
                Inventory_Parts inventory_Parts1 = new Inventory_Parts();

                inventory_Parts1.PartNumber = strPartNumber;
                inventory_Parts1.JobNumber = strJobNumber;
                inventory_Parts1.LotNumber = strLotNumber;
                inventory_Parts1.DetailNumber = strDetailNumber;
                inventory_Parts1.MfgPart = strMfg;
                inventory_Parts1.Nomenclature = strNomen;
                inventory_Parts1.Supplier = strSupplier;
                inventory_Parts1.QtyReqdUnit = strQtyUnit;
                inventory_Parts1.QtyReqdTotal = strQtyTotal;
                inventory_Parts1.PO = strPO; 

                entity.Inventory_Parts.Add(inventory_Parts1);
                entity.SaveChanges();

                //var stocks = context.Stocks.AsQueryable();
                //if (batchNumber != null) stocks = stocks.Where(s => s.Number = batchNumber);
                //if (name != null) stocks = stocks.Where(s => s.Name.StartsWith(name));
                //var result = stocks.ToList(); // execute query

                //            var result = context.Stocks
                //.Where(batchNumber == null || stock.Number == batchNumber)
                //.Where(name == null || s => s.Name.StartsWith(name))
                //.ToList();
                Inventory_Parts ip2 = new Inventory_Parts();


                var iTransaction = entity.Inventory_Parts
                    .Where(ip3 => ip3.JobNumber == strJobNumber)
                    .Where(ip3 => ip3.LotNumber == strLotNumber)
                    .Where(ip3 => ip3.DetailNumber == strDetailNumber)
                    .Where(ip3 => ip3.PartNumber == strPartNumber)
                   .ToList(); 
                   
              foreach (Inventory_Parts t in iTransaction)
                {
                    Inventory_Transactions itrans2 = new Inventory_Transactions();
                    itrans2.PartNumber = t.PartNumber;
                    itrans2.TransactionType = "Initial Quantity";
                    itrans2.Quantity = Convert.ToInt32(itxtQuantity.Text);

                    entity.Inventory_Transactions.Add(itrans2);
                    entity.SaveChanges(); 
                }
                
            }

            catch (Exception e4)
            {
                MessageBox.Show(e4.InnerException.ToString()); 
            }

            finally
            {
                MessageBox.Show("Part Added Successfully"); 
            }
        }
    }
}
