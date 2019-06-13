namespace WipViewer
{
    partial class JobView4
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobView4));
            this.wipDataSet = new WipViewer.WipDataSet();
            this.ribbon1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnTeams = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnRA = new System.Windows.Forms.ToolStripButton();
            this.btnAQP = new System.Windows.Forms.ToolStripButton();
            this.btnJobHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx3 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ActionItemTab = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx4 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.btnAction = new System.Windows.Forms.ToolStripButton();
            this.btnViewActions = new System.Windows.Forms.ToolStripButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblType = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblBase = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblShipdate = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.is3 = new Syncfusion.Windows.Forms.Tools.ImageStreamer();
            this.lblPm = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblProcessor = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblBl = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.lblPO = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.margin_Over_timeTableAdapter = new WipViewer.WipDataSetTableAdapters.Margin_Over_timeTableAdapter();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.commentsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCommentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsComments = new WipViewer.dsComments();
            this.ds_Comments = new WipViewer.ds_Comments();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new WipViewer.ds_CommentsTableAdapters.commentsTableAdapter();
            this.dsCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter1 = new WipViewer.dsCommentsTableAdapters.commentsTableAdapter();
            this.commentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.wipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            this.ribbon1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.toolStripEx3.SuspendLayout();
            this.ActionItemTab.Panel.SuspendLayout();
            this.toolStripEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // wipDataSet
            // 
            this.wipDataSet.DataSetName = "WipDataSet";
            this.wipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ribbon1
            // 
            this.ribbon1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbon1.Header.AddMainItem(toolStripTabItem1);
            this.ribbon1.Header.AddMainItem(ActionItemTab);
            this.ribbon1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbon1.MenuButtonText = "";
            this.ribbon1.MenuButtonWidth = 56;
            this.ribbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbon1.OfficeMenu
            // 
            this.ribbon1.OfficeMenu.Name = "OfficeMenu";
            this.ribbon1.OfficeMenu.ShowItemToolTips = true;
            this.ribbon1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbon1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbon1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbon1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.ribbon1.SelectedTab = this.toolStripTabItem1;
            this.ribbon1.ShowRibbonDisplayOptionButton = true;
            this.ribbon1.Size = new System.Drawing.Size(1400, 128);
            this.ribbon1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbon1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Text = "ribbonControlAdv1";
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbon1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx3);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Job View";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(69, 30);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Job View";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnTeams});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx1.Size = new System.Drawing.Size(209, 65);
            this.toolStripEx1.TabIndex = 0;
            this.toolStripEx1.Text = "Admin";
            this.toolStripEx1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripEx1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 48);
            this.toolStripButton1.Text = "Change Image";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Image = ((System.Drawing.Image)(resources.GetObject("btnTeams.Image")));
            this.btnTeams.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTeams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(64, 48);
            this.btnTeams.Text = "Edit Teams";
            this.btnTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.AutoSize = false;
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRA,
            this.btnAQP,
            this.btnJobHistory,
            this.toolStripButton4});
            this.toolStripEx2.Location = new System.Drawing.Point(211, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx2.Size = new System.Drawing.Size(401, 65);
            this.toolStripEx2.TabIndex = 1;
            this.toolStripEx2.Text = "Tools";
            // 
            // btnRA
            // 
            this.btnRA.Image = ((System.Drawing.Image)(resources.GetObject("btnRA.Image")));
            this.btnRA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRA.Name = "btnRA";
            this.btnRA.Size = new System.Drawing.Size(71, 48);
            this.btnRA.Text = "Risk Assess.";
            this.btnRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRA.Click += new System.EventHandler(this.btnRA_Click);
            // 
            // btnAQP
            // 
            this.btnAQP.Image = ((System.Drawing.Image)(resources.GetObject("btnAQP.Image")));
            this.btnAQP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAQP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAQP.Name = "btnAQP";
            this.btnAQP.Size = new System.Drawing.Size(52, 48);
            this.btnAQP.Text = "AQP";
            this.btnAQP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAQP.Click += new System.EventHandler(this.btnAQP_Click);
            // 
            // btnJobHistory
            // 
            this.btnJobHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnJobHistory.Image")));
            this.btnJobHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnJobHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJobHistory.Name = "btnJobHistory";
            this.btnJobHistory.Size = new System.Drawing.Size(68, 48);
            this.btnJobHistory.Text = "Job History";
            this.btnJobHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnJobHistory.Click += new System.EventHandler(this.btnJobHistory_Click);
            // 
            // toolStripEx3
            // 
            this.toolStripEx3.AutoSize = false;
            this.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx3.Image = null;
            this.toolStripEx3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStripEx3.Location = new System.Drawing.Point(614, 1);
            this.toolStripEx3.Name = "toolStripEx3";
            this.toolStripEx3.Office12Mode = false;
            this.toolStripEx3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx3.Size = new System.Drawing.Size(353, 65);
            this.toolStripEx3.TabIndex = 2;
            this.toolStripEx3.Text = "Visual Info";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(105, 48);
            this.toolStripButton2.Text = "View Labor Tickets";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(84, 48);
            this.toolStripButton3.Text = "View Material ";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // ActionItemTab
            // 
            this.ActionItemTab.Name = "ActionItemTab";
            // 
            // ribbon1.ribbonPanel2
            // 
            this.ActionItemTab.Panel.Controls.Add(this.toolStripEx4);
            this.ActionItemTab.Panel.Name = "ribbonPanel2";
            this.ActionItemTab.Panel.ScrollPosition = 0;
            this.ActionItemTab.Panel.TabIndex = 3;
            this.ActionItemTab.Panel.Text = "Action Items";
            this.ActionItemTab.Position = 1;
            this.ActionItemTab.Size = new System.Drawing.Size(86, 30);
            this.ActionItemTab.Tag = "2";
            this.ActionItemTab.Text = "Action Items";
            // 
            // toolStripEx4
            // 
            this.toolStripEx4.AutoSize = false;
            this.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx4.Image = null;
            this.toolStripEx4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAction,
            this.btnViewActions});
            this.toolStripEx4.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx4.Name = "toolStripEx4";
            this.toolStripEx4.Office12Mode = false;
            this.toolStripEx4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx4.Size = new System.Drawing.Size(340, 65);
            this.toolStripEx4.TabIndex = 0;
            // 
            // btnAction
            // 
            this.btnAction.Image = ((System.Drawing.Image)(resources.GetObject("btnAction.Image")));
            this.btnAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(119, 48);
            this.btnAction.Text = "Add New Action Item";
            this.btnAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAction.ToolTipText = "Action Items";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnViewActions
            // 
            this.btnViewActions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewActions.Image")));
            this.btnViewActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewActions.Name = "btnViewActions";
            this.btnViewActions.Size = new System.Drawing.Size(102, 48);
            this.btnViewActions.Text = "View Action Items";
            this.btnViewActions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewActions.Click += new System.EventHandler(this.btnViewActions_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Location = new System.Drawing.Point(12, 34);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "autoLabel1";
            // 
            // lblBase
            // 
            this.lblBase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBase.Location = new System.Drawing.Point(1, 7);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(90, 21);
            this.lblBase.TabIndex = 5;
            this.lblBase.Text = "autoLabel2";
            // 
            // lblShipdate
            // 
            this.lblShipdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShipdate.Location = new System.Drawing.Point(12, 47);
            this.lblShipdate.Name = "lblShipdate";
            this.lblShipdate.Size = new System.Drawing.Size(64, 13);
            this.lblShipdate.TabIndex = 6;
            this.lblShipdate.Text = "autoLabel4";
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // is3
            // 
            this.is3.AllowDragging = true;
            this.is3.InternalBackColor = System.Drawing.Color.Transparent;
            this.is3.Location = new System.Drawing.Point(230, 137);
            this.is3.MaximumSize = new System.Drawing.Size(512, 512);
            this.is3.MinimumSize = new System.Drawing.Size(128, 128);
            this.is3.Name = "is3";
            this.is3.Size = new System.Drawing.Size(512, 334);
            this.is3.SlideShow = true;
            this.is3.TabIndex = 9;
            this.is3.Text = "imageStreamer1";
            this.is3.TextAnimationDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.TextStreamDirection.TopToBottom;
            this.is3.Click += new System.EventHandler(this.is3_Click);
            // 
            // lblPm
            // 
            this.lblPm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPm.Location = new System.Drawing.Point(12, 81);
            this.lblPm.Name = "lblPm";
            this.lblPm.Size = new System.Drawing.Size(64, 13);
            this.lblPm.TabIndex = 10;
            this.lblPm.Text = "autoLabel1";
            // 
            // lblProcessor
            // 
            this.lblProcessor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcessor.Location = new System.Drawing.Point(12, 94);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(64, 13);
            this.lblProcessor.TabIndex = 11;
            this.lblProcessor.Text = "autoLabel1";
            // 
            // lblBl
            // 
            this.lblBl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBl.Location = new System.Drawing.Point(12, 107);
            this.lblBl.Name = "lblBl";
            this.lblBl.Size = new System.Drawing.Size(64, 13);
            this.lblBl.TabIndex = 12;
            this.lblBl.Text = "autoLabel1";
            // 
            // lblPO
            // 
            this.lblPO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPO.Location = new System.Drawing.Point(12, 120);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(64, 13);
            this.lblPO.TabIndex = 13;
            this.lblPO.Text = "autoLabel1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Margin_Over_time";
            this.bindingSource1.DataSource = this.wipDataSet;
            // 
            // margin_Over_timeTableAdapter
            // 
            this.margin_Over_timeTableAdapter.ClearBeforeFill = true;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.autoLabel1.Location = new System.Drawing.Point(1, 60);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(82, 21);
            this.autoLabel1.TabIndex = 8;
            this.autoLabel1.Text = "Team Info";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.Controls.Add(this.autoLabel1);
            this.gradientPanel1.Controls.Add(this.lblBase);
            this.gradientPanel1.Controls.Add(this.lblPm);
            this.gradientPanel1.Controls.Add(this.lblPO);
            this.gradientPanel1.Controls.Add(this.lblProcessor);
            this.gradientPanel1.Controls.Add(this.lblType);
            this.gradientPanel1.Controls.Add(this.lblShipdate);
            this.gradientPanel1.Controls.Add(this.lblBl);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 128);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(224, 372);
            this.gradientPanel1.TabIndex = 17;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.commentsBindingSource4;
            this.gridGroupingControl1.Location = new System.Drawing.Point(748, 154);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(583, 296);
            this.gridGroupingControl1.TabIndex = 19;
            this.gridGroupingControl1.TableDescriptor.AllowEdit = false;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.AllowRemove = false;
            gridColumnDescriptor2.MappingName = "comment";
            gridColumnDescriptor2.Width = 500;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("baseid"),
            gridColumnDescriptor2,
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("date"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("id"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("commenter")});
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "16.3460.0.21";
            this.gridGroupingControl1.TableControlCellClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.gridGroupingControl1_TableControlCellClick);
            // 
            // commentsBindingSource4
            // 
            this.commentsBindingSource4.DataMember = "comments";
            this.commentsBindingSource4.DataSource = this.dsCommentsBindingSource1;
            // 
            // dsCommentsBindingSource1
            // 
            this.dsCommentsBindingSource1.DataSource = this.dsComments;
            this.dsCommentsBindingSource1.Position = 0;
            // 
            // dsComments
            // 
            this.dsComments.DataSetName = "dsComments";
            this.dsComments.EnforceConstraints = false;
            this.dsComments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_Comments
            // 
            this.ds_Comments.DataSetName = "ds_Comments";
            this.ds_Comments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "comments";
            this.commentsBindingSource.DataSource = this.ds_Comments;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // dsCommentsBindingSource
            // 
            this.dsCommentsBindingSource.DataSource = this.dsComments;
            this.dsCommentsBindingSource.Position = 0;
            // 
            // commentsBindingSource1
            // 
            this.commentsBindingSource1.DataMember = "comments";
            this.commentsBindingSource1.DataSource = this.ds_Comments;
            // 
            // commentsBindingSource2
            // 
            this.commentsBindingSource2.DataMember = "comments";
            this.commentsBindingSource2.DataSource = this.dsCommentsBindingSource;
            // 
            // commentsTableAdapter1
            // 
            this.commentsTableAdapter1.ClearBeforeFill = true;
            // 
            // commentsBindingSource3
            // 
            this.commentsBindingSource3.DataMember = "comments";
            this.commentsBindingSource3.DataSource = this.ds_Comments;
            // 
            // btnSave
            // 
            this.btnSave.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(154, 32);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(1177, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Submit Comment";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 48);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // JobView4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridGroupingControl1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.is3);
            this.Name = "JobView4";
            this.Text = "JobView4";
            this.Load += new System.EventHandler(this.JobView4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            this.ribbon1.ResumeLayout(false);
            this.ribbon1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.toolStripEx3.ResumeLayout(false);
            this.toolStripEx3.PerformLayout();
            this.ActionItemTab.Panel.ResumeLayout(false);
            this.toolStripEx4.ResumeLayout(false);
            this.toolStripEx4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbon1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ImageList imageList2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblType;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblBase;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblShipdate;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private Syncfusion.Windows.Forms.Tools.ImageStreamer is3;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private System.Windows.Forms.ToolStripButton btnRA;
        private System.Windows.Forms.ToolStripButton btnAQP;
        private System.Windows.Forms.ToolStripButton btnJobHistory;
        private System.Windows.Forms.ToolStripButton btnTeams;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPm;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblProcessor;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblBl;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPO;
        private WipDataSet wipDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private WipDataSetTableAdapters.Margin_Over_timeTableAdapter margin_Over_timeTableAdapter;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private ds_Comments ds_Comments;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private ds_CommentsTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.BindingSource commentsBindingSource1;
        private dsComments dsComments;
        private System.Windows.Forms.BindingSource dsCommentsBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource2;
        private dsCommentsTableAdapters.commentsTableAdapter commentsTableAdapter1;
        private System.Windows.Forms.BindingSource commentsBindingSource3;
        private System.Windows.Forms.BindingSource commentsBindingSource4;
        private System.Windows.Forms.BindingSource dsCommentsBindingSource1;
        private Syncfusion.Windows.Forms.ButtonAdv btnSave;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem ActionItemTab;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx4;
        private System.Windows.Forms.ToolStripButton btnAction;
        public System.Windows.Forms.ToolStripButton btnViewActions;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}