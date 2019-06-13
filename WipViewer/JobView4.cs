using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WipViewer
{

    
    public partial class JobView4 : Form
    {
        public string strJobNumber;
        public Image image;

        #region "API Definition"

        private System.Windows.Forms.ImageList imageList1;


        static public int NoChildBMP;
        static public int OpenedBMP;
        static public int ClosedBMP;


        //sample data members...
        public static CollapsibleDataSource externalData;
        #endregion



        public JobView4(string content, string tooltype, string shipdate)
        {
          //  this.margin_Over_timeTableAdapter.Fill(this.wipDataSet.Margin_Over_time);

            NoChildBMP = 2;
            OpenedBMP = 0;
            ClosedBMP = 1;
            strJobNumber = content;

            InitializeComponent();
           
            // SampleData(content);
          

            lblBase.Text = content;
            lblType.Text = tooltype;
            lblShipdate.Text = "Job Ships: " + shipdate;

            //commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);
            //actionItemsTableAdapter1.FillBy(this.ds_ActionItems.ActionItems, strJobNumber);

            //g1.SetColHidden(1,1,true);
            //g1.SetColHidden(4, 4, true); 

            //g2.TableDescriptor.VisibleColumns.Remove("baseid");
            //g2.TableDescriptor.VisibleColumns.Remove("id");

            //g2.TableDescriptor.Appearance.AnyRecordFieldCell.WrapText = true;
            //g2.TableModel.RowHeights.ResizeToFit(GridRangeInfo.Table());

            //g2.TableModel.ReadOnly = false;

            //g2.TableDescriptor.Columns[1].HeaderText = "Comment";

            //g2.TableDescriptor.Columns["date"].Appearance.AnyRecordFieldCell.Format = "MM/dd/yyyy";

            //margin_Over_timeTableAdapter.BaseQuery(this.marginOverTime.Margin_Over_time, strJobNumber);




        }

        private void JobView4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsComments.comments' table. You can move, or remove it, as needed.
            // this.commentsTableAdapter1.Fill(this.dsComments.comments);
            // TODO: This line of code loads data into the 'ds_Comments.comments' table. You can move, or remove it, as needed.
            // this.commentsTableAdapter.Fill(this.ds_Comments.comments);

            //  commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);
            try
            {
                commentsTableAdapter1.fillComments(this.dsComments.comments, strJobNumber);
                this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("id");
                this.gridGroupingControl1.TableDescriptor.VisibleColumns.Remove("baseid");
                this.gridGroupingControl1.Appearance.AlternateRecordFieldCell.BackColor = Color.LightGray;

                this.gridGroupingControl1.TableOptions.ColumnHeaderRowHeight = 20;
                this.gridGroupingControl1.TableOptions.RecordRowHeight = 40;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
            

            using (var db = new TestEntities())
            {
                ImportantDate idate = db.ImportantDates.Find(strJobNumber);
                picture findpic = db.pictures.Find(strJobNumber);
                // Margin_Over_time mot = db.Margin_Over_time.Find(strJobNumber); 

                // rbcMain

                if (findpic != null)
                {
                    using (var bmpTemp = new Bitmap(findpic.Path))
                    {
                        image = new Bitmap(bmpTemp);
                        //  is3.Images.Add(image);
                        is3.BackgroundImage = image;
                        is3.BackgroundImageLayout = ImageLayout.Stretch;

                        //   is1.SlideShow = false;
                        //  dscomments
                        //    is1.

                        is3.ImageCollection.ImageSize.Height.Equals(512);
                        is3.ImageCollection.ImageSize.Width.Equals(512);

                    }
                }
                else
                {

                    Image i2 = Image.FromFile(@"r:\wippictures\na.jpg");



                    is3.Images.Add(i2);
                }



                Team jobteam1 = new Team();
                bool check1 = db.Teams.Any(u => u.JobNumber == strJobNumber);


                #region LabelChecks

                string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");
                string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\riskassessment.xlsx";

                if (File.Exists(path) == true)
                {

                }
                else
                {
                    btnRA.BackColor = Color.Red;
                    btnRA.Enabled = false;
                }

                path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\aqp.xlsx";

                if (File.Exists(path) == true)
                {

                }
                else
                {
                    btnAQP.BackColor = Color.Red;
                    btnAQP.Enabled = false;
                }

                if (check1 == true)
                {
                    jobteam1 = db.Teams.Find(strJobNumber);

                    if (jobteam1.ProgramManager != null)
                    {
                        lblPm.Text = "Program Manager: " + jobteam1.ProgramManager;
                    }
                    else { lblPm.Text = "PM NOT SET"; }

                    if (jobteam1.Processor != null)
                    {
                        lblProcessor.Text = "Processor: " + jobteam1.Processor;
                    }
                    else { lblProcessor.Text = "PROCESSOR NOT SET"; }

                    if (jobteam1.BuildLeader != null)
                    {
                        lblBl.Text = "Build Leader: " + jobteam1.BuildLeader;
                    }
                    else { lblBl.Text = "BUILD LEADER NOT SET"; }



                    if (jobteam1.PODate != null)
                    {
                        lblPO.Text = "PO Date: " + jobteam1.PODate.Value.ToString("MM-dd-yyyy");
                    }
                    else { lblPO.Text = "PO DATE NOT ENTERED"; }

                    #endregion






                    ActiveJob aj1 = db.ActiveJobs.Find(strJobNumber);
                 



                    this.Text = strJobNumber;

                }



            }


        }
        public JobView4()
        {
            InitializeComponent();
        }

    

        void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex > 0)
            {
                if (externalData != null)
                {
                    e.Style.CellValue = externalData[e.RowIndex - 1].Items[e.ColIndex - 1];
                    if (e.ColIndex == 1)
                    {
                        e.Style.CellType = "TreeCell";
                        e.Style.Tag = externalData[e.RowIndex - 1].IndentLevel;
                        e.Style.ImageIndex = (int)externalData[e.RowIndex - 1].ExpandState;
                    }
                }
                e.Handled = true;

                if (e.ColIndex == 2)
                {
                    double value = double.Parse(e.Style.Text);
                    if (value < 1024)
                    {
                        e.Style.CellValue = value + " B";
                    }
                    else if (value < 1048575)
                    {
                        value = Math.Floor(value / 1024);
                        e.Style.CellValue = value + " KB";
                    }
                    else if (value < 1073741824)
                    {
                        value = Math.Floor(value / 1048575);
                        e.Style.CellValue = value + " MB";
                    }
                    else if (value > 1073741824)
                    {
                        value = Math.Floor(value / 1073741824);
                        e.Style.CellValue = value + " GB";
                    }
                }
            }

        }

        void GridQueryRowCount(object sender, GridRowColCountEventArgs e)
        {
            if (externalData != null)
                e.Count = externalData.RowCount;
            e.Handled = true;
        }

        void GridQueryColCount(object sender, GridRowColCountEventArgs e)
        {
            if (externalData != null)
                e.Count = externalData.ColCount;
            e.Handled = true;
        }

      

       
        private void toolStripEx1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ofdPicture.ShowDialog();
            string strPicture = ofdPicture.FileName.ToString();
           
                is3.Images.Add(Image.FromFile(strPicture));
           
            string jobfilename = strJobNumber.Trim();
            jobfilename = jobfilename.Replace(@"/", "-");
            File.Copy(ofdPicture.FileName, "R:\\wippictures\\" + jobfilename + ".jpg", true);

            using (var db = new TestEntities())
            {
                picture jobPicture = db.pictures.Find(strJobNumber);
                if (jobPicture != null)
                {

                    jobPicture.BaseId = strJobNumber;
                    jobPicture.Path = "R:\\wippictures\\" + jobfilename + ".jpg";
                    db.SaveChanges();
                    MessageBox.Show("Picture Updated. GREAT JOB!!");

                }
                else
                {
                    picture pic2 = new picture();
                    pic2.BaseId = strJobNumber;
                    pic2.Path = "R:\\wippictures\\" + jobfilename + ".jpg";
                    db.pictures.Add(pic2);
                    db.SaveChanges();
                    MessageBox.Show("Image Saved. GREAT JOB!!");
                }
            }
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            team2 frmTeam = new WipViewer.team2(strJobNumber);
            frmTeam.Show();
        }

        private void btnJobHistory_Click(object sender, EventArgs e)
        {
            history frmHistory = new history(strJobNumber);
            frmHistory.Show();
        }

        private void is3_Click(object sender, EventArgs e)
        {

        }

        private void btnAQP_Click(object sender, EventArgs e)
        {
            string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");

            string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\aqp.xlsx";

            System.Diagnostics.Process.Start(path);
        }

        private void btnRA_Click(object sender, EventArgs e)
        {
            string strJob = strJobNumber.Replace("/", "_").Replace(" ", "");

            string path = "R:\\wipviewer2017\\jobfiles\\" + strJob + "\\riskassessment.xlsx";

           
            System.Diagnostics.Process.Start(path);
        }

        private void gridGroupingControl1_TableControlCellClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            frmComment pgComment = new WipViewer.frmComment(this, strJobNumber);
            pgComment.Show();

            //Record record = this.gridGroupingControl1.Table.CurrentRecord;
            //int r1 = this.gridGroupingControl1.Table.CurrentRecord.GetRowIndex(); 
            //DateTime d1 = DateTime.Now;
            //string u1 = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //this.gridGroupingControl1.Table.CurrentRecord.SetValue("date", d1);
            //this.gridGroupingControl1.Table.CurrentRecord.SetValue("commenter", u1); 
            //this.gridGroupingControl1.TableControl.CurrentCell.ConfirmChanges();
            //this.gridGroupingControl1.TableControl.CurrentCell.EndEdit();
            //this.gridGroupingControl1.TableControl.Update(); 


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string type = "labor"; 
            LaborTickets frmLabor = new LaborTickets(strJobNumber);
            frmLabor.Show(); 

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            JobMaterial matform = new JobMaterial(strJobNumber);
            matform.Show(); 
            

        }

        public void PerformRefresh()
        {
            commentsTableAdapter1.fillComments(this.dsComments.comments, strJobNumber);
            



        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            ActionItems actionitems = new ActionItems(this, strJobNumber);
            actionitems.Show();
        }

        private void btnViewActions_Click(object sender, EventArgs e)
        {
            string reporttype = "actionitem";
            ScheduleForms.MachSchedule mach = new ScheduleForms.MachSchedule(reporttype);
            mach.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            JobKickoff kickoff = new JobKickoff(strJobNumber);
            kickoff.Show(); 
        }

        //private void JobView4_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'wipDataSet.Margin_Over_time' table. You can move, or remove it, as needed.
        //    this.margin_Over_timeTableAdapter.Fill(this.wipDataSet.Margin_Over_time);

        //}
    }
}
