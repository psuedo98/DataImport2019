namespace WipViewer
{
    partial class DataView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataView));
            this.dgvActiveJobs = new System.Windows.Forms.DataGridView();
            this.baseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_activejobs = new WipViewer.ds_activejobs();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnJobView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVCT = new System.Windows.Forms.Button();
            this.rb2018 = new System.Windows.Forms.RadioButton();
            this.rb2017 = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLosers = new System.Windows.Forms.Button();
            this.btnOctober = new System.Windows.Forms.Button();
            this.btnDecember = new System.Windows.Forms.Button();
            this.btnNovember = new System.Windows.Forms.Button();
            this.btnJuly = new System.Windows.Forms.Button();
            this.btnJune = new System.Windows.Forms.Button();
            this.btnSeptember = new System.Windows.Forms.Button();
            this.btnAugust = new System.Windows.Forms.Button();
            this.btnMarch = new System.Windows.Forms.Button();
            this.btnFebruary = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnJanuary = new System.Windows.Forms.Button();
            this.btnApril = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblViews = new System.Windows.Forms.Label();
            this.btnLate = new System.Windows.Forms.Button();
            this.bthThisMonth = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHoldValue = new System.Windows.Forms.Label();
            this.lblHoldValueTitle = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrackerhrs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDesignhrs = new System.Windows.Forms.Label();
            this.lblBuild = new System.Windows.Forms.Label();
            this.lblBuildhrs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeldhrs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMachinehrs = new System.Windows.Forms.Label();
            this.lblSelectionHeader = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.activeJobsTableAdapter = new WipViewer.ds_activejobsTableAdapters.ActiveJobsTableAdapter();
            this.lblHoldTitle = new System.Windows.Forms.Label();
            this.lblSelectedPending = new System.Windows.Forms.Label();
            this.lblSelectedHold = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_activejobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActiveJobs
            // 
            this.dgvActiveJobs.AllowUserToAddRows = false;
            this.dgvActiveJobs.AllowUserToDeleteRows = false;
            this.dgvActiveJobs.AllowUserToOrderColumns = true;
            this.dgvActiveJobs.AutoGenerateColumns = false;
            this.dgvActiveJobs.BackgroundColor = System.Drawing.Color.White;
            this.dgvActiveJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.compDataGridViewTextBoxColumn,
            this.pOValueDataGridViewTextBoxColumn,
            this.actualDataGridViewTextBoxColumn,
            this.margin,
            this.RemainingRev,
            this.shipDateDataGridViewTextBoxColumn,
            this.machineDataGridViewTextBoxColumn,
            this.buildDataGridViewTextBoxColumn,
            this.weldDataGridViewTextBoxColumn,
            this.designDataGridViewTextBoxColumn,
            this.trackerDataGridViewTextBoxColumn,
            this.BuildLeader,
            this.ProgramManager,
            this.Processor,
            this.QA,
            this.Hold});
            this.dgvActiveJobs.DataSource = this.activeJobsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveJobs.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvActiveJobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvActiveJobs.Location = new System.Drawing.Point(0, 0);
            this.dgvActiveJobs.Name = "dgvActiveJobs";
            this.dgvActiveJobs.ReadOnly = true;
            this.dgvActiveJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveJobs.Size = new System.Drawing.Size(1469, 761);
            this.dgvActiveJobs.TabIndex = 0;
            this.dgvActiveJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveJobs_CellContentClick_1);
            this.dgvActiveJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveJobs_CellDoubleClick);
            this.dgvActiveJobs.SelectionChanged += new System.EventHandler(this.dgvActiveJobs_SelectionChanged);
            this.dgvActiveJobs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvActiveJobs_KeyPress);
            // 
            // baseIDDataGridViewTextBoxColumn
            // 
            this.baseIDDataGridViewTextBoxColumn.DataPropertyName = "BaseID";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.baseIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.baseIDDataGridViewTextBoxColumn.HeaderText = "Job #";
            this.baseIDDataGridViewTextBoxColumn.Name = "baseIDDataGridViewTextBoxColumn";
            this.baseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseIDDataGridViewTextBoxColumn.Width = 190;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 165;
            // 
            // compDataGridViewTextBoxColumn
            // 
            this.compDataGridViewTextBoxColumn.DataPropertyName = "Comp";
            this.compDataGridViewTextBoxColumn.HeaderText = "% Comp";
            this.compDataGridViewTextBoxColumn.Name = "compDataGridViewTextBoxColumn";
            this.compDataGridViewTextBoxColumn.ReadOnly = true;
            this.compDataGridViewTextBoxColumn.Width = 70;
            // 
            // pOValueDataGridViewTextBoxColumn
            // 
            this.pOValueDataGridViewTextBoxColumn.DataPropertyName = "POValue";
            this.pOValueDataGridViewTextBoxColumn.HeaderText = "PO Value";
            this.pOValueDataGridViewTextBoxColumn.Name = "pOValueDataGridViewTextBoxColumn";
            this.pOValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actualDataGridViewTextBoxColumn
            // 
            this.actualDataGridViewTextBoxColumn.DataPropertyName = "Actual";
            this.actualDataGridViewTextBoxColumn.HeaderText = "Actual";
            this.actualDataGridViewTextBoxColumn.Name = "actualDataGridViewTextBoxColumn";
            this.actualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // margin
            // 
            this.margin.DataPropertyName = "margin";
            this.margin.HeaderText = "Margin";
            this.margin.Name = "margin";
            this.margin.ReadOnly = true;
            // 
            // RemainingRev
            // 
            this.RemainingRev.DataPropertyName = "RemainingRev";
            this.RemainingRev.HeaderText = "RemainingRev";
            this.RemainingRev.Name = "RemainingRev";
            this.RemainingRev.ReadOnly = true;
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "Ship Date";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            this.shipDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.shipDateDataGridViewTextBoxColumn.Width = 79;
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "Machine";
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            this.machineDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineDataGridViewTextBoxColumn.Width = 73;
            // 
            // buildDataGridViewTextBoxColumn
            // 
            this.buildDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.buildDataGridViewTextBoxColumn.DataPropertyName = "Build";
            this.buildDataGridViewTextBoxColumn.HeaderText = "Build";
            this.buildDataGridViewTextBoxColumn.Name = "buildDataGridViewTextBoxColumn";
            this.buildDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildDataGridViewTextBoxColumn.Width = 55;
            // 
            // weldDataGridViewTextBoxColumn
            // 
            this.weldDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.weldDataGridViewTextBoxColumn.DataPropertyName = "Weld";
            this.weldDataGridViewTextBoxColumn.HeaderText = "Weld";
            this.weldDataGridViewTextBoxColumn.Name = "weldDataGridViewTextBoxColumn";
            this.weldDataGridViewTextBoxColumn.ReadOnly = true;
            this.weldDataGridViewTextBoxColumn.Width = 57;
            // 
            // designDataGridViewTextBoxColumn
            // 
            this.designDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.designDataGridViewTextBoxColumn.DataPropertyName = "Design";
            this.designDataGridViewTextBoxColumn.HeaderText = "Design";
            this.designDataGridViewTextBoxColumn.Name = "designDataGridViewTextBoxColumn";
            this.designDataGridViewTextBoxColumn.ReadOnly = true;
            this.designDataGridViewTextBoxColumn.Width = 65;
            // 
            // trackerDataGridViewTextBoxColumn
            // 
            this.trackerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trackerDataGridViewTextBoxColumn.DataPropertyName = "Tracker";
            this.trackerDataGridViewTextBoxColumn.HeaderText = "Tracker";
            this.trackerDataGridViewTextBoxColumn.Name = "trackerDataGridViewTextBoxColumn";
            this.trackerDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackerDataGridViewTextBoxColumn.Width = 69;
            // 
            // BuildLeader
            // 
            this.BuildLeader.DataPropertyName = "BuildLeader";
            this.BuildLeader.HeaderText = "Build Leader";
            this.BuildLeader.Name = "BuildLeader";
            this.BuildLeader.ReadOnly = true;
            // 
            // ProgramManager
            // 
            this.ProgramManager.DataPropertyName = "ProgramManager";
            this.ProgramManager.HeaderText = "PM";
            this.ProgramManager.Name = "ProgramManager";
            this.ProgramManager.ReadOnly = true;
            // 
            // Processor
            // 
            this.Processor.DataPropertyName = "Processor";
            this.Processor.HeaderText = "Processor";
            this.Processor.Name = "Processor";
            this.Processor.ReadOnly = true;
            // 
            // QA
            // 
            this.QA.DataPropertyName = "QA";
            this.QA.HeaderText = "QA";
            this.QA.Name = "QA";
            this.QA.ReadOnly = true;
            // 
            // Hold
            // 
            this.Hold.DataPropertyName = "Hold";
            this.Hold.HeaderText = "Hold";
            this.Hold.Name = "Hold";
            this.Hold.ReadOnly = true;
            // 
            // activeJobsBindingSource
            // 
            this.activeJobsBindingSource.DataMember = "ActiveJobs";
            this.activeJobsBindingSource.DataSource = this.ds_activejobs;
            // 
            // ds_activejobs
            // 
            this.ds_activejobs.DataSetName = "ds_activejobs";
            this.ds_activejobs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnComment);
            this.panel1.Controls.Add(this.btnJobView);
            this.panel1.Location = new System.Drawing.Point(1480, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 62);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnComment
            // 
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(25, 33);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(126, 29);
            this.btnComment.TabIndex = 2;
            this.btnComment.Text = "Add Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnJobView
            // 
            this.btnJobView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobView.Location = new System.Drawing.Point(25, 3);
            this.btnJobView.Name = "btnJobView";
            this.btnJobView.Size = new System.Drawing.Size(126, 27);
            this.btnJobView.TabIndex = 1;
            this.btnJobView.Text = "Open Job";
            this.btnJobView.UseVisualStyleBackColor = true;
            this.btnJobView.Click += new System.EventHandler(this.btnJobView_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVCT);
            this.panel2.Controls.Add(this.rb2018);
            this.panel2.Controls.Add(this.rb2017);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnLosers);
            this.panel2.Controls.Add(this.btnOctober);
            this.panel2.Controls.Add(this.btnDecember);
            this.panel2.Controls.Add(this.btnNovember);
            this.panel2.Controls.Add(this.btnJuly);
            this.panel2.Controls.Add(this.btnJune);
            this.panel2.Controls.Add(this.btnSeptember);
            this.panel2.Controls.Add(this.btnAugust);
            this.panel2.Controls.Add(this.btnMarch);
            this.panel2.Controls.Add(this.btnFebruary);
            this.panel2.Controls.Add(this.btnMay);
            this.panel2.Controls.Add(this.btnJanuary);
            this.panel2.Controls.Add(this.btnApril);
            this.panel2.Controls.Add(this.btnseven);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.lblViews);
            this.panel2.Controls.Add(this.btnLate);
            this.panel2.Controls.Add(this.bthThisMonth);
            this.panel2.Controls.Add(this.btn90);
            this.panel2.Location = new System.Drawing.Point(1475, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 392);
            this.panel2.TabIndex = 3;
            // 
            // btnVCT
            // 
            this.btnVCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVCT.Location = new System.Drawing.Point(96, 211);
            this.btnVCT.Name = "btnVCT";
            this.btnVCT.Size = new System.Drawing.Size(75, 23);
            this.btnVCT.TabIndex = 21;
            this.btnVCT.Text = "VCT";
            this.btnVCT.UseVisualStyleBackColor = true;
            this.btnVCT.Click += new System.EventHandler(this.btnVCT_Click);
            // 
            // rb2018
            // 
            this.rb2018.AutoSize = true;
            this.rb2018.Location = new System.Drawing.Point(96, 297);
            this.rb2018.Name = "rb2018";
            this.rb2018.Size = new System.Drawing.Size(49, 17);
            this.rb2018.TabIndex = 20;
            this.rb2018.TabStop = true;
            this.rb2018.Text = "2018";
            this.rb2018.UseVisualStyleBackColor = true;
            this.rb2018.CheckedChanged += new System.EventHandler(this.rb2018_CheckedChanged);
            // 
            // rb2017
            // 
            this.rb2017.AutoSize = true;
            this.rb2017.Location = new System.Drawing.Point(97, 274);
            this.rb2017.Name = "rb2017";
            this.rb2017.Size = new System.Drawing.Size(49, 17);
            this.rb2017.TabIndex = 19;
            this.rb2017.TabStop = true;
            this.rb2017.Text = "2017";
            this.rb2017.UseVisualStyleBackColor = true;
            this.rb2017.CheckedChanged += new System.EventHandler(this.rb2017_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(96, 240);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLosers
            // 
            this.btnLosers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLosers.Location = new System.Drawing.Point(96, 182);
            this.btnLosers.Name = "btnLosers";
            this.btnLosers.Size = new System.Drawing.Size(75, 23);
            this.btnLosers.TabIndex = 5;
            this.btnLosers.Text = "Losers";
            this.btnLosers.UseVisualStyleBackColor = true;
            this.btnLosers.Click += new System.EventHandler(this.btnLosers_Click);
            // 
            // btnOctober
            // 
            this.btnOctober.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctober.Location = new System.Drawing.Point(8, 300);
            this.btnOctober.Name = "btnOctober";
            this.btnOctober.Size = new System.Drawing.Size(75, 23);
            this.btnOctober.TabIndex = 17;
            this.btnOctober.Text = "Oct";
            this.btnOctober.UseVisualStyleBackColor = true;
            this.btnOctober.Click += new System.EventHandler(this.btnOctober_Click);
            // 
            // btnDecember
            // 
            this.btnDecember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecember.Location = new System.Drawing.Point(7, 358);
            this.btnDecember.Name = "btnDecember";
            this.btnDecember.Size = new System.Drawing.Size(75, 23);
            this.btnDecember.TabIndex = 16;
            this.btnDecember.Text = "Dec";
            this.btnDecember.UseVisualStyleBackColor = true;
            this.btnDecember.Click += new System.EventHandler(this.btnDecember_Click);
            // 
            // btnNovember
            // 
            this.btnNovember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovember.Location = new System.Drawing.Point(8, 329);
            this.btnNovember.Name = "btnNovember";
            this.btnNovember.Size = new System.Drawing.Size(75, 23);
            this.btnNovember.TabIndex = 15;
            this.btnNovember.Text = "Nov";
            this.btnNovember.UseVisualStyleBackColor = true;
            this.btnNovember.Click += new System.EventHandler(this.btnNovember_Click);
            // 
            // btnJuly
            // 
            this.btnJuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuly.Location = new System.Drawing.Point(9, 211);
            this.btnJuly.Name = "btnJuly";
            this.btnJuly.Size = new System.Drawing.Size(75, 23);
            this.btnJuly.TabIndex = 14;
            this.btnJuly.Text = "Jul";
            this.btnJuly.UseVisualStyleBackColor = true;
            this.btnJuly.Click += new System.EventHandler(this.btnJuly_Click);
            // 
            // btnJune
            // 
            this.btnJune.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJune.Location = new System.Drawing.Point(8, 182);
            this.btnJune.Name = "btnJune";
            this.btnJune.Size = new System.Drawing.Size(75, 23);
            this.btnJune.TabIndex = 13;
            this.btnJune.Text = "Jun";
            this.btnJune.UseVisualStyleBackColor = true;
            this.btnJune.Click += new System.EventHandler(this.btnJune_Click);
            // 
            // btnSeptember
            // 
            this.btnSeptember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeptember.Location = new System.Drawing.Point(8, 269);
            this.btnSeptember.Name = "btnSeptember";
            this.btnSeptember.Size = new System.Drawing.Size(75, 23);
            this.btnSeptember.TabIndex = 12;
            this.btnSeptember.Text = "Sept";
            this.btnSeptember.UseVisualStyleBackColor = true;
            this.btnSeptember.Click += new System.EventHandler(this.btnSeptember_Click);
            // 
            // btnAugust
            // 
            this.btnAugust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAugust.Location = new System.Drawing.Point(9, 240);
            this.btnAugust.Name = "btnAugust";
            this.btnAugust.Size = new System.Drawing.Size(75, 23);
            this.btnAugust.TabIndex = 11;
            this.btnAugust.Text = "Aug";
            this.btnAugust.UseVisualStyleBackColor = true;
            this.btnAugust.Click += new System.EventHandler(this.btnAugust_Click);
            // 
            // btnMarch
            // 
            this.btnMarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarch.Location = new System.Drawing.Point(9, 95);
            this.btnMarch.Name = "btnMarch";
            this.btnMarch.Size = new System.Drawing.Size(75, 23);
            this.btnMarch.TabIndex = 10;
            this.btnMarch.Text = "Mar";
            this.btnMarch.UseVisualStyleBackColor = true;
            this.btnMarch.Click += new System.EventHandler(this.btnMarch_Click);
            // 
            // btnFebruary
            // 
            this.btnFebruary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFebruary.Location = new System.Drawing.Point(8, 66);
            this.btnFebruary.Name = "btnFebruary";
            this.btnFebruary.Size = new System.Drawing.Size(75, 23);
            this.btnFebruary.TabIndex = 9;
            this.btnFebruary.Text = "Feb";
            this.btnFebruary.UseVisualStyleBackColor = true;
            this.btnFebruary.Click += new System.EventHandler(this.btnFebruary_Click);
            // 
            // btnMay
            // 
            this.btnMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMay.Location = new System.Drawing.Point(8, 153);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(75, 23);
            this.btnMay.TabIndex = 8;
            this.btnMay.Text = "May";
            this.btnMay.UseVisualStyleBackColor = true;
            this.btnMay.Click += new System.EventHandler(this.btnMay_Click);
            // 
            // btnJanuary
            // 
            this.btnJanuary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJanuary.Location = new System.Drawing.Point(8, 37);
            this.btnJanuary.Name = "btnJanuary";
            this.btnJanuary.Size = new System.Drawing.Size(75, 23);
            this.btnJanuary.TabIndex = 7;
            this.btnJanuary.Text = "Jan";
            this.btnJanuary.UseVisualStyleBackColor = true;
            this.btnJanuary.Click += new System.EventHandler(this.btnJanuary_Click);
            // 
            // btnApril
            // 
            this.btnApril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApril.Location = new System.Drawing.Point(9, 124);
            this.btnApril.Name = "btnApril";
            this.btnApril.Size = new System.Drawing.Size(75, 23);
            this.btnApril.TabIndex = 6;
            this.btnApril.Text = "Apr";
            this.btnApril.UseVisualStyleBackColor = true;
            this.btnApril.Click += new System.EventHandler(this.btnApril_Click);
            // 
            // btnseven
            // 
            this.btnseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.Location = new System.Drawing.Point(97, 94);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(75, 23);
            this.btnseven.TabIndex = 5;
            this.btnseven.Text = "Next 7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(96, 65);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next Month";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViews.Location = new System.Drawing.Point(5, 7);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(49, 16);
            this.lblViews.TabIndex = 3;
            this.lblViews.Text = "Views";
            // 
            // btnLate
            // 
            this.btnLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLate.Location = new System.Drawing.Point(96, 152);
            this.btnLate.Name = "btnLate";
            this.btnLate.Size = new System.Drawing.Size(75, 23);
            this.btnLate.TabIndex = 2;
            this.btnLate.Text = "Late!";
            this.btnLate.UseVisualStyleBackColor = true;
            this.btnLate.Click += new System.EventHandler(this.btnLate_Click);
            // 
            // bthThisMonth
            // 
            this.bthThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthThisMonth.Location = new System.Drawing.Point(96, 36);
            this.bthThisMonth.Name = "bthThisMonth";
            this.bthThisMonth.Size = new System.Drawing.Size(75, 23);
            this.bthThisMonth.TabIndex = 1;
            this.bthThisMonth.Text = "This Month";
            this.bthThisMonth.UseVisualStyleBackColor = true;
            this.bthThisMonth.Click += new System.EventHandler(this.bthThisMonth_Click);
            // 
            // btn90
            // 
            this.btn90.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn90.Location = new System.Drawing.Point(97, 123);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(75, 23);
            this.btn90.TabIndex = 0;
            this.btn90.Text = "Next 90";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.lblPendingValue);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lblHoldValue);
            this.panel3.Controls.Add(this.lblHoldValueTitle);
            this.panel3.Controls.Add(this.lblValue);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblTrackerhrs);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblDesignhrs);
            this.panel3.Controls.Add(this.lblBuild);
            this.panel3.Controls.Add(this.lblBuildhrs);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblWeldhrs);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblMachinehrs);
            this.panel3.Location = new System.Drawing.Point(1475, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 272);
            this.panel3.TabIndex = 4;
            // 
            // lblPendingValue
            // 
            this.lblPendingValue.AutoSize = true;
            this.lblPendingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingValue.ForeColor = System.Drawing.Color.White;
            this.lblPendingValue.Location = new System.Drawing.Point(235, 107);
            this.lblPendingValue.Name = "lblPendingValue";
            this.lblPendingValue.Size = new System.Drawing.Size(70, 25);
            this.lblPendingValue.TabIndex = 17;
            this.lblPendingValue.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "On Hold";
            // 
            // lblHoldValue
            // 
            this.lblHoldValue.AutoSize = true;
            this.lblHoldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoldValue.ForeColor = System.Drawing.Color.White;
            this.lblHoldValue.Location = new System.Drawing.Point(237, 161);
            this.lblHoldValue.Name = "lblHoldValue";
            this.lblHoldValue.Size = new System.Drawing.Size(70, 25);
            this.lblHoldValue.TabIndex = 15;
            this.lblHoldValue.Text = "label1";
            // 
            // lblHoldValueTitle
            // 
            this.lblHoldValueTitle.AutoSize = true;
            this.lblHoldValueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoldValueTitle.Location = new System.Drawing.Point(196, 76);
            this.lblHoldValueTitle.Name = "lblHoldValueTitle";
            this.lblHoldValueTitle.Size = new System.Drawing.Size(152, 29);
            this.lblHoldValueTitle.TabIndex = 14;
            this.lblHoldValueTitle.Text = "Pending Rel.";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(237, 50);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(70, 25);
            this.lblValue.TabIndex = 13;
            this.lblValue.Text = "label1";
            this.lblValue.Visible = false;
            this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hours";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(7, 191);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 30);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label6";
            this.lblTotal.UseCompatibleTextRendering = true;
            this.lblTotal.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "View Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trackers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTrackerhrs
            // 
            this.lblTrackerhrs.AutoSize = true;
            this.lblTrackerhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackerhrs.ForeColor = System.Drawing.Color.White;
            this.lblTrackerhrs.Location = new System.Drawing.Point(116, 130);
            this.lblTrackerhrs.Name = "lblTrackerhrs";
            this.lblTrackerhrs.Size = new System.Drawing.Size(70, 25);
            this.lblTrackerhrs.TabIndex = 8;
            this.lblTrackerhrs.Text = "label1";
            this.lblTrackerhrs.Visible = false;
            this.lblTrackerhrs.Click += new System.EventHandler(this.lblTrackerhrs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Design";
            // 
            // lblDesignhrs
            // 
            this.lblDesignhrs.AutoSize = true;
            this.lblDesignhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignhrs.ForeColor = System.Drawing.Color.White;
            this.lblDesignhrs.Location = new System.Drawing.Point(116, 105);
            this.lblDesignhrs.Name = "lblDesignhrs";
            this.lblDesignhrs.Size = new System.Drawing.Size(70, 25);
            this.lblDesignhrs.TabIndex = 6;
            this.lblDesignhrs.Text = "label1";
            this.lblDesignhrs.Visible = false;
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuild.ForeColor = System.Drawing.Color.White;
            this.lblBuild.Location = new System.Drawing.Point(9, 80);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(60, 25);
            this.lblBuild.TabIndex = 5;
            this.lblBuild.Text = "Build";
            // 
            // lblBuildhrs
            // 
            this.lblBuildhrs.AutoSize = true;
            this.lblBuildhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildhrs.ForeColor = System.Drawing.Color.White;
            this.lblBuildhrs.Location = new System.Drawing.Point(116, 80);
            this.lblBuildhrs.Name = "lblBuildhrs";
            this.lblBuildhrs.Size = new System.Drawing.Size(70, 25);
            this.lblBuildhrs.TabIndex = 4;
            this.lblBuildhrs.Text = "label1";
            this.lblBuildhrs.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weld";
            // 
            // lblWeldhrs
            // 
            this.lblWeldhrs.AutoSize = true;
            this.lblWeldhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeldhrs.ForeColor = System.Drawing.Color.White;
            this.lblWeldhrs.Location = new System.Drawing.Point(116, 55);
            this.lblWeldhrs.Name = "lblWeldhrs";
            this.lblWeldhrs.Size = new System.Drawing.Size(70, 25);
            this.lblWeldhrs.TabIndex = 2;
            this.lblWeldhrs.Text = "label1";
            this.lblWeldhrs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Machine";
            // 
            // lblMachinehrs
            // 
            this.lblMachinehrs.AutoSize = true;
            this.lblMachinehrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinehrs.ForeColor = System.Drawing.Color.White;
            this.lblMachinehrs.Location = new System.Drawing.Point(116, 30);
            this.lblMachinehrs.Name = "lblMachinehrs";
            this.lblMachinehrs.Size = new System.Drawing.Size(70, 25);
            this.lblMachinehrs.TabIndex = 0;
            this.lblMachinehrs.Text = "label1";
            this.lblMachinehrs.Visible = false;
            // 
            // lblSelectionHeader
            // 
            this.lblSelectionHeader.AutoSize = true;
            this.lblSelectionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionHeader.Location = new System.Drawing.Point(1696, 96);
            this.lblSelectionHeader.Name = "lblSelectionHeader";
            this.lblSelectionHeader.Size = new System.Drawing.Size(110, 25);
            this.lblSelectionHeader.TabIndex = 7;
            this.lblSelectionHeader.Text = "Selection";
            this.lblSelectionHeader.Click += new System.EventHandler(this.lblSelectionHeader_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(1724, 208);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(54, 25);
            this.lblSelection.TabIndex = 5;
            this.lblSelection.Text = "$.00";
            this.lblSelection.Click += new System.EventHandler(this.lblSelection_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(1721, 131);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(60, 24);
            this.lblcount.TabIndex = 10;
            this.lblcount.Text = "label8";
            this.lblcount.Click += new System.EventHandler(this.lblcount_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1676, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // activeJobsTableAdapter
            // 
            this.activeJobsTableAdapter.ClearBeforeFill = true;
            // 
            // lblHoldTitle
            // 
            this.lblHoldTitle.AutoSize = true;
            this.lblHoldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoldTitle.Location = new System.Drawing.Point(1674, 238);
            this.lblHoldTitle.Name = "lblHoldTitle";
            this.lblHoldTitle.Size = new System.Drawing.Size(155, 24);
            this.lblHoldTitle.TabIndex = 11;
            this.lblHoldTitle.Text = "Pending Release";
            // 
            // lblSelectedPending
            // 
            this.lblSelectedPending.AutoSize = true;
            this.lblSelectedPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPending.Location = new System.Drawing.Point(1724, 267);
            this.lblSelectedPending.Name = "lblSelectedPending";
            this.lblSelectedPending.Size = new System.Drawing.Size(54, 25);
            this.lblSelectedPending.TabIndex = 12;
            this.lblSelectedPending.Text = "$.00";
            // 
            // lblSelectedHold
            // 
            this.lblSelectedHold.AutoSize = true;
            this.lblSelectedHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedHold.Location = new System.Drawing.Point(1724, 326);
            this.lblSelectedHold.Name = "lblSelectedHold";
            this.lblSelectedHold.Size = new System.Drawing.Size(54, 25);
            this.lblSelectedHold.TabIndex = 14;
            this.lblSelectedHold.Text = "$.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1711, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "On Hold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1721, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Active";
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 761);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSelectedHold);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSelectedPending);
            this.Controls.Add(this.lblHoldTitle);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblSelectionHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvActiveJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataView";
            this.Text = "Active Jobs";
            this.Load += new System.EventHandler(this.DataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_activejobs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActiveJobs;
        private ds_activejobs ds_activejobs;
        private System.Windows.Forms.BindingSource activeJobsBindingSource;
        private ds_activejobsTableAdapters.ActiveJobsTableAdapter activeJobsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button bthThisMonth;
        private System.Windows.Forms.Button btnLate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMachinehrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrackerhrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDesignhrs;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Label lblBuildhrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeldhrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btnJuly;
        private System.Windows.Forms.Button btnJune;
        private System.Windows.Forms.Button btnSeptember;
        private System.Windows.Forms.Button btnAugust;
        private System.Windows.Forms.Button btnMarch;
        private System.Windows.Forms.Button btnFebruary;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnJanuary;
        private System.Windows.Forms.Button btnApril;
        private System.Windows.Forms.Button btnOctober;
        private System.Windows.Forms.Button btnDecember;
        private System.Windows.Forms.Button btnNovember;
        private System.Windows.Forms.Button btnLosers;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblSelectionHeader;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.RadioButton rb2018;
        private System.Windows.Forms.RadioButton rb2017;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVCT;
        private System.Windows.Forms.Button btnJobView;
        private System.Windows.Forms.Label lblHoldTitle;
        private System.Windows.Forms.Label lblSelectedPending;
        private System.Windows.Forms.Label lblHoldValue;
        private System.Windows.Forms.Label lblHoldValueTitle;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSelectedHold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn QA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hold;
        private System.Windows.Forms.Label label8;
    }
}