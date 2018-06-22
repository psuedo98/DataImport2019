using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid.Design;
using Syncfusion.Windows.Forms.Grid.Formulas;
using Syncfusion;
using Syncfusion.GroupingGridExcelConverter;
using Syncfusion.GridHelperClasses.Zoom;
using Syncfusion.Windows.Forms;

namespace WipViewer
{


    public partial class testgrid2 : Form
    {


        public Image image;
        public int zoomFactor = 100;
        public ZoomGroupingGrid zoom;
        public int machinehrs;

       public  GridConditionalFormatDescriptor f1 = new GridConditionalFormatDescriptor();
        public GridConditionalFormatDescriptor f2 = new GridConditionalFormatDescriptor();



        public testgrid2()
        {
            InitializeComponent();
        }

        private void testgrid2_Load(object sender, EventArgs e)
        {
            gc1.ShowGroupDropArea = true;
            // gc1.DataSource = ds_activejobs;
            activeJobsTableAdapter.Fill(this.ds_activejobs.ActiveJobs);

            gc1.TableModel.ReadOnly = true;

            zoom = new ZoomGroupingGrid(gc1);

            // gc1.DataMember = ds_activejobs.ActiveJobs; 

            Syncfusion.Grouping.SortColumnDescriptor cd = new Syncfusion.Grouping.SortColumnDescriptor("ShipDate");

            cd.Categorizer = new CustomCategorizer();
            this.gc1.TableDescriptor.GroupedColumns.Add(cd);
         //   this.gc1.QueryCellText += gc1_QueryCellText; 

            //Summary Columns 

            #region summary columns

            gc1.TableDescriptor.VisibleColumns.Remove("ShipMonth");
            gc1.TableDescriptor.VisibleColumns.Remove("Batch");
            gc1.TableDescriptor.Columns["ShipDate"].Appearance.AnyRecordFieldCell.Format = "MM/dd/yyyy";

            gc1.TableDescriptor.Appearance.AnyRecordFieldCell.WrapText = true;

            gc1.TableModel.RowHeights.ResizeToFit(GridRangeInfo.Table());

            GridSummaryColumnDescriptor sc1 = new GridSummaryColumnDescriptor();
            sc1.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc1.DataMember = "RemainingRev";
            sc1.Format = "{Sum}";
            sc1.Name = "Remaining Revenue";
            sc1.SummaryType = SummaryType.Int32Aggregate;

           
            

            GridSummaryColumnDescriptor sc2 = new GridSummaryColumnDescriptor();
            sc2.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc2.DataMember = "POValue";
            sc2.Format = "{Sum}";
            sc2.Name = "Purchase Order Value";
            sc2.SummaryType = SummaryType.Int32Aggregate;

            
         //   sc2.TableDescriptor.Columns[0].Appearance.AnyRecordFieldCell.Format = "C"; 
            

            GridSummaryColumnDescriptor sc3 = new GridSummaryColumnDescriptor();
            sc3.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc3.DataMember = "Actual";
            sc3.Format = "{Sum}";
            sc3.Name = "Actual";
            sc3.SummaryType = SummaryType.Int32Aggregate;

            sc1.Appearance.AnySummaryCell.Format = "c";
            sc2.Appearance.AnySummaryCell.Format = "c";
            sc3.Appearance.AnySummaryCell.Format = "c";

            GridSummaryColumnDescriptor sc4 = new GridSummaryColumnDescriptor();
            sc4.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc4.DataMember = "Weld";
            sc4.Format = "{Sum}";
            sc4.Name = "Weld Hours Remaining";
            sc4.SummaryType = SummaryType.Int32Aggregate;

            GridSummaryColumnDescriptor sc5 = new GridSummaryColumnDescriptor();
            sc5.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc5.DataMember = "Machine";
            sc5.Format = "{Sum}";
            sc5.Name = "Machine Hours Remaining";
            sc5.SummaryType = SummaryType.Int32Aggregate;

            GridSummaryColumnDescriptor sc6 = new GridSummaryColumnDescriptor();
            sc6.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc6.DataMember = "Design";
            sc6.Format = "{Sum}";
            sc6.Name = "Design Hours Remaining";
            sc6.SummaryType = SummaryType.Int32Aggregate;

            GridSummaryColumnDescriptor sc7 = new GridSummaryColumnDescriptor();
            sc7.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc7.DataMember = "Tracker";
            sc7.Format = "{Sum}";
            sc7.Name = "Tracker Hours Remaining";
            sc7.SummaryType = SummaryType.Int32Aggregate;

            GridSummaryColumnDescriptor sc8 = new GridSummaryColumnDescriptor();
            sc8.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(192, 255, 165));
            sc8.DataMember = "Build";
            sc8.Format = "{Sum}";
            sc8.Name = "Build Hours Remaining";
            sc8.SummaryType = SummaryType.Int32Aggregate;


            GridSummaryRowDescriptor sr1 = new GridSummaryRowDescriptor();
            sr1.SummaryColumns.Add(sc1);
            sr1.SummaryColumns.Add(sc2);
            sr1.SummaryColumns.Add(sc3);
            sr1.SummaryColumns.Add(sc4);
            sr1.SummaryColumns.Add(sc5);
            sr1.SummaryColumns.Add(sc6);
            sr1.SummaryColumns.Add(sc7);
            sr1.SummaryColumns.Add(sc8);

            gc1.Appearance.AnySummaryCell.HorizontalAlignment = GridHorizontalAlignment.Right; 

            sr1.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(255, 231, 162));

            gc1.TableDescriptor.SummaryRows.Add(sr1);

            #endregion


            //   gc1.TableControl.PrepareViewStyleInfo += new;

            gc1.TableControl.CommentTipShowing += new CommentTipShowingEventHandler(TableControl_CommentTipShowing); 



            //GridConditionalFormatDescriptor f1 = new GridConditionalFormatDescriptor();
            f1.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(220,20,60));
            f1.Appearance.AnyRecordFieldCell.TextColor = Color.White;
            f1.Expression = "[age1] > 10 and [Comp] < 20"; 
            f1.Name = "Format1";

            //GridConditionalFormatDescriptor f2 = new GridConditionalFormatDescriptor();
            f2.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(30,144,255));
            f2.Appearance.AnyRecordFieldCell.TextColor = Color.White;
            f2.Expression = "[age1] < 10";
            f2.Name = "Format2";

            gc1.TableDescriptor.ConditionalFormats.Add(f1);
            gc1.TableDescriptor.ConditionalFormats.Add(f2);

            gc1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gc1_QueryCellStyleInfo);
            gc1.SourceListListChangedCompleted += Gc1_SourceListListChangedCompleted;

            GridColumnDescriptor desc1 = new GridColumnDescriptor();

            desc1.MappingName = "BaseID";
            desc1.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(237, 240, 246));

            gc1.TableControl.HScroll = true;
            gc1.TableControl.VScroll = true; 

            if(gc1.TableControl.HScrollBar.InnerScrollBar != null && gc1.TableControl.VScrollBar != null)
            {
                gc1.TableControl.HScrollBar.InnerScrollBar.Height = 50;
                gc1.TableControl.VScrollBar.InnerScrollBar.Height = 50;

            }

            
            gc1.TableControl.ControlAdded += TableControl_ControlAdded;








    }

        private void Gc1_SourceListListChangedCompleted(object sender, TableListChangedEventArgs e)
        {
            var r = this.gc1.TableModel.RowCount;
            var p = this.gc1.TableModel.Rows.Model.RowCount;
           GridSummaryRow rec = this.gc1.Table.DisplayElements[r] as GridSummaryRow;
            GridRecordRow row = this.gc1.Table.DisplayElements[r] as GridRecordRow; 
            if (row is GridRecordRow)
            {
                MessageBox.Show("row"); 
            }
            if(rec is GridSummaryRow)
            {

                foreach(var scd in rec.SummaryRowDescriptor.SummaryColumns)
                {
                    if (scd.Name == "Machine Hours Remaining")
                    {
                        txtMachine.Text = GridEngine.GetSummaryText(rec.ParentGroup, scd);
                    }
                    else if (scd.Name == "Weld Hours Remaining")
                    {
                        txtWeld.Text = GridEngine.GetSummaryText(rec.ParentGroup, scd);
                    }
                    else if (scd.Name == "Build Hours Remaining")
                    {
                        txtBuild.Text = GridEngine.GetSummaryText(rec.ParentGroup, scd); 
                    }
                    else if (scd.Name == "Tracker Hours Remaining")
                    {
                        txtTrackers.Text = GridEngine.GetSummaryText(rec.ParentGroup, scd);
                    }
                    else if (scd.Name == "Design Hours Remaining")
                    {
                        txtDesign.Text = GridEngine.GetSummaryText(rec.ParentGroup, scd); 
                    }

                }
            }
        }

        void TableControl_CommentTipShowing(object sender, CommentTipShowingEventArgs e)
        {
            Point pt = e.CommentTipWindow.Location;
            e.CommentTipWindow.Location = new Point(pt.X + 80, pt.Y + 20); 
        }

        private void TableControl_ControlAdded(object sender, ControlEventArgs e)
        {
            Syncfusion.Windows.Forms.HScrollBarCustomDraw hscrollBar = e.Control as HScrollBarCustomDraw;
            VScrollBarCustomDraw vScollBar = e.Control as VScrollBarCustomDraw;
            if (hscrollBar != null)
            {
                hscrollBar.Height = 50;
                hscrollBar.ForeColor = Color.Blue;
                hscrollBar.BackColor = Color.Red;
                gc1.TableControl.HScrollBar.InnerScrollBar.ForeColor = Color.Blue; 


            }
            if (vScollBar != null)
            {
                vScollBar.Width = 50;
                vScollBar.BackColor = Color.Blue;
                vScollBar.ForeColor = Color.Red;
                gc1.TableControl.VScrollBar.InnerScrollBar.ForeColor = Color.Blue; 
            }
        }

        void gc1_QueryCellText(object sender, GridTableCellStyleInfoEventArgs e)
        {

            if (e.TableCellIdentity.TableCellType == GridTableCellType.SummaryFieldCell)
            {
                foreach (var summaryRow in this.gc1.TableDescriptor.SummaryRows)
                {
                    foreach (var sc in summaryRow.SummaryColumns)
                    {
                        switch (sc.Name)
                        {
                            case "Weld Hours Remaining":
                                txtWeld.Text = e.Style.CellValue.ToString();
                                break;
                            case "Machine Hours Remaining":
                               // txtMachine.Text = e.Style.CellValue.ToString();
                                break;
                            case "Build Hours Remaining":
                                txtBuild.Text = e.Style.CellValue.ToString();
                                break;
                            case "Tracker Hours Remaining":
                                txtTrackers.Text = e.Style.CellValue.ToString();
                                break;
                            case "Design Hours Remaining":
                                txtDesign.Text = e.Style.CellValue.ToString();
                                break; 
                            default:
                                break;


                        }
                    }
                }
            }
        }
    //if (sc.Name == e.TableCellIdentity.SummaryColumn.Name)
    //{
    //    textBox1.Text = e.Style.CellValue.ToString();
    //}

                   
                
        void gc1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            
            var db = new TestEntities();

            #region PicturesOn
            if (rb1.Checked == true)
            {

                if (e.Style.TableCellIdentity.Column != null && e.Style.TableCellIdentity.Column.Name == "BaseID" && e.TableCellIdentity.DisplayElement.Kind == Syncfusion.Grouping.DisplayElementKind.Record)
                {

                    picture findpic = db.pictures.Find(e.Style.CellValue.ToString());

                    if (findpic != null)
                    {
                        using (var bmpTemp = new Bitmap(findpic.Path))
                        {
                            image = new Bitmap(bmpTemp);
                            e.Style.CommentTip.CommentImage = image;
                            e.Style.CommentTip.CommentArrowColor = Color.Green;
                            e.Style.CommentTip.CommentIndicatorColor = Color.White;

                            
                        }
                    }

                    else
                    {
                        e.Style.CommentTip.CommentImage = Image.FromFile(@"r:\wippictures\na.jpg");
                        e.Style.CommentTip.CommentArrowColor = Color.Red;
                        e.Style.CommentTip.CommentIndicatorColor = Color.Black;
                    }
                }

               
            }

            #endregion

        //    int machinehrs = 0;
            int weldhrs = 0;
            int buildhrs = 0;
            
            //if (e.Style.TableCellIdentity.Column != null && e.TableCellIdentity.DisplayElement.Kind == Syncfusion.Grouping.DisplayElementKind.Record)
            //{
            //    //switch (e.Style.TableCellIdentity.Column.Name)
            //    //{
            //    //    case "Machine":
            //    //        machinehrs += Convert.ToInt16(e.Style.CellValue);
            //    //        //   txtMachine.Text = machinehrs.ToString(); 
            //    //        break;
            //    //}

            //    txtMachine.Text = machinehrs.ToString();
            //}

        }
        




        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }


        private void event2(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {


            var s = this.gc1.Table.SelectedRecords;

            GridRangeInfoList s1 = this.gc1.TableModel.Selections.GetSelectedRows(true, true);

            //to get row index range 
            foreach (GridRangeInfo info in s1)
            {
                Element el = gc1.TableModel.GetDisplayElementAt(info.Top);

                string job = el.GetRecord().GetValue("BaseID").ToString();
                string type = el.GetRecord().GetValue("Type").ToString();
                string shipdate = el.GetRecord().GetValue("ShipDate").ToString();

                testjobview ts1 = new testjobview(job, type, shipdate);
                ts1.Show();





                //to get cellvalue of particular column from selected row. 

            }
        }

        public class CustomCategorizer : Syncfusion.Grouping.IGroupByColumnCategorizer
        {
            public static int GetCategory(int i)
            {
                int ret = 0;
                if (i == 1)
                    ret = 1;
                else if (i == 2)
                    ret = 2;
                else if (i == 3)
                    ret = 3;
                else if (i == 4)
                    ret = 4;
                else if (i == 5)
                    ret = 5;
                else if (i == 6)
                    ret = 6;
                else if (i == 7)
                    ret = 7;
                else if (i == 8)
                    ret = 8;
                else if (i == 9)
                    ret = 9;
                else if (i == 10)
                    ret = 10;
                else if (i == 11)
                    ret = 11;
                else
                    ret = 12;

                return ret;
            }

            public static int GetMonths(string value)
            {
                switch (value)
                {
                    case "January":
                        return 1;
                    case "February":
                        return 2;
                    case "March":
                        return 3;
                    case "April":
                        return 4;
                    case "May":
                        return 5;
                    case "June":
                        return 6;
                    case "July":
                        return 7;
                    case "August":
                        return 8;
                    case "September":
                        return 9;
                    case "October":
                        return 10;
                    case "November":
                        return 11;
                    case "December":
                        return 12;
                    default:
                        return 0;
                }
            }

            //public int CompareCategoryKey(SortColumnDescriptor column, bool isForeignKey, object category, Record record)
            //{
            //    throw new NotImplementedException();
            //}

            #region IGroupByColumnCategorizer Members 

            //public object GetGroupByCategoryKey(SortColumnDescriptor column, bool isForeignKey, Record record)
            //{
            //    if (column.FieldDescriptor.FieldPropertyType == typeof(DateTime))
            //    {
            //        DateTime date = (DateTime)record.GetValue(column);
            //        int i = date.Month;
            //        return GetCategory(int.Parse(i.ToString()));
            //    }
            //    else
            //        return GetCategory(int.Parse(record.GetValue(column).ToString()));
            //}

            public object GetGroupByCategoryKey(SortColumnDescriptor column, bool isForeignKey, Record record)
            {
                if (column.FieldDescriptor.FieldPropertyType == typeof(DateTime))
                {
                    DateTime date = (DateTime)record.GetValue(column);
                    return date.ToString("MMMM");
                }
                else
                    return int.Parse(record.GetValue(column).ToString());
            }




            //public int CompareCategoryKey(SortColumnDescriptor column, bool isForeignKey, object category, Record record)
            //{
            //    if (column.FieldDescriptor.FieldPropertyType == typeof(DateTime))
            //    {
            //        DateTime date = (DateTime)record.GetValue(column);
            //        int i = date.Month;
            //        return GetCategory(int.Parse(i.ToString())) - (int)category;
            //    }
            //    else
            //        return GetCategory(int.Parse(record.GetValue(column).ToString())) - (int)category;
            //}

            public int CompareCategoryKey(SortColumnDescriptor column, bool isForeignKey, object category, Record record)
            {
                if (column.FieldDescriptor.FieldPropertyType == typeof(DateTime))
                {
                    DateTime date = (DateTime)record.GetValue(column);
                    int i = date.Month;
                    //To return the month name   
                    return i - GetMonths(category.ToString());
                }
                else
                    return int.Parse(record.GetValue(column).ToString()) - (int)category;
            }



            #endregion
        }

        #region ButtonClickEvents
        private void btnJanuary_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 1); 
        }

        private void btnFeb_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 2);
        }

        private void btnMar_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 3);
        }

        private void btnApr_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 4);
        }

        private void gc1_TableControlCellClick(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventArgs e)
        {

        }

        private void btnMay_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 5);
        }

        private void btnJune_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 6);
        }

        private void btnJul_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 7);
        }

        private void btnAug_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 8);
        }

        private void btnSep_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 9);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 10);
        }

        private void btnNov_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 11);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, 12);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLosers_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.FillLosers(ds_activejobs.ActiveJobs);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.Fill(ds_activejobs.ActiveJobs);
        }

        private void btnLate_Click(object sender, EventArgs e)
        {
            activeJobsTableAdapter.LateFill(ds_activejobs.ActiveJobs, DateTime.Now.ToString());
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            GroupingGridExcelConverterControl converter = new GroupingGridExcelConverterControl();

            converter.GroupingGridToExcel(gc1, "c:\\wipviewer\\grid.xls", Syncfusion.GridExcelConverter.ConverterOptions.Default); 
           // converter.GroupingGridToExcel(gc1, "Grid.xls", Syncfusion.GridExcelConverter.ConverterOptions.Visible); 
           // groupinggriexcel
          
        }

        private void btnExportVisible_Click(object sender, EventArgs e)
        {
            GroupingGridExcelConverterControl convert_visible = new GroupingGridExcelConverterControl();

            convert_visible.GroupingGridToExcel(gc1, "c:\\wipviewer\\gridVisible.xls", Syncfusion.GridExcelConverter.ConverterOptions.Visible);
        }

        #endregion

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            zoomFactor = zoomFactor +25; 
            
            zoom.zoomGrid(zoomFactor.ToString()); 
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            zoomFactor = zoomFactor -25;
            
            zoom.zoomGrid(zoomFactor.ToString()); 
        }

        private void lblViewTotals_Click(object sender, EventArgs e)
        {

        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {

            string strView = cmbView.Text.ToString();
            viewChange(strView);




             //foreach (var summaryRow in this.gc1.TableDescriptor.SummaryRows)
             //   {
             //   foreach (var sc in summaryRow.SummaryColumns)
             //   {

                    
             //       string test = sc.DataMember[1].ToString(); 
             //           switch (sc.Name)
             //           {
             //               case "Weld Hours Remaining":
             //        //           txtWeld.Text = sc.
             //               //    e.Style.CellValue.ToString();
             //                   break;
             //               default:
             //                   break;


             //           }
             //       }
             //   }


        }

        private void viewChange(string view)
        {
            int monthNumber = 0; 
            switch (view)
            {
                case "January":
                    monthNumber = 1;
                    break;
                case "February":
                    monthNumber = 2;
                    break;
                case "March":
                    monthNumber = 3;
                    break;
                case "April":
                    monthNumber = 4;
                    break;
                case "May":
                    monthNumber = 5;
                    break;
                case "June":
                    monthNumber = 6;
                    break;
                case "July":
                    monthNumber = 7;
                    break;
                case "August":
                    monthNumber = 8;
                    break;
                case "September":
                    monthNumber = 9;
                    break;
                case "October":
                    monthNumber = 10;
                    break;
                case "November":
                    monthNumber = 11;
                    break;
                case "December":
                    monthNumber = 12;
                    break;
                case "Late Jobs":
                    activeJobsTableAdapter.LateFill(ds_activejobs.ActiveJobs, DateTime.Now.ToString());
                    break;
                case "Losers":
                    activeJobsTableAdapter.FillLosers(ds_activejobs.ActiveJobs);
                    break; 
                default:
                    monthNumber = Convert.ToInt16(DateTime.Now.ToString("MM"));
                    break; 
            }


            if (monthNumber > 0)
            {
                activeJobsTableAdapter.GetMonthNY(ds_activejobs.ActiveJobs, monthNumber);
            }



         

          






        }

        private void gc1_QueryCellText(object sender, GridCellTextEventArgs e)
        {
          
        }

        private void gc1_DataSourceChanged(object sender, EventArgs e)
        {
            int machinehrs = 0;
            int weldhrs = 0;
            int buildhrs = 0;

            //if (e.Style.TableCellIdentity.Column != null && e.TableCellIdentity.DisplayElement.Kind == Syncfusion.Grouping.DisplayElementKind.Record)
            //{
            //    switch (e.Style.TableCellIdentity.Column.Name)
            //    {
            //        case "Machine":
            //            machinehrs += Convert.ToInt16(e.Style.CellValue);
            //            break;
            //    }

            //    txtMachine.Text = machinehrs.ToString();
            //}
        }

        private void gc1_SourceListListChangedCompleted(object sender, TableListChangedEventArgs e)
        {
           
                this.gc1.TableControl.Invalidate();
            machinehrs = 0; 
            }

        private void rbShowColors_CheckChanged(object sender, EventArgs e)
        {
            if (rbShowColors.Checked == true)
            {
                
                //f1.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(220, 20, 60));
                //f1.Appearance.AnyRecordFieldCell.TextColor = Color.White;
                //f1.Expression = "[age1] > 10 and [Comp] < 20";
                //f1.Name = "Format1";

                
                //f2.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(30, 144, 255));
                //f2.Appearance.AnyRecordFieldCell.TextColor = Color.White;
                //f2.Expression = "[age1] < 10";
                //f2.Name = "Format2";

                gc1.TableDescriptor.ConditionalFormats.Add(f1);
                gc1.TableDescriptor.ConditionalFormats.Add(f2);
            }

            else if (rbHideColors.Checked == true)
            {
                gc1.TableDescriptor.ConditionalFormats.Remove(f1);
                gc1.TableDescriptor.ConditionalFormats.Remove(f2);
            }
        }
    }
    }


  
    





        //private void label5_Click(object sender, EventArgs e)
        //{

        //}
    





