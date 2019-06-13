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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataView));
            this.dgvActiveJobs = new System.Windows.Forms.DataGridView();
            this.baseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Build = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Design = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tracker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_activejobs = new WipViewer.ds_activejobs();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnJobView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.rb2019 = new System.Windows.Forms.RadioButton();
            this.btnVCT = new System.Windows.Forms.Button();
            this.rb2018 = new System.Windows.Forms.RadioButton();
            this.rb2017 = new System.Windows.Forms.RadioButton();
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
            this.lblViews = new System.Windows.Forms.Label();
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
            this.lblSelection = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProjectedSelect = new System.Windows.Forms.Label();
            this.lblActualSelect = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSelectionTracker = new System.Windows.Forms.Label();
            this.lblSelectionDesign = new System.Windows.Forms.Label();
            this.lblSelectionWeld = new System.Windows.Forms.Label();
            this.lblSelectionBuild = new System.Windows.Forms.Label();
            this.lblSelectionMachine = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblTrackerHours = new System.Windows.Forms.Label();
            this.lblDesignHours = new System.Windows.Forms.Label();
            this.lblWeldHours = new System.Windows.Forms.Label();
            this.lblBuildHours = new System.Windows.Forms.Label();
            this.lblMachineHours = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMarginSelect = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRemainingSelect = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.activeJobsTableAdapter = new WipViewer.ds_activejobsTableAdapters.ActiveJobsTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_activejobs)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvActiveJobs
            // 
            this.dgvActiveJobs.AllowUserToAddRows = false;
            this.dgvActiveJobs.AllowUserToDeleteRows = false;
            this.dgvActiveJobs.AllowUserToOrderColumns = true;
            this.dgvActiveJobs.AutoGenerateColumns = false;
            this.dgvActiveJobs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseIDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.compDataGridViewTextBoxColumn,
            this.POValue,
            this.Actual,
            this.Projected,
            this.RemainingRev,
            this.ShipDate,
            this.ContractDate,
            this.margin,
            this.Machine,
            this.Build,
            this.Weld,
            this.Design,
            this.Tracker,
            this.BuildLeader,
            this.ProgramManager,
            this.Processor,
            this.QA});
            this.dgvActiveJobs.DataSource = this.activeJobsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActiveJobs.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActiveJobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvActiveJobs.Location = new System.Drawing.Point(0, 0);
            this.dgvActiveJobs.Name = "dgvActiveJobs";
            this.dgvActiveJobs.ReadOnly = true;
            this.dgvActiveJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveJobs.Size = new System.Drawing.Size(1469, 671);
            this.dgvActiveJobs.TabIndex = 0;
            this.dgvActiveJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveJobs_CellContentClick_1);
            this.dgvActiveJobs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveJobs_CellDoubleClick);
            this.dgvActiveJobs.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvActiveJobs_ColumnHeaderMouseClick);
            this.dgvActiveJobs.SelectionChanged += new System.EventHandler(this.dgvActiveJobs_SelectionChanged);
            this.dgvActiveJobs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvActiveJobs_KeyPress);
            // 
            // baseIDDataGridViewTextBoxColumn
            // 
            this.baseIDDataGridViewTextBoxColumn.DataPropertyName = "BaseID";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.baseIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            // POValue
            // 
            this.POValue.DataPropertyName = "POValue";
            this.POValue.HeaderText = "PO Value";
            this.POValue.Name = "POValue";
            this.POValue.ReadOnly = true;
            // 
            // Actual
            // 
            this.Actual.DataPropertyName = "Actual";
            this.Actual.HeaderText = "Actual";
            this.Actual.Name = "Actual";
            this.Actual.ReadOnly = true;
            // 
            // Projected
            // 
            this.Projected.DataPropertyName = "Projected";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Projected.DefaultCellStyle = dataGridViewCellStyle3;
            this.Projected.HeaderText = "Projected";
            this.Projected.Name = "Projected";
            this.Projected.ReadOnly = true;
            // 
            // RemainingRev
            // 
            this.RemainingRev.DataPropertyName = "RemainingRev";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.RemainingRev.DefaultCellStyle = dataGridViewCellStyle4;
            this.RemainingRev.HeaderText = "RemainingRev";
            this.RemainingRev.Name = "RemainingRev";
            this.RemainingRev.ReadOnly = true;
            // 
            // ShipDate
            // 
            this.ShipDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ShipDate.DataPropertyName = "ShipDate";
            this.ShipDate.HeaderText = "Ship Date";
            this.ShipDate.Name = "ShipDate";
            this.ShipDate.ReadOnly = true;
            this.ShipDate.Width = 79;
            // 
            // ContractDate
            // 
            this.ContractDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ContractDate.DataPropertyName = "ContractDate";
            this.ContractDate.HeaderText = "ContractDate";
            this.ContractDate.Name = "ContractDate";
            this.ContractDate.ReadOnly = true;
            this.ContractDate.Width = 95;
            // 
            // margin
            // 
            this.margin.DataPropertyName = "margin";
            this.margin.HeaderText = "Margin";
            this.margin.Name = "margin";
            this.margin.ReadOnly = true;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Machine.DataPropertyName = "Machine";
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            this.Machine.Width = 73;
            // 
            // Build
            // 
            this.Build.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Build.DataPropertyName = "Build";
            this.Build.HeaderText = "Build";
            this.Build.Name = "Build";
            this.Build.ReadOnly = true;
            this.Build.Width = 55;
            // 
            // Weld
            // 
            this.Weld.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Weld.DataPropertyName = "Weld";
            this.Weld.HeaderText = "Weld";
            this.Weld.Name = "Weld";
            this.Weld.ReadOnly = true;
            this.Weld.Width = 57;
            // 
            // Design
            // 
            this.Design.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Design.DataPropertyName = "Design";
            this.Design.HeaderText = "Design";
            this.Design.Name = "Design";
            this.Design.ReadOnly = true;
            this.Design.Width = 65;
            // 
            // Tracker
            // 
            this.Tracker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tracker.DataPropertyName = "Tracker";
            this.Tracker.HeaderText = "Tracker";
            this.Tracker.Name = "Tracker";
            this.Tracker.ReadOnly = true;
            this.Tracker.Width = 69;
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
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.rb2019);
            this.panel2.Controls.Add(this.btnVCT);
            this.panel2.Controls.Add(this.rb2018);
            this.panel2.Controls.Add(this.rb2017);
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
            this.panel2.Controls.Add(this.lblViews);
            this.panel2.Location = new System.Drawing.Point(1475, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 392);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(89, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // rb2019
            // 
            this.rb2019.AutoSize = true;
            this.rb2019.Location = new System.Drawing.Point(106, 255);
            this.rb2019.Name = "rb2019";
            this.rb2019.Size = new System.Drawing.Size(49, 17);
            this.rb2019.TabIndex = 22;
            this.rb2019.TabStop = true;
            this.rb2019.Text = "2019";
            this.rb2019.UseVisualStyleBackColor = true;
            // 
            // btnVCT
            // 
            this.btnVCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVCT.Location = new System.Drawing.Point(89, 37);
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
            this.rb2018.Location = new System.Drawing.Point(106, 234);
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
            this.rb2017.Location = new System.Drawing.Point(107, 211);
            this.rb2017.Name = "rb2017";
            this.rb2017.Size = new System.Drawing.Size(49, 17);
            this.rb2017.TabIndex = 19;
            this.rb2017.TabStop = true;
            this.rb2017.Text = "2017";
            this.rb2017.UseVisualStyleBackColor = true;
            this.rb2017.CheckedChanged += new System.EventHandler(this.rb2017_CheckedChanged);
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
            this.panel3.Location = new System.Drawing.Point(2079, 487);
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
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(122, 36);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(40, 20);
            this.lblSelection.TabIndex = 5;
            this.lblSelection.Text = "$.00";
            this.lblSelection.Click += new System.EventHandler(this.lblSelection_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(13, 252);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(45, 16);
            this.lblcount.TabIndex = 10;
            this.lblcount.Text = "label8";
            this.lblcount.Click += new System.EventHandler(this.lblcount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "PO Value";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblProjectedSelect);
            this.panel4.Controls.Add(this.lblActualSelect);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.lblSelectionTracker);
            this.panel4.Controls.Add(this.lblSelectionDesign);
            this.panel4.Controls.Add(this.lblSelectionWeld);
            this.panel4.Controls.Add(this.lblSelectionBuild);
            this.panel4.Controls.Add(this.lblSelectionMachine);
            this.panel4.Controls.Add(this.lblTotalHours);
            this.panel4.Controls.Add(this.lblTrackerHours);
            this.panel4.Controls.Add(this.lblDesignHours);
            this.panel4.Controls.Add(this.lblWeldHours);
            this.panel4.Controls.Add(this.lblBuildHours);
            this.panel4.Controls.Add(this.lblMachineHours);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lblMarginSelect);
            this.panel4.Controls.Add(this.lblcount);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblRemainingSelect);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblSelection);
            this.panel4.Location = new System.Drawing.Point(1649, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 392);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblProjectedSelect
            // 
            this.lblProjectedSelect.AutoSize = true;
            this.lblProjectedSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedSelect.Location = new System.Drawing.Point(122, 68);
            this.lblProjectedSelect.Name = "lblProjectedSelect";
            this.lblProjectedSelect.Size = new System.Drawing.Size(40, 20);
            this.lblProjectedSelect.TabIndex = 43;
            this.lblProjectedSelect.Text = "$.00";
            // 
            // lblActualSelect
            // 
            this.lblActualSelect.AutoSize = true;
            this.lblActualSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualSelect.Location = new System.Drawing.Point(122, 52);
            this.lblActualSelect.Name = "lblActualSelect";
            this.lblActualSelect.Size = new System.Drawing.Size(40, 20);
            this.lblActualSelect.TabIndex = 42;
            this.lblActualSelect.Text = "$.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Projected";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "Actual";
            // 
            // lblSelectionTracker
            // 
            this.lblSelectionTracker.AutoSize = true;
            this.lblSelectionTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionTracker.Location = new System.Drawing.Point(9, 214);
            this.lblSelectionTracker.Name = "lblSelectionTracker";
            this.lblSelectionTracker.Size = new System.Drawing.Size(66, 20);
            this.lblSelectionTracker.TabIndex = 39;
            this.lblSelectionTracker.Text = "Tracker:";
            // 
            // lblSelectionDesign
            // 
            this.lblSelectionDesign.AutoSize = true;
            this.lblSelectionDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionDesign.Location = new System.Drawing.Point(12, 194);
            this.lblSelectionDesign.Name = "lblSelectionDesign";
            this.lblSelectionDesign.Size = new System.Drawing.Size(67, 20);
            this.lblSelectionDesign.TabIndex = 38;
            this.lblSelectionDesign.Text = "Design: ";
            // 
            // lblSelectionWeld
            // 
            this.lblSelectionWeld.AutoSize = true;
            this.lblSelectionWeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionWeld.Location = new System.Drawing.Point(20, 174);
            this.lblSelectionWeld.Name = "lblSelectionWeld";
            this.lblSelectionWeld.Size = new System.Drawing.Size(53, 20);
            this.lblSelectionWeld.TabIndex = 37;
            this.lblSelectionWeld.Text = "Weld: ";
            // 
            // lblSelectionBuild
            // 
            this.lblSelectionBuild.AutoSize = true;
            this.lblSelectionBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionBuild.Location = new System.Drawing.Point(22, 154);
            this.lblSelectionBuild.Name = "lblSelectionBuild";
            this.lblSelectionBuild.Size = new System.Drawing.Size(52, 20);
            this.lblSelectionBuild.TabIndex = 36;
            this.lblSelectionBuild.Text = "Build: ";
            // 
            // lblSelectionMachine
            // 
            this.lblSelectionMachine.AutoSize = true;
            this.lblSelectionMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionMachine.Location = new System.Drawing.Point(4, 134);
            this.lblSelectionMachine.Name = "lblSelectionMachine";
            this.lblSelectionMachine.Size = new System.Drawing.Size(77, 20);
            this.lblSelectionMachine.TabIndex = 35;
            this.lblSelectionMachine.Text = "Machine: ";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotalHours.Location = new System.Drawing.Point(16, 363);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(49, 18);
            this.lblTotalHours.TabIndex = 34;
            this.lblTotalHours.Text = "Total: ";
            // 
            // lblTrackerHours
            // 
            this.lblTrackerHours.AutoSize = true;
            this.lblTrackerHours.Location = new System.Drawing.Point(13, 345);
            this.lblTrackerHours.Name = "lblTrackerHours";
            this.lblTrackerHours.Size = new System.Drawing.Size(47, 13);
            this.lblTrackerHours.TabIndex = 33;
            this.lblTrackerHours.Text = "Tracker:";
            // 
            // lblDesignHours
            // 
            this.lblDesignHours.AutoSize = true;
            this.lblDesignHours.Location = new System.Drawing.Point(16, 332);
            this.lblDesignHours.Name = "lblDesignHours";
            this.lblDesignHours.Size = new System.Drawing.Size(46, 13);
            this.lblDesignHours.TabIndex = 32;
            this.lblDesignHours.Text = "Design: ";
            // 
            // lblWeldHours
            // 
            this.lblWeldHours.AutoSize = true;
            this.lblWeldHours.Location = new System.Drawing.Point(24, 319);
            this.lblWeldHours.Name = "lblWeldHours";
            this.lblWeldHours.Size = new System.Drawing.Size(38, 13);
            this.lblWeldHours.TabIndex = 31;
            this.lblWeldHours.Text = "Weld: ";
            // 
            // lblBuildHours
            // 
            this.lblBuildHours.AutoSize = true;
            this.lblBuildHours.Location = new System.Drawing.Point(26, 306);
            this.lblBuildHours.Name = "lblBuildHours";
            this.lblBuildHours.Size = new System.Drawing.Size(36, 13);
            this.lblBuildHours.TabIndex = 30;
            this.lblBuildHours.Text = "Build: ";
            // 
            // lblMachineHours
            // 
            this.lblMachineHours.AutoSize = true;
            this.lblMachineHours.Location = new System.Drawing.Point(8, 293);
            this.lblMachineHours.Name = "lblMachineHours";
            this.lblMachineHours.Size = new System.Drawing.Size(54, 13);
            this.lblMachineHours.TabIndex = 29;
            this.lblMachineHours.Text = "Machine: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "View Totals";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Margin";
            // 
            // lblMarginSelect
            // 
            this.lblMarginSelect.AutoSize = true;
            this.lblMarginSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarginSelect.Location = new System.Drawing.Point(122, 100);
            this.lblMarginSelect.Name = "lblMarginSelect";
            this.lblMarginSelect.Size = new System.Drawing.Size(40, 20);
            this.lblMarginSelect.TabIndex = 26;
            this.lblMarginSelect.Text = "$.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Remaining Rev";
            // 
            // lblRemainingSelect
            // 
            this.lblRemainingSelect.AutoSize = true;
            this.lblRemainingSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingSelect.Location = new System.Drawing.Point(122, 84);
            this.lblRemainingSelect.Name = "lblRemainingSelect";
            this.lblRemainingSelect.Size = new System.Drawing.Size(40, 20);
            this.lblRemainingSelect.TabIndex = 24;
            this.lblRemainingSelect.Text = "$.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Selection Totals";
            // 
            // activeJobsTableAdapter
            // 
            this.activeJobsTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(1475, 487);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 184);
            this.panel5.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(100, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "$201,659,35";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(100, 77);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "$2,591.07";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(100, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 34;
            this.label25.Text = "$20,542.83";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(100, 92);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 33;
            this.label26.Text = "$1,865.00";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(100, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 32;
            this.label27.Text = "$326,835.64";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(100, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "$435,783.12";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(32, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "Vis Material";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "VCT Material";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "VCT Labor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "VCT Outsource";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Vis Labor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Vis Outsource";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "MTD Info";
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 671);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActiveJobs;
        private ds_activejobs ds_activejobs;
        private System.Windows.Forms.BindingSource activeJobsBindingSource;
        private ds_activejobsTableAdapters.ActiveJobsTableAdapter activeJobsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.RadioButton rb2018;
        private System.Windows.Forms.RadioButton rb2017;
        private System.Windows.Forms.Button btnVCT;
        private System.Windows.Forms.Button btnJobView;
        private System.Windows.Forms.Label lblHoldValue;
        private System.Windows.Forms.Label lblHoldValueTitle;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb2019;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMarginSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRemainingSelect;
        private System.Windows.Forms.Label lblTrackerHours;
        private System.Windows.Forms.Label lblDesignHours;
        private System.Windows.Forms.Label lblWeldHours;
        private System.Windows.Forms.Label lblBuildHours;
        private System.Windows.Forms.Label lblMachineHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSelectionTracker;
        private System.Windows.Forms.Label lblSelectionDesign;
        private System.Windows.Forms.Label lblSelectionWeld;
        private System.Windows.Forms.Label lblSelectionBuild;
        private System.Windows.Forms.Label lblSelectionMachine;
        private System.Windows.Forms.Label lblProjectedSelect;
        private System.Windows.Forms.Label lblActualSelect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projected;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Build;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weld;
        private System.Windows.Forms.DataGridViewTextBoxColumn Design;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tracker;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn QA;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
     //   private MessageExport.ActiveJobs_JobNumbersTableAdapters.ActiveJobsTableAdapter activeJobsTableAdapter1;
    }
}