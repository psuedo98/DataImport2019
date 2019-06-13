namespace WipViewer
{
    partial class redtag2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.ggc1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.redTag2018BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redTagEdit = new WipViewer.RedTagEdit();
            this.redTag2018TableAdapter = new WipViewer.RedTagEditTableAdapters.RedTag2018TableAdapter();
            this.btnnew = new System.Windows.Forms.Button();
            this.gdbc1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.testEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ggc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTag2018BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTagEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdbc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ggc1
            // 
            this.ggc1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ggc1.BackColor = System.Drawing.SystemColors.Window;
            this.ggc1.DataSource = this.redTag2018BindingSource;
            this.ggc1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2016;
            this.ggc1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016White;
            this.ggc1.Location = new System.Drawing.Point(12, 12);
            this.ggc1.Name = "ggc1";
            this.ggc1.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Black;
            this.ggc1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.ggc1.Size = new System.Drawing.Size(1192, 177);
            this.ggc1.TabIndex = 0;
            this.ggc1.TableDescriptor.AllowNew = false;
            this.ggc1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 28;
            this.ggc1.TableDescriptor.TableOptions.RecordRowHeight = 28;
            this.ggc1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ggc1.TableOptions.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ggc1.Text = "gridGroupingControl1";
            this.ggc1.UseRightToLeftCompatibleTextBox = true;
            this.ggc1.VersionInfo = "16.1460.0.37";
            // 
            // redTag2018BindingSource
            // 
            this.redTag2018BindingSource.DataMember = "RedTag2018";
            this.redTag2018BindingSource.DataSource = this.redTagEdit;
            // 
            // redTagEdit
            // 
            this.redTagEdit.DataSetName = "RedTagEdit";
            this.redTagEdit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redTag2018TableAdapter
            // 
            this.redTag2018TableAdapter.ClearBeforeFill = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(12, 195);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "New Record";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // gdbc1
            // 
            this.gdbc1.AllowDragSelectedCols = true;
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = false;
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.Name = "Header";
            gridBaseStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.CellType = "Header";
            gridBaseStyle2.StyleInfo.Font.Bold = true;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle4.StyleInfo.Enabled = true;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gdbc1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gdbc1.DataSource = this.redTag2018BindingSource;
            this.gdbc1.Location = new System.Drawing.Point(27, 224);
            this.gdbc1.Name = "gdbc1";
            this.gdbc1.OptimizeInsertRemoveCells = true;
            this.gdbc1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gdbc1.Size = new System.Drawing.Size(1146, 80);
            this.gdbc1.SmartSizeBox = false;
            this.gdbc1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gdbc1.TabIndex = 2;
            this.gdbc1.Text = "gridDataBoundGrid1";
            this.gdbc1.UseListChangedEvent = true;
            this.gdbc1.UseRightToLeftCompatibleTextBox = true;
            this.gdbc1.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(this.gdbc1_CellClick);
            // 
            // testEntitiesBindingSource
            // 
            this.testEntitiesBindingSource.DataSource = typeof(WipViewer.TestEntities);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // redtag2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 426);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gdbc1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.ggc1);
            this.Name = "redtag2";
            this.Text = "redtag2";
            this.Load += new System.EventHandler(this.redtag2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ggc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTag2018BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTagEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdbc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl ggc1;
        private System.Windows.Forms.BindingSource testEntitiesBindingSource;
        private RedTagEdit redTagEdit;
        private System.Windows.Forms.BindingSource redTag2018BindingSource;
        private RedTagEditTableAdapters.RedTag2018TableAdapter redTag2018TableAdapter;
        private System.Windows.Forms.Button btnnew;
        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gdbc1;
        private System.Windows.Forms.Button btnSave;
    }
}