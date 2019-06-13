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
            this.btnUpdatePicture = new System.Windows.Forms.Button();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.commentsTableAdapter = new WipViewer.dsCommentsTableAdapters.commentsTableAdapter();
            this.btnGuys = new System.Windows.Forms.Button();
            this.lblPm = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblBuldLeader = new System.Windows.Forms.Label();
            this.lblPoDate = new System.Windows.Forms.Label();
            this.btnActionItems = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.actionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ActionItems = new WipViewer.ds_ActionItems();
            this.btnRfq = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnFolders = new System.Windows.Forms.Button();
            this.ds_Comments1 = new WipViewer.ds_Comments();
            this.actionItemsTableAdapter = new WipViewer.ds_ActionItemsTableAdapters.ActionItemsTableAdapter();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.pbJob = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRA = new System.Windows.Forms.Button();
            this.btnAQP = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnStatusImport = new System.Windows.Forms.Button();
            this.ofdStatus = new System.Windows.Forms.OpenFileDialog();
            this.lblActual = new System.Windows.Forms.Label();
            this.lblMachineStartAct = new System.Windows.Forms.Label();
            this.lblMachineEndAct = new System.Windows.Forms.Label();
            this.lblProcessingStartAct = new System.Windows.Forms.Label();
            this.lblProcessingEndAct = new System.Windows.Forms.Label();
            this.lblProcessingEndBase = new System.Windows.Forms.Label();
            this.lblProcessingStartBase = new System.Windows.Forms.Label();
            this.lblMachineEndBase = new System.Windows.Forms.Label();
            this.lblMachineStartBase = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnViewProject = new System.Windows.Forms.Button();
            this.lblMaterialReceivedBase = new System.Windows.Forms.Label();
            this.lblMaterialOrderBase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaterialReceivedAct = new System.Windows.Forms.Label();
            this.lblMaterialOrderAct = new System.Windows.Forms.Label();
            this.lblFabFinishBase = new System.Windows.Forms.Label();
            this.lblFabStartBase = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFabFinishAct = new System.Windows.Forms.Label();
            this.lblFabStartAct = new System.Windows.Forms.Label();
            this.lblAssemblyFinishBase = new System.Windows.Forms.Label();
            this.lblAssemblyStartBase = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.lblAssemblyFinishAct = new System.Windows.Forms.Label();
            this.lblAssemblyStartAct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbatchesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatches)).BeginInit();
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
            this.lblTooltype.Location = new System.Drawing.Point(15, 404);
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
            this.lblShipdate.Location = new System.Drawing.Point(19, 635);
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
            this.lblPm.Location = new System.Drawing.Point(15, 445);
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
            this.lblProcessor.Location = new System.Drawing.Point(15, 488);
            this.lblProcessor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(192, 25);
            this.lblProcessor.TabIndex = 33;
            this.lblProcessor.Text = "Processor: Not Set";
            // 
            // lblBuldLeader
            // 
            this.lblBuldLeader.AutoSize = true;
            this.lblBuldLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuldLeader.Location = new System.Drawing.Point(16, 531);
            this.lblBuldLeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBuldLeader.Name = "lblBuldLeader";
            this.lblBuldLeader.Size = new System.Drawing.Size(216, 25);
            this.lblBuldLeader.TabIndex = 34;
            this.lblBuldLeader.Text = "Build Leader: Not Set";
            // 
            // lblPoDate
            // 
            this.lblPoDate.AutoSize = true;
            this.lblPoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoDate.Location = new System.Drawing.Point(19, 583);
            this.lblPoDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoDate.Name = "lblPoDate";
            this.lblPoDate.Size = new System.Drawing.Size(207, 25);
            this.lblPoDate.TabIndex = 38;
            this.lblPoDate.Text = "No PO Date Entered";
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
            // actionItemsTableAdapter
            // 
            this.actionItemsTableAdapter.ClearBeforeFill = true;
            // 
            // pbLight
            // 
            //this.pbLight.Image = global::WipViewer.Properties.Resources.light_red_flash;
            //this.pbLight.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbLight.InitialImage")));
            //this.pbLight.Location = new System.Drawing.Point(1583, 91);
            //this.pbLight.Name = "pbLight";
            //this.pbLight.Size = new System.Drawing.Size(206, 217);
            //this.pbLight.TabIndex = 58;
            //this.pbLight.TabStop = false;
            //this.pbLight.Visible = false;
            //this.pbLight.Click += new System.EventHandler(this.pbLight_Click);
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
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(421, 838);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(172, 61);
            this.btnStatus.TabIndex = 61;
            this.btnStatus.Text = "Job Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnStatusImport
            // 
            this.btnStatusImport.Location = new System.Drawing.Point(634, 838);
            this.btnStatusImport.Name = "btnStatusImport";
            this.btnStatusImport.Size = new System.Drawing.Size(172, 61);
            this.btnStatusImport.TabIndex = 62;
            this.btnStatusImport.Text = "Job Status Import";
            this.btnStatusImport.UseVisualStyleBackColor = true;
            this.btnStatusImport.Click += new System.EventHandler(this.btnStatusImport_Click);
            // 
            // ofdStatus
            // 
            this.ofdStatus.FileName = "openFileDialog1";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(1048, 308);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(72, 25);
            this.lblActual.TabIndex = 63;
            this.lblActual.Text = "Actual";
            // 
            // lblMachineStartAct
            // 
            this.lblMachineStartAct.AutoSize = true;
            this.lblMachineStartAct.Location = new System.Drawing.Point(1048, 488);
            this.lblMachineStartAct.Name = "lblMachineStartAct";
            this.lblMachineStartAct.Size = new System.Drawing.Size(70, 25);
            this.lblMachineStartAct.TabIndex = 68;
            this.lblMachineStartAct.Text = "label2";
            // 
            // lblMachineEndAct
            // 
            this.lblMachineEndAct.AutoSize = true;
            this.lblMachineEndAct.Location = new System.Drawing.Point(1048, 513);
            this.lblMachineEndAct.Name = "lblMachineEndAct";
            this.lblMachineEndAct.Size = new System.Drawing.Size(70, 25);
            this.lblMachineEndAct.TabIndex = 69;
            this.lblMachineEndAct.Text = "label7";
            // 
            // lblProcessingStartAct
            // 
            this.lblProcessingStartAct.AutoSize = true;
            this.lblProcessingStartAct.Location = new System.Drawing.Point(1050, 351);
            this.lblProcessingStartAct.Name = "lblProcessingStartAct";
            this.lblProcessingStartAct.Size = new System.Drawing.Size(70, 25);
            this.lblProcessingStartAct.TabIndex = 70;
            this.lblProcessingStartAct.Text = "label8";
            // 
            // lblProcessingEndAct
            // 
            this.lblProcessingEndAct.AutoSize = true;
            this.lblProcessingEndAct.Location = new System.Drawing.Point(1050, 376);
            this.lblProcessingEndAct.Name = "lblProcessingEndAct";
            this.lblProcessingEndAct.Size = new System.Drawing.Size(70, 25);
            this.lblProcessingEndAct.TabIndex = 71;
            this.lblProcessingEndAct.Text = "label9";
            // 
            // lblProcessingEndBase
            // 
            this.lblProcessingEndBase.AutoSize = true;
            this.lblProcessingEndBase.Location = new System.Drawing.Point(920, 376);
            this.lblProcessingEndBase.Name = "lblProcessingEndBase";
            this.lblProcessingEndBase.Size = new System.Drawing.Size(82, 25);
            this.lblProcessingEndBase.TabIndex = 79;
            this.lblProcessingEndBase.Text = "label10";
            // 
            // lblProcessingStartBase
            // 
            this.lblProcessingStartBase.AutoSize = true;
            this.lblProcessingStartBase.Location = new System.Drawing.Point(920, 351);
            this.lblProcessingStartBase.Name = "lblProcessingStartBase";
            this.lblProcessingStartBase.Size = new System.Drawing.Size(82, 25);
            this.lblProcessingStartBase.TabIndex = 78;
            this.lblProcessingStartBase.Text = "label11";
            // 
            // lblMachineEndBase
            // 
            this.lblMachineEndBase.AutoSize = true;
            this.lblMachineEndBase.Location = new System.Drawing.Point(918, 513);
            this.lblMachineEndBase.Name = "lblMachineEndBase";
            this.lblMachineEndBase.Size = new System.Drawing.Size(82, 25);
            this.lblMachineEndBase.TabIndex = 77;
            this.lblMachineEndBase.Text = "label12";
            // 
            // lblMachineStartBase
            // 
            this.lblMachineStartBase.AutoSize = true;
            this.lblMachineStartBase.Location = new System.Drawing.Point(918, 488);
            this.lblMachineStartBase.Name = "lblMachineStartBase";
            this.lblMachineStartBase.Size = new System.Drawing.Size(82, 25);
            this.lblMachineStartBase.TabIndex = 76;
            this.lblMachineStartBase.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(727, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 25);
            this.label14.TabIndex = 75;
            this.label14.Text = "Processing End";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(720, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 25);
            this.label15.TabIndex = 74;
            this.label15.Text = "Processing Start";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(752, 513);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 25);
            this.label16.TabIndex = 73;
            this.label16.Text = "Machine End";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(745, 488);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 25);
            this.label17.TabIndex = 72;
            this.label17.Text = "Machine Start";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(920, 308);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 25);
            this.label18.TabIndex = 80;
            this.label18.Text = "Base";
            // 
            // btnViewProject
            // 
            this.btnViewProject.Location = new System.Drawing.Point(1194, 359);
            this.btnViewProject.Name = "btnViewProject";
            this.btnViewProject.Size = new System.Drawing.Size(148, 48);
            this.btnViewProject.TabIndex = 81;
            this.btnViewProject.Text = "View Project";
            this.btnViewProject.UseVisualStyleBackColor = true;
            this.btnViewProject.Click += new System.EventHandler(this.btnViewProject_Click);
            // 
            // lblMaterialReceivedBase
            // 
            this.lblMaterialReceivedBase.AutoSize = true;
            this.lblMaterialReceivedBase.Location = new System.Drawing.Point(918, 442);
            this.lblMaterialReceivedBase.Name = "lblMaterialReceivedBase";
            this.lblMaterialReceivedBase.Size = new System.Drawing.Size(82, 25);
            this.lblMaterialReceivedBase.TabIndex = 87;
            this.lblMaterialReceivedBase.Text = "label10";
            // 
            // lblMaterialOrderBase
            // 
            this.lblMaterialOrderBase.AutoSize = true;
            this.lblMaterialOrderBase.Location = new System.Drawing.Point(918, 417);
            this.lblMaterialOrderBase.Name = "lblMaterialOrderBase";
            this.lblMaterialOrderBase.Size = new System.Drawing.Size(82, 25);
            this.lblMaterialOrderBase.TabIndex = 86;
            this.lblMaterialOrderBase.Text = "label11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "Material Received";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Material Ordered";
            // 
            // lblMaterialReceivedAct
            // 
            this.lblMaterialReceivedAct.AutoSize = true;
            this.lblMaterialReceivedAct.Location = new System.Drawing.Point(1048, 442);
            this.lblMaterialReceivedAct.Name = "lblMaterialReceivedAct";
            this.lblMaterialReceivedAct.Size = new System.Drawing.Size(70, 25);
            this.lblMaterialReceivedAct.TabIndex = 83;
            this.lblMaterialReceivedAct.Text = "label9";
            // 
            // lblMaterialOrderAct
            // 
            this.lblMaterialOrderAct.AutoSize = true;
            this.lblMaterialOrderAct.Location = new System.Drawing.Point(1048, 417);
            this.lblMaterialOrderAct.Name = "lblMaterialOrderAct";
            this.lblMaterialOrderAct.Size = new System.Drawing.Size(70, 25);
            this.lblMaterialOrderAct.TabIndex = 82;
            this.lblMaterialOrderAct.Text = "label8";
            // 
            // lblFabFinishBase
            // 
            this.lblFabFinishBase.AutoSize = true;
            this.lblFabFinishBase.Location = new System.Drawing.Point(918, 581);
            this.lblFabFinishBase.Name = "lblFabFinishBase";
            this.lblFabFinishBase.Size = new System.Drawing.Size(82, 25);
            this.lblFabFinishBase.TabIndex = 93;
            this.lblFabFinishBase.Text = "label12";
            // 
            // lblFabStartBase
            // 
            this.lblFabStartBase.AutoSize = true;
            this.lblFabStartBase.Location = new System.Drawing.Point(918, 556);
            this.lblFabStartBase.Name = "lblFabStartBase";
            this.lblFabStartBase.Size = new System.Drawing.Size(82, 25);
            this.lblFabStartBase.TabIndex = 92;
            this.lblFabStartBase.Text = "label13";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "Fab Finish";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 90;
            this.label7.Text = "Fab Start";
            // 
            // lblFabFinishAct
            // 
            this.lblFabFinishAct.AutoSize = true;
            this.lblFabFinishAct.Location = new System.Drawing.Point(1048, 581);
            this.lblFabFinishAct.Name = "lblFabFinishAct";
            this.lblFabFinishAct.Size = new System.Drawing.Size(70, 25);
            this.lblFabFinishAct.TabIndex = 89;
            this.lblFabFinishAct.Text = "label7";
            // 
            // lblFabStartAct
            // 
            this.lblFabStartAct.AutoSize = true;
            this.lblFabStartAct.Location = new System.Drawing.Point(1048, 556);
            this.lblFabStartAct.Name = "lblFabStartAct";
            this.lblFabStartAct.Size = new System.Drawing.Size(70, 25);
            this.lblFabStartAct.TabIndex = 88;
            this.lblFabStartAct.Text = "label2";
            // 
            // lblAssemblyFinishBase
            // 
            this.lblAssemblyFinishBase.AutoSize = true;
            this.lblAssemblyFinishBase.Location = new System.Drawing.Point(918, 651);
            this.lblAssemblyFinishBase.Name = "lblAssemblyFinishBase";
            this.lblAssemblyFinishBase.Size = new System.Drawing.Size(82, 25);
            this.lblAssemblyFinishBase.TabIndex = 99;
            this.lblAssemblyFinishBase.Text = "label12";
            // 
            // lblAssemblyStartBase
            // 
            this.lblAssemblyStartBase.AutoSize = true;
            this.lblAssemblyStartBase.Location = new System.Drawing.Point(918, 626);
            this.lblAssemblyStartBase.Name = "lblAssemblyStartBase";
            this.lblAssemblyStartBase.Size = new System.Drawing.Size(82, 25);
            this.lblAssemblyStartBase.TabIndex = 98;
            this.lblAssemblyStartBase.Text = "label13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "Assembly Finish";
            // 
            // lblAssembly
            // 
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.Location = new System.Drawing.Point(734, 626);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(156, 25);
            this.lblAssembly.TabIndex = 96;
            this.lblAssembly.Text = "Assembly Start";
            // 
            // lblAssemblyFinishAct
            // 
            this.lblAssemblyFinishAct.AutoSize = true;
            this.lblAssemblyFinishAct.Location = new System.Drawing.Point(1048, 651);
            this.lblAssemblyFinishAct.Name = "lblAssemblyFinishAct";
            this.lblAssemblyFinishAct.Size = new System.Drawing.Size(70, 25);
            this.lblAssemblyFinishAct.TabIndex = 95;
            this.lblAssemblyFinishAct.Text = "label7";
            // 
            // lblAssemblyStartAct
            // 
            this.lblAssemblyStartAct.AutoSize = true;
            this.lblAssemblyStartAct.Location = new System.Drawing.Point(1048, 626);
            this.lblAssemblyStartAct.Name = "lblAssemblyStartAct";
            this.lblAssemblyStartAct.Size = new System.Drawing.Size(70, 25);
            this.lblAssemblyStartAct.TabIndex = 94;
            this.lblAssemblyStartAct.Text = "label2";
            // 
            // jobview2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.lblAssemblyFinishBase);
            this.Controls.Add(this.lblAssemblyStartBase);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAssembly);
            this.Controls.Add(this.lblAssemblyFinishAct);
            this.Controls.Add(this.lblAssemblyStartAct);
            this.Controls.Add(this.lblFabFinishBase);
            this.Controls.Add(this.lblFabStartBase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFabFinishAct);
            this.Controls.Add(this.lblFabStartAct);
            this.Controls.Add(this.lblMaterialReceivedBase);
            this.Controls.Add(this.lblMaterialOrderBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaterialReceivedAct);
            this.Controls.Add(this.lblMaterialOrderAct);
            this.Controls.Add(this.btnViewProject);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblProcessingEndBase);
            this.Controls.Add(this.lblProcessingStartBase);
            this.Controls.Add(this.lblMachineEndBase);
            this.Controls.Add(this.lblMachineStartBase);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblProcessingEndAct);
            this.Controls.Add(this.lblProcessingStartAct);
            this.Controls.Add(this.lblMachineEndAct);
            this.Controls.Add(this.lblMachineStartAct);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.btnStatusImport);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnAQP);
            this.Controls.Add(this.btnRA);
            this.Controls.Add(this.pbLight);
            this.Controls.Add(this.btnFolders);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnRfq);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.btnActionItems);
            this.Controls.Add(this.lblPoDate);
            this.Controls.Add(this.lblBuldLeader);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblPm);
            this.Controls.Add(this.btnGuys);
            this.Controls.Add(this.btnUpdatePicture);
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
        private System.Windows.Forms.Button btnUpdatePicture;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.Button btnGuys;
        private System.Windows.Forms.Label lblPm;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblBuldLeader;
        private System.Windows.Forms.Label lblPoDate;
        private System.Windows.Forms.Button btnActionItems;
        private System.Windows.Forms.Label lblComments;
        private ds_ActionItems ds_ActionItems;
        private System.Windows.Forms.BindingSource actionItemsBindingSource;
        private ds_ActionItemsTableAdapters.ActionItemsTableAdapter actionItemsTableAdapter;
        private System.Windows.Forms.Button btnRfq;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnFolders;
        private ds_Comments ds_Comments1;
        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnRA;
        private System.Windows.Forms.Button btnAQP;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnStatusImport;
        private System.Windows.Forms.OpenFileDialog ofdStatus;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Label lblMachineStartAct;
        private System.Windows.Forms.Label lblMachineEndAct;
        private System.Windows.Forms.Label lblProcessingStartAct;
        private System.Windows.Forms.Label lblProcessingEndAct;
        private System.Windows.Forms.Label lblProcessingEndBase;
        private System.Windows.Forms.Label lblProcessingStartBase;
        private System.Windows.Forms.Label lblMachineEndBase;
        private System.Windows.Forms.Label lblMachineStartBase;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnViewProject;
        private System.Windows.Forms.Label lblMaterialReceivedBase;
        private System.Windows.Forms.Label lblMaterialOrderBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaterialReceivedAct;
        private System.Windows.Forms.Label lblMaterialOrderAct;
        private System.Windows.Forms.Label lblFabFinishBase;
        private System.Windows.Forms.Label lblFabStartBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFabFinishAct;
        private System.Windows.Forms.Label lblFabStartAct;
        private System.Windows.Forms.Label lblAssemblyFinishBase;
        private System.Windows.Forms.Label lblAssemblyStartBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAssembly;
        private System.Windows.Forms.Label lblAssemblyFinishAct;
        private System.Windows.Forms.Label lblAssemblyStartAct;
    }
}