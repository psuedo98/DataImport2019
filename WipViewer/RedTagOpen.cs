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
    public partial class RedTagOpen : Form
    {
        public RedTagOpen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tagnumber = Convert.ToInt16(txtTag.Text);

            TestEntities db = new TestEntities();
            tblRedTag check = db.tblRedTags.Find(tagnumber);

            if (check == null)
            {
                MessageBox.Show("Sorry, that Tag does not exist");

            }
            else
            {

                frmRedTag rtform = new frmRedTag(tagnumber);
                rtform.Show();
            }
        }

    }
}
