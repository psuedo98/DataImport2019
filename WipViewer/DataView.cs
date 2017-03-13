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
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_activejobs.ActiveJobs' table. You can move, or remove it, as needed.
            this.activeJobsTableAdapter.Fill(this.ds_activejobs.ActiveJobs);

        }




        private void btnJobView_Click(object sender, EventArgs e)
        {
            var content = dgvActiveJobs.SelectedRows[0].Cells[0].Value.ToString();
            var tooltype = dgvActiveJobs.SelectedRows[0].Cells[1].Value.ToString();
            DateTime shipdate = Convert.ToDateTime(dgvActiveJobs.SelectedRows[0].Cells[5].Value);



            JobView jobview = new JobView(content, tooltype, shipdate);
            jobview.Show();
        }


        private void dgvActiveJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);


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

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);


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

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);


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

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);


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

                for (int i = 0; i < dgvActiveJobs.Rows.Count; ++i)
                {
                    machine += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[6].Value);
                    build += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[7].Value);
                    weld += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[8].Value);
                    design += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[9].Value);
                    tracker += Convert.ToInt32(dgvActiveJobs.Rows[i].Cells[10].Value);


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
    }
}

