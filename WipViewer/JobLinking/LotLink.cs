using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WipViewer.JobLinking
{
    public partial class LotLink : Form
    {
        CheckedListBox chklistbox = new CheckedListBox();
        public LotLink()
        {
            InitializeComponent();
        }

        private void txtBaseId_TextChanged(object sender, EventArgs e)
        {

            TestEntities test = new TestEntities();
            var acs = from a in test.ActiveJobs select a.BaseID;
            AutoCompleteStringCollection sn = new AutoCompleteStringCollection();
            sn.AddRange(acs.ToArray());
            txtBaseId.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBaseId.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBaseId.AutoCompleteCustomSource = sn;

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {

            TestEntities test2 = new TestEntities();
            var lotlist = test2.ActiveJobs
                    .Where(b => b.BaseID.Contains(txtBaseId.Text.Substring(0, 8)));

            int p = lotlist.Count();
            int x = 13;
            int y = 30;

            ActiveJob[] array1 = lotlist.ToArray();



            this.Controls.Add(chklistbox);
            chklistbox.Location = new Point(63, 50);


            //    string checkboxname;
            for (int i = 0; i < p; i++)
            {


                string name = "chk" + i;
                string lot = array1[i].BaseID.Substring(11, 2);
                //chkbox = new CheckBox();
                //chkbox.Location = new Point(x, y);
                //chkbox.Name = name;
                //chkbox.Text = "LOT " + lot; 
                //chkbox.Visible = true;

                chklistbox.Items.Add("Lot" + lot);

                //  this.Controls.Add(chkbox); 
                y = y + 30;

                if (i == 4 || i == 9 || i == 14)
                {
                    y = y - 150;
                    x = x + 100;
                }

            }



        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            object[] items = chklistbox.CheckedItems.OfType<object>().ToArray();
            var target = "Lot";
            if (chklistbox.CheckedItems.Count == 0)
            {
                MessageBox.Show("You didn't check anything dope. Try again");
            }
            else
            {
                target += txtBaseId.Text.Substring(11, 2);
                bool has = items.Contains(target);
                if (has == true)
                {
                    TestEntities db = new TestEntities();
                    Link link = new Link();
                    link.BaseID = txtBaseId.Text.Substring(0,8);
                    string lots = "";
                    for (int o = 0; o < items.Length; o++)
                    {
                        if (lots == "")
                        {
                            if (items[o].ToString().Length == 4)
                            {
                                lots += items[o].ToString().Substring(3, 1);
                            }
                            else
                            {
                                lots += items[o].ToString().Substring(3, 2);
                            }
                        }
                        else
                        {
                            if (items[o].ToString().Length == 4)
                            {
                                lots += "," + items[o].ToString().Substring(3, 1);
                            }
                            else
                            {
                                lots += "," + items[o].ToString().Substring(3, 2);
                            }
                        }
                        link.LinkedLots = lots;
                    }
                    db.Links.Add(link);
                    db.SaveChanges();
                    MessageBox.Show("Lots " + lots + " Successfully Linked. Keep up the Good Work!");
                }
                else
                {
                    MessageBox.Show("Dude. The lot you selected isn't in the link list you made. TRY AGAIN");
                }
            }
        }
    }
}

