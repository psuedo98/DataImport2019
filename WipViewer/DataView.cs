using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; 


namespace WipViewer
{
   


    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
            dgvActiveJobs.DoubleBuffered(true); 
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_activejobs.ActiveJobs' table. You can move, or remove it, as needed.
            this.activeJobsTableAdapter.Fill(this.ds_activejobs.ActiveJobs);
            dgvActiveJobs.Columns[3].DefaultCellStyle.Format = "c";
            dgvActiveJobs.Columns[4].DefaultCellStyle.Format = "c";

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(DataView_KeyDown); 

        }

        void DataView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                if (dgvActiveJobs.SelectedRows.Count == 0)
                {
                    MessageBox.Show("There are no rows selected");

                }
                else
                {

                    string shipmonth = txtMonthFill.Text;
                    foreach (DataGridViewRow r in dgvActiveJobs.SelectedRows)
                    {
                        r.Cells[12].Value = shipmonth;
                    }
                }
            }

        }

        private void dgvActiveJobs_SelectionChanged(object sender, EventArgs e)
        {
            lblcount.Text = dgvActiveJobs.SelectedRows.Count.ToString() + " Rows";
            int selectedtotal = 0; 
            foreach (DataGridViewRow r in dgvActiveJobs.SelectedRows)
            {

                selectedtotal += Convert.ToInt32(r.Cells[3].Value);
                lblSelection.Text = selectedtotal.ToString("C");
            }

        }

        


        private void btnJobView_Click(object sender, EventArgs e)
        {
            var content = dgvActiveJobs.SelectedRows[0].Cells[0].Value.ToString();
            var tooltype = dgvActiveJobs.SelectedRows[0].Cells[1].Value.ToString();
            DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[6].Value);



            jobview2 jobview = new jobview2(content, tooltype, shipdate);
            jobview.Show();
        }


    

        private void dgvActiveJobs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Space)
            {
                int i = dgvActiveJobs.CurrentRow.Index;


                var content = dgvActiveJobs.SelectedRows[0].Cells[0].Value.ToString();
                frmComment pgComment = new WipViewer.frmComment(content);
                pgComment.Show();

            }
            else if (e.KeyChar == (Char)Keys.F1)
            {
                //string shipmonth = dgvActiveJobs.SelectedRows[0].Cells[12].Value.ToString(); 
                string shipmonth = txtMonthFill.Text; 
                foreach(DataGridViewRow r in dgvActiveJobs.SelectedRows)
                {
                    r.Cells[12].Value = shipmonth; 
                }
            }
            else
            {
                MessageBox.Show(e.KeyChar.ToString());
            }
        }



        private void dgvActiveJobs_CellClick1(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvActiveJobs.Rows[index].Selected = true;
        }

        private void btn90_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = DateTime.Today;
                DateTime end = start.AddDays(90);

                //   activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 4);
                activeJobsTableAdapter.BetweenDateFill(ds_activejobs.ActiveJobs, start.ToString(), end.ToString());

                int machine = 0;
                int tracker = 0;
                int weld = 0;
                int design = 0;
                int build = 0;
                int total = 0;
                double value = 0;

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);


                    
                    value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);



                    lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value));
                    lblValue.Visible = true;

                    lblMachinehrs.Text = machine.ToString();
                    lblMachinehrs.Visible = true;

                    lblBuildhrs.Text = build.ToString();
                    lblBuildhrs.Visible = true;

                    lblWeldhrs.Text = weld.ToString();
                    lblWeldhrs.Visible = true;

                    lblDesignhrs.Text = design.ToString();
                    lblDesignhrs.Visible = true;

                    lblTrackerhrs.Text = tracker.ToString();
                    lblTrackerhrs.Visible = true;

                }

                total = machine + build + weld + design + tracker;

                lblTotal.Text = total.ToString();
                lblTotal.Visible = true;


                //this.activeJobsTableAdapter.GetMonth(this.ds_activejobs.ActiveJobs, ((decimal)(System.Convert.ChangeType(smonthToolStripTextBox.Text, typeof(decimal)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);


                //    activeJobsTableAdapter.
                //    DataRow[] shown = ds_activejobs.ActiveJobsRow
            }
        }

        private void getMonthToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.activeJobsTableAdapter.GetMonth(this.ds_activejobs.ActiveJobs, ((decimal)(System.Convert.ChangeType(smonthToolStripTextBox.Text, typeof(decimal)))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void bthThisMonth_Click(object sender, EventArgs e)
        {
            try
            {
                string month = DateTime.Now.ToString("MM");
                decimal monthnumber = Convert.ToDecimal(month);

                activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, monthnumber);

                int machine = 0;
                int tracker = 0;
                int weld = 0;
                int design = 0;
                int build = 0;
                int total = 0;

                double value = 0;

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);


                    value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);



                    lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value));
                    lblValue.Visible = true;

                    lblMachinehrs.Text = machine.ToString();
                    lblMachinehrs.Visible = true;

                    lblBuildhrs.Text = build.ToString();
                    lblBuildhrs.Visible = true;

                    lblWeldhrs.Text = weld.ToString();
                    lblWeldhrs.Visible = true;

                    lblDesignhrs.Text = design.ToString();
                    lblDesignhrs.Visible = true;

                    lblTrackerhrs.Text = tracker.ToString();
                    lblTrackerhrs.Visible = true;

                }

                total = machine + build + weld + design + tracker;

                lblTotal.Text = total.ToString();
                lblTotal.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnLate_Click(object sender, EventArgs e)
        {
            try
            {
                //  string month = DateTime.Now.ToString("MM");
                //   decimal monthnumber = Convert.ToDecimal(month);

                activeJobsTableAdapter.LateFill(ds_activejobs.ActiveJobs, DateTime.Now.ToString());

                int machine = 0;
                int tracker = 0;
                int weld = 0;
                int design = 0;
                int build = 0;
                int total = 0;
                double value = 0;

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);


                    
                    value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);



                    lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value));
                    lblValue.Visible = true;

                    lblMachinehrs.Text = machine.ToString();
                    lblMachinehrs.Visible = true;

                    lblBuildhrs.Text = build.ToString();
                    lblBuildhrs.Visible = true;

                    lblWeldhrs.Text = weld.ToString();
                    lblWeldhrs.Visible = true;

                    lblDesignhrs.Text = design.ToString();
                    lblDesignhrs.Visible = true;

                    lblTrackerhrs.Text = tracker.ToString();
                    lblTrackerhrs.Visible = true;

                }

                total = machine + build + weld + design + tracker;

                lblTotal.Text = total.ToString();
                lblTotal.Visible = true;



            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string month = DateTime.Now.ToString("MM");
                decimal monthnumber = Convert.ToDecimal(month);
                monthnumber += 1;
                activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, monthnumber);

                int machine = 0;
                int tracker = 0;
                int weld = 0;
                int design = 0;
                int build = 0;
                int total = 0;
                double value = 0;

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);


                    
                    value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);



                    lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value));
                    lblValue.Visible = true;

                    lblMachinehrs.Text = machine.ToString();
                    lblMachinehrs.Visible = true;

                    lblBuildhrs.Text = build.ToString();
                    lblBuildhrs.Visible = true;

                    lblWeldhrs.Text = weld.ToString();
                    lblWeldhrs.Visible = true;

                    lblDesignhrs.Text = design.ToString();
                    lblDesignhrs.Visible = true;

                    lblTrackerhrs.Text = tracker.ToString();
                    lblTrackerhrs.Visible = true;

                }

                total = machine + build + weld + design + tracker;

                lblTotal.Text = total.ToString();
                lblTotal.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = DateTime.Today;
                DateTime end = start.AddDays(7);

                //   activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 4);
                activeJobsTableAdapter.BetweenDateFill(ds_activejobs.ActiveJobs, start.ToString(), end.ToString());

                int machine = 0;
                int tracker = 0;
                int weld = 0;
                int design = 0;
                int build = 0;
                int total = 0;
                double value = 0;

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);


                    
                    value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);



                    lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value));
                    lblValue.Visible = true;

                    lblMachinehrs.Text = machine.ToString();
                    lblMachinehrs.Visible = true;

                    lblBuildhrs.Text = build.ToString();
                    lblBuildhrs.Visible = true;

                    lblWeldhrs.Text = weld.ToString();
                    lblWeldhrs.Visible = true;

                    lblDesignhrs.Text = design.ToString();
                    lblDesignhrs.Visible = true;

                    lblTrackerhrs.Text = tracker.ToString();
                    lblTrackerhrs.Visible = true;

                }

                total = machine + build + weld + design + tracker;

                lblTotal.Text = total.ToString();
                lblTotal.Visible = true;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnJanuary_Click(object sender, EventArgs e)
        {
            btnJanuary.BackColor = Color.Green;
            btnJanuary.ForeColor = Color.White;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 1);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;
         

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);

                double value = 0;
                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);
                
                

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

                

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;


        }

        private void btnFebruary_Click(object sender, EventArgs e)
        {
            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.Green;
            btnFebruary.ForeColor = Color.White;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;



            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 2);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnMarch_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.Green;
            btnMarch.ForeColor = Color.White;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 3);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnApril_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.Green;
            btnApril.ForeColor = Color.White;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 4);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
           

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnMay_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.Green;
            btnMay.ForeColor = Color.White;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;
            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 5);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
           

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnJune_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.Green;
            btnJune.ForeColor = Color.White;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 6);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            


            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnJuly_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.Green;
            btnJuly.ForeColor = Color.White;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 7);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnAugust_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.Green;
            btnAugust.ForeColor = Color.White;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 8);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            


            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnSeptember_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.Green;
            btnSeptember.ForeColor = Color.White;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 9);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            


            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnOctober_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.Green;
            btnOctober.ForeColor = Color.White;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.LightSlateGray;

            btnDecember.ForeColor = Color.Black;
            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 10);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
            

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 

                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnNovember_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.Green;
            btnNovember.ForeColor = Color.White;
            btnDecember.BackColor = Color.LightSlateGray;
            btnDecember.ForeColor = Color.Black;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 11);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
           

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;


                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnDecember_Click(object sender, EventArgs e)
        {

            btnJanuary.BackColor = Color.LightSlateGray;
            btnJanuary.ForeColor = Color.Black;
            btnFebruary.BackColor = Color.LightSlateGray;
            btnFebruary.ForeColor = Color.Black;
            btnMarch.BackColor = Color.LightSlateGray;
            btnMarch.ForeColor = Color.Black;
            btnApril.BackColor = Color.LightSlateGray;
            btnApril.ForeColor = Color.Black;
            btnMay.BackColor = Color.LightSlateGray;
            btnMay.ForeColor = Color.Black;
            btnJune.BackColor = Color.LightSlateGray;
            btnJune.ForeColor = Color.Black;
            btnJuly.BackColor = Color.LightSlateGray;
            btnJuly.ForeColor = Color.Black;
            btnAugust.BackColor = Color.LightSlateGray;
            btnAugust.ForeColor = Color.Black;
            btnSeptember.BackColor = Color.LightSlateGray;
            btnSeptember.ForeColor = Color.Black;
            btnOctober.BackColor = Color.LightSlateGray;
            btnOctober.ForeColor = Color.Black;
            btnNovember.BackColor = Color.LightSlateGray;
            btnNovember.ForeColor = Color.Black;
            btnDecember.BackColor = Color.Green;
            btnDecember.ForeColor = Color.White;

            activeJobsTableAdapter.GetMonth(ds_activejobs.ActiveJobs, 12);

            int machine = 0;
            int tracker = 0;
            int weld = 0;
            int design = 0;
            int build = 0;
            int total = 0;

            double value = 0;
           

            for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
            {
                machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);

                value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);

                lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value)); 
                lblValue.Visible = true;

                lblMachinehrs.Text = machine.ToString();
                lblMachinehrs.Visible = true;

                lblBuildhrs.Text = build.ToString();
                lblBuildhrs.Visible = true;

                lblWeldhrs.Text = weld.ToString();
                lblWeldhrs.Visible = true;

                lblDesignhrs.Text = design.ToString();
                lblDesignhrs.Visible = true;

                lblTrackerhrs.Text = tracker.ToString();
                lblTrackerhrs.Visible = true;

            }

            total = machine + build + weld + design + tracker;

            lblTotal.Text = total.ToString();
            lblTotal.Visible = true;
        }

        private void btnLosers_Click(object sender, EventArgs e)
        {
            try
            {
                //  string month = DateTime.Now.ToString("MM");
                //   decimal monthnumber = Convert.ToDecimal(month);

                activeJobsTableAdapter.FillLosers(ds_activejobs.ActiveJobs);


                int machine = 0;
                int tracker = 0;
                int weld = 0;
                int design = 0;
                int build = 0;
                int total = 0;
                double value = 0;

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[11].Value);


                    

                    value += Convert.ToDouble(dgvActiveJobs.Rows[i].Cells[3].Value);



                    lblValue.Text = String.Format("{0:C}", Convert.ToInt32(value));
                    lblValue.Visible = true;

                    lblMachinehrs.Text = machine.ToString();
                    lblMachinehrs.Visible = true;

                    lblBuildhrs.Text = build.ToString();
                    lblBuildhrs.Visible = true;

                    lblWeldhrs.Text = weld.ToString();
                    lblWeldhrs.Visible = true;

                    lblDesignhrs.Text = design.ToString();
                    lblDesignhrs.Visible = true;

                    lblTrackerhrs.Text = tracker.ToString();
                    lblTrackerhrs.Visible = true;

                }

                total = machine + build + weld + design + tracker;

                lblTotal.Text = total.ToString();
                lblTotal.Visible = true;



            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            var content = dgvActiveJobs.SelectedRows[0].Cells[0].Value.ToString();
            frmComment pgComment = new WipViewer.frmComment(content);
            pgComment.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTrackerhrs_Click(object sender, EventArgs e)
        {

        }

        private void dgvActiveJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvActiveJobs_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedtotal = new int();
            foreach (DataGridViewRow r in dgvActiveJobs.SelectedRows)
            {

                selectedtotal += Convert.ToInt32(r.Cells[3].Value);
                lblSelection.Text = selectedtotal.ToString("C");
            }

        }

        private void dgvActiveJobs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var content = dgvActiveJobs.SelectedRows[0].Cells[0].Value.ToString();
            var tooltype = dgvActiveJobs.SelectedRows[0].Cells[1].Value.ToString();
            DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[6].Value);



            jobview2 jobview = new jobview2(content, tooltype, shipdate);
            jobview.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.Fill(ds_activejobs.ActiveJobs); 
        }
    }

    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}



