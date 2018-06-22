namespace WipViewer
{
    partial class jobview2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jobview2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComments = new WipViewer.dsComments();
            this.jobbatchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobBatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBatches = new WipViewer.JobBatches();
            this.job_batchesTableAdapter = new WipViewer.JobBatchesTableAdapters.Job_batchesTableAdapter();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblTooltype = new System.Windows.Forms.Label();
            this.lblShipdate = new System.Windows.Forms.Label();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnDates = new System.Windows.Forms.Button();
            this.dtpFab = new System.Windows.Forms.DateTimePicker();
            this.dtpMachineComp = new System.Windows.Forms.DateTimePicker();
            this.dtpMachine = new System.Windows.Forms.DateTimePicker();
            this.dtpHt = new System.Windows.Forms.DateTimePicker();
            this.dtpRdyChk = new System.Windows.Forms.DateTimePicker();
            this.dtpSrc = new System.Windows.Forms.DateTimePicker();
            this.dtpDesRel = new System.Windows.Forms.DateTimePicker();
            this.dtpAssy = new System.Windows.Forms.DateTimePicker();
            this.dtpMaterial = new System.Windows.Forms.DateTimePicker();
            this.lblRecvMaterial = new System.Windows.Forms.Label();
            this.lblStartFab = new System.Windows.Forms.Label();
            this.lblStartMachining = new System.Windows.Forms.Label();
            this.lblHeatTreat = new System.Windows.Forms.Label();
            this.lblDesignRelease = new System.Windows.Forms.Label();
            this.lblRdyCheck = new System.Windows.Forms.Label();
            this.lblRdySource = new System.Windows.Forms.Label();
            this.lblStartAssembly = new System.Windows.Forms.Label();
            this.lblMachineComplete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePicture = new System.Windows.Forms.Button();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.commentsTableAdapter = new WipViewer.dsCommentsTableAdapters.commentsTableAdapter();
            this.btnGuys = new System.Windows.Forms.Button();
            this.lblPm = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblKickoff = new System.Windows.Forms.Label();
            this.lblBuldLeader = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblPoDate = new System.Windows.Forms.Label();
            this.chkDes = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnActionItems = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblActionitems = new System.Windows.Forms.Label();
            this.dgvActionItems = new System.Windows.Forms.DataGridView();
            this.asigneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.critical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ActionItems = new WipViewer.ds_ActionItems();
            this.btnRfq = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnFolders = new System.Windows.Forms.Button();
            this.ds_Comments1 = new WipViewer.ds_Comments();
            this.lblPMFolder = new System.Windows.Forms.Label();
            this.lblProcessorFolder = new System.Windows.Forms.Label();
            this.lblWeldFolder = new System.Windows.Forms.Label();
            this.lblBuildFolder = new System.Windows.Forms.Label();
            this.lblMachineFolder = new System.Windows.Forms.Label();
            this.actionItemsTableAdapter = new WipViewer.ds_ActionItemsTableAdapters.ActionItemsTableAdapter();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.pbJob = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRA = new System.Windows.Forms.Button();
            this.btnAQP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbatchesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ActionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.commenter,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.commentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(670, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(904, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 180;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 800;
            // 
            // commenter
            // 
            this.commenter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commenter.DataPropertyName = "commenter";
            this.commenter.HeaderText = "commenter";
            this.commenter.Name = "commenter";
            this.commenter.ReadOnly = true;
            this.commenter.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "comments";
            this.commentsBindingSource.DataSource = this.dsComments;
            // 
            // dsComments
            // 
            this.dsComments.DataSetName = "dsComments";
            this.dsComments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobbatchesBindingSource1
            // 
            this.jobbatchesBindingSource1.DataMember = "Job_batches";
            this.jobbatchesBindingSource1.DataSource = this.jobBatchesBindingSource;
            // 
            // jobBatchesBindingSource
            // 
            this.jobBatchesBindingSource.DataSource = this.jobBatches;
            this.jobBatchesBindingSource.Position = 0;
            // 
            // jobBatches
            // 
            this.jobBatches.DataSetName = "JobBatches";
            this.jobBatches.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // job_batchesTableAdapter
            // 
            this.job_batchesTableAdapter.ClearBeforeFill = true;
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobNumber.Location = new System.Drawing.Point(15, 351);
            this.lblJobNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(90, 31);
            this.lblJobNumber.TabIndex = 3;
            this.lblJobNumber.Text = "BASE";
            // 
            // lblTooltype
            // 
            this.lblTooltype.AutoSize = true;
            this.lblTooltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooltype.Location = new System.Drawing.Point(15, 383);
            this.lblTooltype.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTooltype.Name = "lblTooltype";
            this.lblTooltype.Size = new System.Drawing.Size(68, 25);
            this.lblTooltype.TabIndex = 4;
            this.lblTooltype.Text = "TYPE";
            // 
            // lblShipdate
            // 
            this.lblShipdate.AutoSize = true;
            this.lblShipdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipdate.Location = new System.Drawing.Point(15, 591);
            this.lblShipdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShipdate.Name = "lblShipdate";
            this.lblShipdate.Size = new System.Drawing.Size(116, 25);
            this.lblShipdate.TabIndex = 5;
            this.lblShipdate.Text = "SHIPDATE";
            this.lblShipdate.Click += new System.EventHandler(this.lblShipdate_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComment.Location = new System.Drawing.Point(670, 11);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(136, 38);
            this.btnAddComment.TabIndex = 6;
            this.btnAddComment.Text = "Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnDates
            // 
            this.btnDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDates.Location = new System.Drawing.Point(1180, 728);
            this.btnDates.Margin = new System.Windows.Forms.Padding(6);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(174, 48);
            this.btnDates.TabIndex = 7;
            this.btnDates.Text = "Update Dates";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // dtpFab
            // 
            this.dtpFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFab.Location = new System.Drawing.Point(827, 622);
            this.dtpFab.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFab.Name = "dtpFab";
            this.dtpFab.Size = new System.Drawing.Size(128, 29);
            this.dtpFab.TabIndex = 8;
            this.dtpFab.Value = new System.DateTime(2017, 5, 10, 0, 0, 0, 0);
            this.dtpFab.ValueChanged += new System.EventHandler(this.dtpFab_changed);
            // 
            // dtpMachineComp
            // 
            this.dtpMachineComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMachineComp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMachineComp.Location = new System.Drawing.Point(1327, 576);
            this.dtpMachineComp.Margin = new System.Windows.Forms.Padding(6);
            this.dtpMachineComp.Name = "dtpMachineComp";
            this.dtpMachineComp.Size = new System.Drawing.Size(140, 29);
            this.dtpMachineComp.TabIndex = 9;
            this.dtpMachineComp.ValueChanged += new System.EventHandler(this.dtpmachcomp_changed);
            // 
            // dtpMachine
            // 
            this.dtpMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMachine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMachine.Location = new System.Drawing.Point(1327, 537);
            this.dtpMachine.Margin = new System.Windows.Forms.Padding(6);
            this.dtpMachine.Name = "dtpMachine";
            this.dtpMachine.Size = new System.Drawing.Size(140, 29);
            this.dtpMachine.TabIndex = 10;
            this.dtpMachine.ValueChanged += new System.EventHandler(this.dtpsmach_changed);
            // 
            // dtpHt
            // 
            this.dtpHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHt.Location = new System.Drawing.Point(827, 665);
            this.dtpHt.Margin = new System.Windows.Forms.Padding(6);
            this.dtpHt.Name = "dtpHt";
            this.dtpHt.Size = new System.Drawing.Size(128, 29);
            this.dtpHt.TabIndex = 11;
            this.dtpHt.ValueChanged += new System.EventHandler(this.dtpht_changed);
            // 
            // dtpRdyChk
            // 
            this.dtpRdyChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRdyChk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRdyChk.Location = new System.Drawing.Point(1327, 660);
            this.dtpRdyChk.Margin = new System.Windows.Forms.Padding(6);
            this.dtpRdyChk.Name = "dtpRdyChk";
            this.dtpRdyChk.Size = new System.Drawing.Size(140, 29);
            this.dtpRdyChk.TabIndex = 15;
            this.dtpRdyChk.ValueChanged += new System.EventHandler(this.dtpchk_changed);
            // 
            // dtpSrc
            // 
            this.dtpSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSrc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSrc.Location = new System.Drawing.Point(1000, 736);
            this.dtpSrc.Margin = new System.Windows.Forms.Padding(6);
            this.dtpSrc.Name = "dtpSrc";
            this.dtpSrc.Size = new System.Drawing.Size(140, 29);
            this.dtpSrc.TabIndex = 14;
            this.dtpSrc.ValueChanged += new System.EventHandler(this.dtpsrc_changed);
            // 
            // dtpDesRel
            // 
            this.dtpDesRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesRel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesRel.Location = new System.Drawing.Point(827, 536);
            this.dtpDesRel.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDesRel.Name = "dtpDesRel";
            this.dtpDesRel.Size = new System.Drawing.Size(128, 29);
            this.dtpDesRel.TabIndex = 13;
            this.dtpDesRel.ValueChanged += new System.EventHandler(this.dtpdesrel_changed);
            // 
            // dtpAssy
            // 
            this.dtpAssy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAssy.Location = new System.Drawing.Point(1327, 620);
            this.dtpAssy.Margin = new System.Windows.Forms.Padding(6);
            this.dtpAssy.Name = "dtpAssy";
            this.dtpAssy.Size = new System.Drawing.Size(140, 29);
            this.dtpAssy.TabIndex = 12;
            this.dtpAssy.ValueChanged += new System.EventHandler(this.dtpassy_changed);
            // 
            // dtpMaterial
            // 
            this.dtpMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMaterial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMaterial.Location = new System.Drawing.Point(827, 579);
            this.dtpMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.dtpMaterial.Name = "dtpMaterial";
            this.dtpMaterial.Size = new System.Drawing.Size(128, 29);
            this.dtpMaterial.TabIndex = 16;
            this.dtpMaterial.Value = new System.DateTime(2017, 5, 10, 0, 0, 0, 0);
            this.dtpMaterial.ValueChanged += new System.EventHandler(this.dtpMaterial_changed);
            // 
            // lblRecvMaterial
            // 
            this.lblRecvMaterial.AutoSize = true;
            this.lblRecvMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecvMaterial.Location = new System.Drawing.Point(666, 579);
            this.lblRecvMaterial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecvMaterial.Name = "lblRecvMaterial";
            this.lblRecvMaterial.Size = new System.Drawing.Size(149, 24);
            this.lblRecvMaterial.TabIndex = 17;
            this.lblRecvMaterial.Text = "Receive Material";
            // 
            // lblStartFab
            // 
            this.lblStartFab.AutoSize = true;
            this.lblStartFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartFab.Location = new System.Drawing.Point(671, 621);
            this.lblStartFab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartFab.Name = "lblStartFab";
            this.lblStartFab.Size = new System.Drawing.Size(144, 24);
            this.lblStartFab.TabIndex = 18;
            this.lblStartFab.Text = "Start Fabrication";
            // 
            // lblStartMachining
            // 
            this.lblStartMachining.AutoSize = true;
            this.lblStartMachining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartMachining.Location = new System.Drawing.Point(1176, 536);
            this.lblStartMachining.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartMachining.Name = "lblStartMachining";
            this.lblStartMachining.Size = new System.Drawing.Size(139, 24);
            this.lblStartMachining.TabIndex = 20;
            this.lblStartMachining.Text = "Start Machining";
            this.lblStartMachining.Click += new System.EventHandler(this.lblStartMachining_Click);
            // 
            // lblHeatTreat
            // 
            this.lblHeatTreat.AutoSize = true;
            this.lblHeatTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatTreat.Location = new System.Drawing.Point(718, 663);
            this.lblHeatTreat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeatTreat.Name = "lblHeatTreat";
            this.lblHeatTreat.Size = new System.Drawing.Size(97, 24);
            this.lblHeatTreat.TabIndex = 19;
            this.lblHeatTreat.Text = "Heat Treat";
            this.lblHeatTreat.Click += new System.EventHandler(this.lblHeatTreat_Click);
            // 
            // lblDesignRelease
            // 
            this.lblDesignRelease.AutoSize = true;
            this.lblDesignRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignRelease.Location = new System.Drawing.Point(683, 537);
            this.lblDesignRelease.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDesignRelease.Name = "lblDesignRelease";
            this.lblDesignRelease.Size = new System.Drawing.Size(132, 24);
            this.lblDesignRelease.TabIndex = 22;
            this.lblDesignRelease.Text = "Des Rel to Mfg";
            // 
            // lblRdyCheck
            // 
            this.lblRdyCheck.AutoSize = true;
            this.lblRdyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdyCheck.Location = new System.Drawing.Point(1158, 665);
            this.lblRdyCheck.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRdyCheck.Name = "lblRdyCheck";
            this.lblRdyCheck.Size = new System.Drawing.Size(157, 24);
            this.lblRdyCheck.TabIndex = 21;
            this.lblRdyCheck.Text = "Ready For Check";
            // 
            // lblRdySource
            // 
            this.lblRdySource.AutoSize = true;
            this.lblRdySource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdySource.Location = new System.Drawing.Point(832, 741);
            this.lblRdySource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRdySource.Name = "lblRdySource";
            this.lblRdySource.Size = new System.Drawing.Size(156, 24);
            this.lblRdySource.TabIndex = 23;
            this.lblRdySource.Text = "Ready for Source";
            // 
            // lblStartAssembly
            // 
            this.lblStartAssembly.AutoSize = true;
            this.lblStartAssembly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartAssembly.Location = new System.Drawing.Point(1182, 622);
            this.lblStartAssembly.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStartAssembly.Name = "lblStartAssembly";
            this.lblStartAssembly.Size = new System.Drawing.Size(133, 24);
            this.lblStartAssembly.TabIndex = 26;
            this.lblStartAssembly.Text = "Start Assembly";
            // 
            // lblMachineComplete
            // 
            this.lblMachineComplete.AutoSize = true;
            this.lblMachineComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineComplete.Location = new System.Drawing.Point(1146, 581);
            this.lblMachineComplete.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMachineComplete.Name = "lblMachineComplete";
            this.lblMachineComplete.Size = new System.Drawing.Size(169, 24);
            this.lblMachineComplete.TabIndex = 25;
            this.lblMachineComplete.Text = "Machine Complete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1157, 782);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Red Background = Unset Dates";
            // 
            // btnUpdatePicture
            // 
            this.btnUpdatePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePicture.Location = new System.Drawing.Point(421, 357);
            this.btnUpdatePicture.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdatePicture.Name = "btnUpdatePicture";
            this.btnUpdatePicture.Size = new System.Drawing.Size(172, 38);
            this.btnUpdatePicture.TabIndex = 29;
            this.btnUpdatePicture.TabStop = false;
            this.btnUpdatePicture.Text = "Update Picture";
            this.btnUpdatePicture.UseVisualStyleBackColor = true;
            this.btnUpdatePicture.Click += new System.EventHandler(this.btnUpdatePicture_Click);
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuys
            // 
            this.btnGuys.Location = new System.Drawing.Point(1109, 11);
            this.btnGuys.Name = "btnGuys";
            this.btnGuys.Size = new System.Drawing.Size(116, 38);
            this.btnGuys.TabIndex = 31;
            this.btnGuys.Text = ">>>";
            this.btnGuys.UseVisualStyleBackColor = true;
            this.btnGuys.Visible = false;
            this.btnGuys.Click += new System.EventHandler(this.btnGuys_Click);
            // 
            // lblPm
            // 
            this.lblPm.AutoSize = true;
            this.lblPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPm.Location = new System.Drawing.Point(15, 409);
            this.lblPm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPm.Name = "lblPm";
            this.lblPm.Size = new System.Drawing.Size(267, 25);
            this.lblPm.TabIndex = 32;
            this.lblPm.Text = "Program Manager: Not Set";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.Location = new System.Drawing.Point(15, 435);
            this.lblProcessor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(192, 25);
            this.lblProcessor.TabIndex = 33;
            this.lblProcessor.Text = "Processor: Not Set";
            // 
            // lblKickoff
            // 
            this.lblKickoff.AutoSize = true;
            this.lblKickoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKickoff.Location = new System.Drawing.Point(15, 513);
            this.lblKickoff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKickoff.Name = "lblKickoff";
            this.lblKickoff.Size = new System.Drawing.Size(191, 25);
            this.lblKickoff.TabIndex = 35;
            this.lblKickoff.Text = "Job Not Kicked Off";
            this.lblKickoff.Click += new System.EventHandler(this.lblKickoff_Click);
            // 
            // lblBuldLeader
            // 
            this.lblBuldLeader.AutoSize = true;
            this.lblBuldLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuldLeader.Location = new System.Drawing.Point(15, 461);
            this.lblBuldLeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBuldLeader.Name = "lblBuldLeader";
            this.lblBuldLeader.Size = new System.Drawing.Size(216, 25);
            this.lblBuldLeader.TabIndex = 34;
            this.lblBuldLeader.Text = "Build Leader: Not Set";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(15, 539);
            this.lblData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(193, 25);
            this.lblData.TabIndex = 36;
            this.lblData.Text = "Data Not Released";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(15, 565);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(208, 25);
            this.lblFolder.TabIndex = 37;
            this.lblFolder.Text = "Folder Not Received";
            this.lblFolder.Click += new System.EventHandler(this.lblFolder_Click);
            // 
            // lblPoDate
            // 
            this.lblPoDate.AutoSize = true;
            this.lblPoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoDate.Location = new System.Drawing.Point(15, 487);
            this.lblPoDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoDate.Name = "lblPoDate";
            this.lblPoDate.Size = new System.Drawing.Size(207, 25);
            this.lblPoDate.TabIndex = 38;
            this.lblPoDate.Text = "No PO Date Entered";
            // 
            // chkDes
            // 
            this.chkDes.AutoSize = true;
            this.chkDes.Location = new System.Drawing.Point(964, 536);
            this.chkDes.Name = "chkDes";
            this.chkDes.Size = new System.Drawing.Size(66, 29);
            this.chkDes.TabIndex = 39;
            this.chkDes.Text = "N/A";
            this.chkDes.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(964, 579);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 29);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "N/A";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(964, 621);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 29);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "N/A";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(964, 665);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 29);
            this.checkBox3.TabIndex = 42;
            this.checkBox3.Text = "N/A";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // btnActionItems
            // 
            this.btnActionItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionItems.Location = new System.Drawing.Point(818, 11);
            this.btnActionItems.Margin = new System.Windows.Forms.Padding(6);
            this.btnActionItems.Name = "btnActionItems";
            this.btnActionItems.Size = new System.Drawing.Size(136, 38);
            this.btnActionItems.TabIndex = 43;
            this.btnActionItems.Text = "Action Item";
            this.btnActionItems.UseVisualStyleBackColor = true;
            this.btnActionItems.Click += new System.EventHandler(this.btnActionItems_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(670, 60);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(114, 25);
            this.lblComments.TabIndex = 45;
            this.lblComments.Text = "Comments";
            // 
            // lblActionitems
            // 
            this.lblActionitems.AutoSize = true;
            this.lblActionitems.Location = new System.Drawing.Point(670, 299);
            this.lblActionitems.Name = "lblActionitems";
            this.lblActionitems.Size = new System.Drawing.Size(129, 25);
            this.lblActionitems.TabIndex = 46;
            this.lblActionitems.Text = "Action Items";
            // 
            // dgvActionItems
            // 
            this.dgvActionItems.AllowUserToAddRows = false;
            this.dgvActionItems.AllowUserToDeleteRows = false;
            this.dgvActionItems.AutoGenerateColumns = false;
            this.dgvActionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asigneeDataGridViewTextBoxColumn,
            this.openitem,
            this.ActionRequired,
            this.createDateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.submitterDataGridViewTextBoxColumn,
            this.critical,
            this.ID});
            this.dgvActionItems.DataSource = this.actionItemsBindingSource;
            this.dgvActionItems.Location = new System.Drawing.Point(670, 327);
            this.dgvActionItems.Name = "dgvActionItems";
            this.dgvActionItems.ReadOnly = true;
            this.dgvActionItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActionItems.Size = new System.Drawing.Size(1080, 201);
            this.dgvActionItems.TabIndex = 47;
            this.dgvActionItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActionItems_CellClick1);
            this.dgvActionItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActionItems_CellContentClick);
            // 
            // asigneeDataGridViewTextBoxColumn
            // 
            this.asigneeDataGridViewTextBoxColumn.DataPropertyName = "Asignee";
            this.asigneeDataGridViewTextBoxColumn.HeaderText = "Asignee";
            this.asigneeDataGridViewTextBoxColumn.Name = "asigneeDataGridViewTextBoxColumn";
            this.asigneeDataGridViewTextBoxColumn.ReadOnly = true;
            this.asigneeDataGridViewTextBoxColumn.Width = 180;
            // 
            // openitem
            // 
            this.openitem.DataPropertyName = "openitem";
            this.openitem.HeaderText = "Open?";
            this.openitem.Name = "openitem";
            this.openitem.ReadOnly = true;
            // 
            // ActionRequired
            // 
            this.ActionRequired.DataPropertyName = "ActionRequired";
            this.ActionRequired.HeaderText = "ActionRequired";
            this.ActionRequired.Name = "ActionRequired";
            this.ActionRequired.ReadOnly = true;
            this.ActionRequired.Width = 320;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 180;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.duedateDataGridViewTextBoxColumn.Width = 180;
            // 
            // submitterDataGridViewTextBoxColumn
            // 
            this.submitterDataGridViewTextBoxColumn.DataPropertyName = "Submitter";
            this.submitterDataGridViewTextBoxColumn.HeaderText = "Submitter";
            this.submitterDataGridViewTextBoxColumn.Name = "submitterDataGridViewTextBoxColumn";
            this.submitterDataGridViewTextBoxColumn.ReadOnly = true;
            this.submitterDataGridViewTextBoxColumn.Width = 180;
            // 
            // critical
            // 
            this.critical.DataPropertyName = "critical";
            this.critical.HeaderText = "critical";
            this.critical.Name = "critical";
            this.critical.ReadOnly = true;
            this.critical.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // actionItemsBindingSource
            // 
            this.actionItemsBindingSource.DataMember = "ActionItems";
            this.actionItemsBindingSource.DataSource = this.ds_ActionItems;
            this.actionItemsBindingSource.CurrentChanged += new System.EventHandler(this.actionItemsBindingSource_CurrentChanged);
            // 
            // ds_ActionItems
            // 
            this.ds_ActionItems.DataSetName = "ds_ActionItems";
            this.ds_ActionItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRfq
            // 
            this.btnRfq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRfq.Location = new System.Drawing.Point(964, 11);
            this.btnRfq.Margin = new System.Windows.Forms.Padding(6);
            this.btnRfq.Name = "btnRfq";
            this.btnRfq.Size = new System.Drawing.Size(136, 38);
            this.btnRfq.TabIndex = 48;
            this.btnRfq.Text = "Heat Treat";
            this.btnRfq.UseVisualStyleBackColor = true;
            this.btnRfq.Click += new System.EventHandler(this.btnRfq_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(421, 404);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(172, 69);
            this.btnHistory.TabIndex = 49;
            this.btnHistory.Text = "View Job History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnComments
            // 
            this.btnComments.Location = new System.Drawing.Point(421, 479);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(172, 69);
            this.btnComments.TabIndex = 50;
            this.btnComments.Text = "View Comment History";
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(421, 554);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(172, 69);
            this.btnSchedule.TabIndex = 51;
            this.btnSchedule.Text = "View/Edit Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnFolders
            // 
            this.btnFolders.Location = new System.Drawing.Point(421, 629);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(172, 69);
            this.btnFolders.TabIndex = 52;
            this.btnFolders.Text = "Update Folders";
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // ds_Comments1
            // 
            this.ds_Comments1.DataSetName = "ds_Comments";
            this.ds_Comments1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPMFolder
            // 
            this.lblPMFolder.AutoSize = true;
            this.lblPMFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMFolder.Location = new System.Drawing.Point(16, 648);
            this.lblPMFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPMFolder.Name = "lblPMFolder";
            this.lblPMFolder.Size = new System.Drawing.Size(129, 25);
            this.lblPMFolder.TabIndex = 53;
            this.lblPMFolder.Text = "PMFOLDER";
            // 
            // lblProcessorFolder
            // 
            this.lblProcessorFolder.AutoSize = true;
            this.lblProcessorFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessorFolder.Location = new System.Drawing.Point(16, 673);
            this.lblProcessorFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProcessorFolder.Name = "lblProcessorFolder";
            this.lblProcessorFolder.Size = new System.Drawing.Size(170, 25);
            this.lblProcessorFolder.TabIndex = 54;
            this.lblProcessorFolder.Text = "ProcessorFolder";
            // 
            // lblWeldFolder
            // 
            this.lblWeldFolder.AutoSize = true;
            this.lblWeldFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeldFolder.Location = new System.Drawing.Point(16, 698);
            this.lblWeldFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWeldFolder.Name = "lblWeldFolder";
            this.lblWeldFolder.Size = new System.Drawing.Size(122, 25);
            this.lblWeldFolder.TabIndex = 55;
            this.lblWeldFolder.Text = "WeldFolder";
            // 
            // lblBuildFolder
            // 
            this.lblBuildFolder.AutoSize = true;
            this.lblBuildFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildFolder.Location = new System.Drawing.Point(16, 748);
            this.lblBuildFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBuildFolder.Name = "lblBuildFolder";
            this.lblBuildFolder.Size = new System.Drawing.Size(121, 25);
            this.lblBuildFolder.TabIndex = 57;
            this.lblBuildFolder.Text = "BuildFolder";
            // 
            // lblMachineFolder
            // 
            this.lblMachineFolder.AutoSize = true;
            this.lblMachineFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineFolder.Location = new System.Drawing.Point(16, 723);
            this.lblMachineFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMachineFolder.Name = "lblMachineFolder";
            this.lblMachineFolder.Size = new System.Drawing.Size(155, 25);
            this.lblMachineFolder.TabIndex = 56;
            this.lblMachineFolder.Text = "MachineFolder";
            // 
            // actionItemsTableAdapter
            // 
            this.actionItemsTableAdapter.ClearBeforeFill = true;
            // 
            // pbLight
            // 
            this.pbLight.Image = global::WipViewer.Properties.Resources.light_red_flash;
            this.pbLight.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLight.InitialImage")));
            this.pbLight.Location = new System.Drawing.Point(1583, 91);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(206, 217);
            this.pbLight.TabIndex = 58;
            this.pbLight.TabStop = false;
            this.pbLight.Visible = false;
            this.pbLight.Click += new System.EventHandler(this.pbLight_Click);
            // 
            // pbJob
            // 
            this.pbJob.Location = new System.Drawing.Point(15, 16);
            this.pbJob.Margin = new System.Windows.Forms.Padding(6);
            this.pbJob.Name = "pbJob";
            this.pbJob.Size = new System.Drawing.Size(578, 329);
            this.pbJob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJob.TabIndex = 2;
            this.pbJob.TabStop = false;
            this.pbJob.Click += new System.EventHandler(this.pbjob_click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnRA
            // 
            this.btnRA.Location = new System.Drawing.Point(421, 704);
            this.btnRA.Name = "btnRA";
            this.btnRA.Size = new System.Drawing.Size(172, 61);
            this.btnRA.TabIndex = 59;
            this.btnRA.Text = "Risk Assessment";
            this.btnRA.UseVisualStyleBackColor = true;
            this.btnRA.Click += new System.EventHandler(this.btnRA_Click);
            // 
            // btnAQP
            // 
            this.btnAQP.Location = new System.Drawing.Point(421, 771);
            this.btnAQP.Name = "btnAQP";
            this.btnAQP.Size = new System.Drawing.Size(172, 61);
            this.btnAQP.TabIndex = 60;
            this.btnAQP.Text = "AQP";
            this.btnAQP.UseVisualStyleBackColor = true;
            this.btnAQP.Click += new System.EventHandler(this.btnAQP_Click);
            // 
            // jobview2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 841);
            this.Controls.Add(this.btnAQP);
            this.Controls.Add(this.btnRA);
            this.Controls.Add(this.pbLight);
            this.Controls.Add(this.lblBuildFolder);
            this.Controls.Add(this.lblMachineFolder);
            this.Controls.Add(this.lblWeldFolder);
            this.Controls.Add(this.lblProcessorFolder);
            this.Controls.Add(this.lblPMFolder);
            this.Controls.Add(this.btnFolders);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnRfq);
            this.Controls.Add(this.dgvActionItems);
            this.Controls.Add(this.lblActionitems);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.btnActionItems);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkDes);
            this.Controls.Add(this.lblPoDate);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblKickoff);
            this.Controls.Add(this.lblBuldLeader);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblPm);
            this.Controls.Add(this.btnGuys);
            this.Controls.Add(this.btnUpdatePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStartAssembly);
            this.Controls.Add(this.lblMachineComplete);
            this.Controls.Add(this.lblRdySource);
            this.Controls.Add(this.lblDesignRelease);
            this.Controls.Add(this.lblRdyCheck);
            this.Controls.Add(this.lblStartMachining);
            this.Controls.Add(this.lblHeatTreat);
            this.Controls.Add(this.lblStartFab);
            this.Controls.Add(this.lblRecvMaterial);
            this.Controls.Add(this.dtpMaterial);
            this.Controls.Add(this.dtpRdyChk);
            this.Controls.Add(this.dtpSrc);
            this.Controls.Add(this.dtpDesRel);
            this.Controls.Add(this.dtpAssy);
            this.Controls.Add(this.dtpHt);
            this.Controls.Add(this.dtpMachine);
            this.Controls.Add(this.dtpMachineComp);
            this.Controls.Add(this.dtpFab);
            this.Controls.Add(this.btnDates);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.lblShipdate);
            this.Controls.Add(this.lblTooltype);
            this.Controls.Add(this.lblJobNumber);
            this.Controls.Add(this.pbJob);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "jobview2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.jobview2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbatchesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ActionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsComments dsComments;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private dsCommentsTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.BindingSource jobBatchesBindingSource;
        private JobBatches jobBatches;
        private System.Windows.Forms.BindingSource jobbatchesBindingSource1;
        private JobBatchesTableAdapters.Job_batchesTableAdapter job_batchesTableAdapter;
        private System.Windows.Forms.PictureBox pbJob;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblTooltype;
        private System.Windows.Forms.Label lblShipdate;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnDates;
        private System.Windows.Forms.DateTimePicker dtpFab;
        private System.Windows.Forms.DateTimePicker dtpMachineComp;
        private System.Windows.Forms.DateTimePicker dtpMachine;
        private System.Windows.Forms.DateTimePicker dtpHt;
        private System.Windows.Forms.DateTimePicker dtpRdyChk;
        private System.Windows.Forms.DateTimePicker dtpSrc;
        private System.Windows.Forms.DateTimePicker dtpDesRel;
        private System.Windows.Forms.DateTimePicker dtpAssy;
        private System.Windows.Forms.DateTimePicker dtpMaterial;
        private System.Windows.Forms.Label lblRecvMaterial;
        private System.Windows.Forms.Label lblStartFab;
        private System.Windows.Forms.Label lblStartMachining;
        private System.Windows.Forms.Label lblHeatTreat;
        private System.Windows.Forms.Label lblDesignRelease;
        private System.Windows.Forms.Label lblRdyCheck;
        private System.Windows.Forms.Label lblRdySource;
        private System.Windows.Forms.Label lblStartAssembly;
        private System.Windows.Forms.Label lblMachineComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePicture;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.Button btnGuys;
        private System.Windows.Forms.Label lblPm;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblKickoff;
        private System.Windows.Forms.Label lblBuldLeader;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblPoDate;
        private System.Windows.Forms.CheckBox chkDes;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btnActionItems;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblActionitems;
        private ds_ActionItems ds_ActionItems;
        private System.Windows.Forms.BindingSource actionItemsBindingSource;
        private ds_ActionItemsTableAdapters.ActionItemsTableAdapter actionItemsTableAdapter;
        private System.Windows.Forms.DataGridView dgvActionItems;
        private System.Windows.Forms.Button btnRfq;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asigneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn critical;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnFolders;
        private ds_Comments ds_Comments1;
        private System.Windows.Forms.Label lblPMFolder;
        private System.Windows.Forms.Label lblProcessorFolder;
        private System.Windows.Forms.Label lblWeldFolder;
        private System.Windows.Forms.Label lblBuildFolder;
        private System.Windows.Forms.Label lblMachineFolder;
        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnRA;
        private System.Windows.Forms.Button btnAQP;
    }
}