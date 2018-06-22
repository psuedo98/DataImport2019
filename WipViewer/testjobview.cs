using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.IO;

namespace WipViewer
{
    public partial class testjobview : Form
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
        public testjobview()
        {
            InitializeComponent();
       //     SampleData();
        }

        #region Sample Customization
        /// <summary>
        /// Sample customization for adding the Tree cell to grid
        /// </summary>
        private void SampleCustomization()
        {
            //string[] drives = System.IO.Directory.GetLogicalDrives();
            //foreach (string drv in drives)
            //    //    this.comboBox1.Items.Add(drv);
            //    //       this.comboBox1.SelectedIndex = 0;

            //    //add a custom cell control
               gridControl1.CellModels.Add("TreeCell", new TreeCellModel(gridControl1.Model));

            //make the imagelist available thru the tablestyle
            gridControl1.TableStyle.ImageList = this.imageList2;
        }
        #endregion

        #region Populating Sample Data to grid
        /// <summary>
        /// Populating the Sample data for grid
        /// </summary>
        private void SampleData(string jobnumber)
        {
            string strPath; 
            strPath = jobnumber;

            strPath = strPath.Replace("/", "_").Replace(" ", "");


            strPath = "r:\\wipviewer2017\\jobfiles\\" + strPath;
        //    this.comboBox1.Text = strPath; 
            

            //create a sample data for a virtual grid

          //  this.comboBox1.SelectedItem.Equals(); 
           externalData = new CollapsibleDataSource(strPath);
            externalData.InitData(); //initializes an external datasource
            externalData.CollapseData(); // c

            //hook up the events needed for virtual grid
            gridControl1.ResetVolatileData();
            gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
            gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
            gridControl1.QueryColCount += new GridRowColCountEventHandler(GridQueryColCount);
            //gridControl1.QueryColWidth += new GridRowColSizeEventHandler(GridQueryColWidth);

            //handle saving data back to the data source...
            gridControl1.SaveCellInfo += new GridSaveCellInfoEventHandler(GridSaveCellInfo);
        }
        #endregion

        public testjobview(string content, string tooltype, string shipdate)
        {


            NoChildBMP = 2;
            OpenedBMP = 0;
            ClosedBMP = 1;


            


            strJobNumber = content;

  
         


            InitializeComponent();
            SampleCustomization();
            SampleData(strJobNumber);
            // SampleData(content);
            GridSettings();

            lblBase.Text = content;
            lblType.Text = tooltype;
            lblShipdate.Text = "Job Ships: " + shipdate;

            commentsTableAdapter.fillComments(dsComments.comments, strJobNumber);
            actionItemsTableAdapter1.FillBy(this.ds_ActionItems.ActionItems, strJobNumber);

            //g1.SetColHidden(1,1,true);
            //g1.SetColHidden(4, 4, true); 

            g2.TableDescriptor.VisibleColumns.Remove("baseid");
            g2.TableDescriptor.VisibleColumns.Remove("id");

            g2.TableDescriptor.Appearance.AnyRecordFieldCell.WrapText = true;
            g2.TableModel.RowHeights.ResizeToFit(GridRangeInfo.Table());

            g2.TableModel.ReadOnly = false;

            //g3.TableDescriptor.VisibleColumns.Remove("Base");
            //g3.TableDescriptor.VisibleColumns.Remove("id");
            //g3.TableDescriptor.VisibleColumns.Remove("critical");
            //g3.TableDescriptor.VisibleColumns.Remove("openitem");

            g2.TableDescriptor.Columns[1].HeaderText = "Comment";

            g2.TableDescriptor.Columns["date"].Appearance.AnyRecordFieldCell.Format = "MM/dd/yyyy";

            margin_Over_timeTableAdapter.BaseQuery(this.marginOverTime.Margin_Over_time, strJobNumber);




            //g1.TableDe
            // g1.





            //   oleDbSelectCommand.CommandText = "SELECT JobMetrics.Margin, JobMetrics.BaseID, JobMetrics.batch, Batches.BatchDate FROM JobMetrics INNER JOIN Batches ON JobMetrics.batch = Batches.Batch WHERE(JobMetrics.BaseId = '" + content + "')";


            //  MessageBox.Show(oleDbSelectCommand.CommandText.ToString()); 
            //   oleDbSelectCommand.ToString(); 

            //       oleDbSelectCommand.Parameters.AddWithValue("baseid", content);

            //  oleDbConnection1.Open(); 
            //oleDbSelectCommand.Parameters.Add("baseid", SqlDbType.VarChar).Value = content;





        }
        private void testjobview_Load(object sender, EventArgs e)
        {

            using (var db = new TestEntities())
            {
                ImportantDate idate = db.ImportantDates.Find(strJobNumber);
                picture findpic = db.pictures.Find(strJobNumber);
                // Margin_Over_time mot = db.Margin_Over_time.Find(strJobNumber); 

                

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

                    if (jobteam1.KickOff != null)
                    {
                        lblKickoff.Text = "Job Kicks off: " + jobteam1.KickOff.Value.ToString("MM-dd-yyyy");
                    }
                    else { lblKickoff.Text = "NO JOB KICKOFF DATE SET"; }

                    if (jobteam1.DataRelease != null)
                    {
                        lblData.Text = "Data Received: " + jobteam1.DataRelease.Value.ToString("MM-dd-yyyy");
                    }
                    else { lblData.Text = "NO DATA RELEASE DATE SET"; }

                    if (jobteam1.Folder != null)
                    {
                        lblFolder.Text = "Folder Received: " + jobteam1.Folder.Value.ToString("MM-dd-yyyy");
                    }
                    else { lblFolder.Text = "FOLDER NOT RECEIVED"; }

                    if (jobteam1.PODate != null)
                    {
                        lblPO.Text = "PO Date: " + jobteam1.PODate.Value.ToString("MM-dd-yyyy");
                    }
                    else { lblPO.Text = "PO DATE NOT ENTERED"; }

                    #endregion






                    ActiveJob aj1 = db.ActiveJobs.Find(strJobNumber); 



                   if (aj1.age1 <= 30)
                    {

                        DateTime testdate = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min());
                        DateTime testdate2 = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max());
                        cc1.PrimaryXAxis.DateTimeRange = new Syncfusion.Windows.Forms.Chart.ChartDateTimeRange(testdate, testdate2, 5, Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Days);
                    }

                    if (aj1.age1 > 30 && aj1.age1 <= 60)
                    {

                        DateTime testdate = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min());
                        DateTime testdate2 = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max());
                        cc1.PrimaryXAxis.DateTimeRange = new Syncfusion.Windows.Forms.Chart.ChartDateTimeRange(testdate, testdate2, 10, Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Days);
                    }

                    if (aj1.age1 > 60 && aj1.age1 <= 150)
                    {

                        DateTime testdate = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min());
                        DateTime testdate2 = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max());
                        cc1.PrimaryXAxis.DateTimeRange = new Syncfusion.Windows.Forms.Chart.ChartDateTimeRange(testdate, testdate2, 1, Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Months);
                    }

                    if (aj1.age1 > 150 && aj1.age1 <= 365)
                    {

                        DateTime testdate = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min());
                        DateTime testdate2 = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max());
                        cc1.PrimaryXAxis.DateTimeRange = new Syncfusion.Windows.Forms.Chart.ChartDateTimeRange(testdate, testdate2, 2, Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Months);
                    }

                    if (aj1.age1 > 365)
                    {

                        DateTime testdate = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min());
                        DateTime testdate2 = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max());
                        cc1.PrimaryXAxis.DateTimeRange = new Syncfusion.Windows.Forms.Chart.ChartDateTimeRange(testdate, testdate2, 3, Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Months);
                    }


                    //  Double testdate2 = db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max().Value.ToOADate();
                    // Double testdate = db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min().Value.ToOADate();


                    //DateTime testdate = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Min());
                    //DateTime testdate2 = Convert.ToDateTime(db.Margin_Over_time.Where(cc4 => cc4.BaseID == strJobNumber).Select(cc4 => cc4.BatchDate).Max());   
                    //cc1.PrimaryXAxis.DateTimeRange = new Syncfusion.Windows.Forms.Chart.ChartDateTimeRange(testdate, testdate2, 2, Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Weeks); 
                    //cc1.PrimaryXAxis.Range.Min = testdate;
                    //cc1.PrimaryXAxis.Range.Max = testdate2;

                    //cc1.PrimaryXAxis.IntervalType = Syncfusion.Windows.Forms.Chart.ChartDateTimeIntervalType.Months;
                    //cc1.PrimaryXAxis.Range.Interval = 14;

                    //    cc1.PrimaryXAxis.DateTimeRange = new 






                    this.Text = strJobNumber;

                }



            }


        }


        private void GridSettings()
        {
            gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);
            this.gridControl1.DefaultRowHeight = 18;
            this.gridControl1.DefaultColWidth = 100;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.None;
            this.gridControl1.Properties.RowHeaders = false;
            this.gridControl1.CellDoubleClick += new GridCellClickEventHandler(gridControl1_CellDoubleClick);
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
            this.gridControl1.TableStyle.Trimming = StringTrimming.EllipsisCharacter;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.ListBoxSelectionMode = SelectionMode.One;
            this.gridControl1.AllowProportionalColumnSizing = true;
            this.gridControl1.BrowseOnly = true;

            //tab key navigation set as false to move the next control
            this.gridControl1.WantTabKey = false;
        }
        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void is1_Click(object sender, EventArgs e)
        {

        }

        private void dsCommentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void g1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {

        }

        private void g2_TableControlCellClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {

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

        void GridSaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
        {
            try
            {
                //move the changes back to the external data object
                if (e.ColIndex == 1 && e.RowIndex > 0)
                {
                    externalData[e.RowIndex - 1].ExpandState = (int)e.Style.ImageIndex;
                    externalData[e.RowIndex - 1].IndentLevel = (int)e.Style.Tag;
                }

                if (e.ColIndex > 0 && e.RowIndex > 0)
                {
                    externalData[e.RowIndex - 1].Items[e.ColIndex - 1] = (string)e.Style.CellValue;

                }
            }
            catch { }

            //refresh this row so change is displayed
            if (!externalData.Locked)
            {
                externalData.CollapseData();
                this.gridControl1.Refresh();
            }
            e.Handled = true;
        }



        private void is3_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_CellDoubleClick(object sender, GridCellClickEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColIndex == 1)
            {
                if (this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex == (int)TreeNodeState.Opened)
                {
                    this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex = (int)TreeNodeState.Closed;
                }
                else if (this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex == (int)TreeNodeState.Closed)
                {
                    this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex = (int)TreeNodeState.Opened;
                    if (!TreeCellRenderer.nodeList.Contains(this.gridControl1[e.RowIndex, 3].Text))
                    {
                        int indent = externalData[e.RowIndex - 1].IndentLevel;
                        externalData.InsertData(e.RowIndex, this.gridControl1[e.RowIndex, 3].Text, indent);
                        TreeCellRenderer.nodeList.Add(this.gridControl1[e.RowIndex, 3].Text, "Added");
                    }
                    this.gridControl1.Refresh();
                    this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
                }
            }
        }


        private void chartControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPicture_Click(object sender, EventArgs e)
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            JobHistory jh1 = new JobHistory(strJobNumber);
            jh1.Show();
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {
            string jobnumber = strJobNumber;
            FolderSet frmFolder = new FolderSet(jobnumber);


            frmFolder.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForms.GenerateSchedule generate = new ScheduleForms.GenerateSchedule(strJobNumber);
            generate.Show();

        }
    }
}

