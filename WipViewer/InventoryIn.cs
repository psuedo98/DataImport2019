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
    public partial class InventoryIn : Form
    {
        public string strDirection; 
        public InventoryIn()
        {
            InitializeComponent();
        }

        public InventoryIn(string direction)
        {
             strDirection = direction;
            InitializeComponent();
            btnSubmit.Text = "Release Inventory";
            btnSubmit.BackColor = Color.Red; 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strPart = txtPartNumber.Text;
            int strQuantity = Convert.ToInt32(txtQuantity.Text); 


            InventoryEntity entity = new InventoryEntity();
            Inventory_Transactions itrans = new Inventory_Transactions();

            var parts = (from p in entity.Inventory_Parts
                        where p.PartNumber == strPart
                        select p).Count(); 
                        

            if (parts == 0)
            {
                MessageBox.Show("That part does not exist, try again!");

            }

            else
            {
                itrans.PartNumber = strPart;
                
                if (strDirection == "out")
                {
                    itrans.TransactionType = "Inventory Out";
                    strQuantity = strQuantity * -1; 
                }
                else
                {
                    itrans.TransactionType = "Inventory In";
                }
                itrans.Quantity = strQuantity;
                entity.Inventory_Transactions.Add(itrans);
                entity.SaveChanges(); 

                if (strDirection == "out")
                {
                    MessageBox.Show("Inventory Released. Great!");
                }
                else
                {
                    MessageBox.Show("Inventory Received. Awesome!"); 
                }

            }
        }

        private void InventoryIn_Load(object sender, EventArgs e)
        {

        }
    }
}
