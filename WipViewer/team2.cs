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
    public partial class team2 : Form
    {

        string strjobnumber;

        public team2()
        {
            InitializeComponent();
        }

        public team2(string jobnumber)
        {
            InitializeComponent();

            strjobnumber = jobnumber;

            using (var db = new TestEntities())
            {
                Team tTeam = db.Teams.Find(strjobnumber);




                if (tTeam != null)
                {
                    if (tTeam.ProgramManager != null)
                    {
                        cmbPM.Text = tTeam.ProgramManager.Trim();

                    }
                    if (tTeam.Processor != null)
                    {
                        cmbProcessor.Text = tTeam.Processor.Trim();
                    }

                    if (tTeam.BuildLeader != null)
                    {
                        cmbBl.Text = tTeam.BuildLeader.Trim();
                    }

                    if (tTeam.QA != null)
                    {
                        cmbQa.Text = tTeam.QA.Trim(); 

                    }
                    



                    if (tTeam.PODate != null)
                    {
                        dtpPoDate.Value = Convert.ToDateTime(tTeam.PODate);

                    }
                    if (tTeam.KickOff != null)
                    {
                        chkKickoff.Checked = true;
                        dtpKickoff.Value = Convert.ToDateTime(tTeam.KickOff);
                    }
                    if (tTeam.DataRelease != null)
                    {
                        chkDataRelease.Checked = true;
                        dtpDataRelease.Value = Convert.ToDateTime(tTeam.DataRelease);
                    }
                    if (tTeam.Folder != null)
                    {
                        chkFolder.Checked = true;
                        dtpFolderReceived.Value = Convert.ToDateTime(tTeam.Folder);


                    }

                    if (tTeam.Hold != null)
                    {
                        cmbHold.Text = tTeam.Hold.Trim(); 
                    }
                    else
                    {
                        cmbHold.Text = "Active"; 
                    }




                    




                    //using (var bmpTemp = new Bitmap(findpic.Path))
                    //{

                    //    image = new Bitmap(bmpTemp);
                    //    pbJob.Image = image;

                    //}

                }




            }
        }

        private void team2_Load(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbQa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            using (var db = new TestEntities())
            {
                Team tTeam = db.Teams.Find(strjobnumber);

                if (tTeam == null)
                {
                    Team tTeam2 = new Team();
                    tTeam2.JobNumber = strjobnumber;

                    if (cmbPM.SelectedIndex != -1)
                    {
                        tTeam2.ProgramManager = cmbPM.SelectedItem.ToString();
                    }
                    if (cmbProcessor.SelectedIndex != -1)
                    {
                        tTeam2.Processor = cmbProcessor.SelectedItem.ToString();
                    }

                    if (cmbBl.SelectedIndex != -1)
                    {
                        tTeam2.BuildLeader = cmbBl.SelectedItem.ToString();
                    }

                    if (cmbQa.SelectedIndex != -1)
                    {
                        tTeam2.QA = cmbQa.SelectedItem.ToString();
                    }

                    if (chkKickoff.Checked == true)
                    {
                        tTeam2.KickOff = dtpKickoff.Value;
                    }
                    if (chkDataRelease.Checked == true)
                    {
                        tTeam2.DataRelease = dtpDataRelease.Value;

                    }
                    if (chkFolder.Checked == true)
                    {
                        tTeam2.Folder = dtpFolderReceived.Value;

                    }

                    tTeam2.PODate = dtpPoDate.Value;

                    string hold = "";
                    hold = cmbHold.Text;

                    tTeam2.Hold = hold; 

                    db.Teams.Add(tTeam2);
                    db.SaveChanges();
                    MessageBox.Show("Team Created!");
                    this.Close();

                }

                else
                {
                    tTeam.JobNumber = strjobnumber;
                    tTeam.ProgramManager = Convert.ToString(cmbPM.Text);
                    tTeam.BuildLeader = Convert.ToString(cmbBl.Text);
                    tTeam.Processor = Convert.ToString(cmbProcessor.Text);
                    tTeam.QA = Convert.ToString(cmbQa.Text);
                    if (chkKickoff.Checked == true)
                    {
                        tTeam.KickOff = dtpKickoff.Value;
                    }
                    if (chkDataRelease.Checked == true)
                    {
                        tTeam.DataRelease = dtpDataRelease.Value;

                    }
                    if (chkFolder.Checked == true)
                    {
                        tTeam.Folder = dtpFolderReceived.Value;

                    }

                    tTeam.PODate = dtpPoDate.Value;


                    string hold = "";
                    hold = cmbHold.Text;

                    tTeam.Hold = hold;

                    db.SaveChanges();

                    MessageBox.Show("Team Updated!");
                    this.Close();
                }
            }
        }
    }
}
