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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsComments = new WipViewer.dsComments();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new WipViewer.dsCommentsTableAdapters.commentsTableAdapter();
            this.baseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.jobBatches = new WipViewer.JobBatches();
            this.jobBatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobbatchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.job_batchesTableAdapter = new WipViewer.JobBatchesTableAdapters.Job_batchesTableAdapter();
            this.batchDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbatchesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseidDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.commentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1216, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(407, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dsComments
            // 
            this.dsComments.DataSetName = "dsComments";
            this.dsComments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "comments";
            this.commentsBindingSource.DataSource = this.dsComments;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // baseidDataGridViewTextBoxColumn
            // 
            this.baseidDataGridViewTextBoxColumn.DataPropertyName = "baseid";
            this.baseidDataGridViewTextBoxColumn.HeaderText = "baseid";
            this.baseidDataGridViewTextBoxColumn.Name = "baseidDataGridViewTextBoxColumn";
            this.baseidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchDateDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn,
            this.weldDataGridViewTextBoxColumn,
            this.machineDataGridViewTextBoxColumn,
            this.buildDataGridViewTextBoxColumn,
            this.trackerDataGridViewTextBoxColumn,
            this.designDataGridViewTextBoxColumn,
            this.baseIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.jobbatchesBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(42, 376);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(841, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // jobBatches
            // 
            this.jobBatches.DataSetName = "JobBatches";
            this.jobBatches.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobBatchesBindingSource
            // 
            this.jobBatchesBindingSource.DataSource = this.jobBatches;
            this.jobBatchesBindingSource.Position = 0;
            // 
            // jobbatchesBindingSource1
            // 
            this.jobbatchesBindingSource1.DataMember = "Job_batches";
            this.jobbatchesBindingSource1.DataSource = this.jobBatchesBindingSource;
            // 
            // job_batchesTableAdapter
            // 
            this.job_batchesTableAdapter.ClearBeforeFill = true;
            // 
            // batchDateDataGridViewTextBoxColumn
            // 
            this.batchDateDataGridViewTextBoxColumn.DataPropertyName = "BatchDate";
            this.batchDateDataGridViewTextBoxColumn.HeaderText = "BatchDate";
            this.batchDateDataGridViewTextBoxColumn.Name = "batchDateDataGridViewTextBoxColumn";
            this.batchDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "Batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "Batch";
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weldDataGridViewTextBoxColumn
            // 
            this.weldDataGridViewTextBoxColumn.DataPropertyName = "Weld";
            this.weldDataGridViewTextBoxColumn.HeaderText = "Weld";
            this.weldDataGridViewTextBoxColumn.Name = "weldDataGridViewTextBoxColumn";
            this.weldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineDataGridViewTextBoxColumn
            // 
            this.machineDataGridViewTextBoxColumn.DataPropertyName = "Machine";
            this.machineDataGridViewTextBoxColumn.HeaderText = "Machine";
            this.machineDataGridViewTextBoxColumn.Name = "machineDataGridViewTextBoxColumn";
            this.machineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildDataGridViewTextBoxColumn
            // 
            this.buildDataGridViewTextBoxColumn.DataPropertyName = "Build";
            this.buildDataGridViewTextBoxColumn.HeaderText = "Build";
            this.buildDataGridViewTextBoxColumn.Name = "buildDataGridViewTextBoxColumn";
            this.buildDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackerDataGridViewTextBoxColumn
            // 
            this.trackerDataGridViewTextBoxColumn.DataPropertyName = "Tracker";
            this.trackerDataGridViewTextBoxColumn.HeaderText = "Tracker";
            this.trackerDataGridViewTextBoxColumn.Name = "trackerDataGridViewTextBoxColumn";
            this.trackerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designDataGridViewTextBoxColumn
            // 
            this.designDataGridViewTextBoxColumn.DataPropertyName = "Design";
            this.designDataGridViewTextBoxColumn.HeaderText = "Design";
            this.designDataGridViewTextBoxColumn.Name = "designDataGridViewTextBoxColumn";
            this.designDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseIDDataGridViewTextBoxColumn1
            // 
            this.baseIDDataGridViewTextBoxColumn1.DataPropertyName = "BaseID";
            this.baseIDDataGridViewTextBoxColumn1.HeaderText = "BaseID";
            this.baseIDDataGridViewTextBoxColumn1.Name = "baseIDDataGridViewTextBoxColumn1";
            this.baseIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 249);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.Location = new System.Drawing.Point(448, 13);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(35, 13);
            this.lblJobNumber.TabIndex = 3;
            this.lblJobNumber.Text = "label1";
            // 
            // lblTooltype
            // 
            this.lblTooltype.AutoSize = true;
            this.lblTooltype.Location = new System.Drawing.Point(448, 30);
            this.lblTooltype.Name = "lblTooltype";
            this.lblTooltype.Size = new System.Drawing.Size(35, 13);
            this.lblTooltype.TabIndex = 4;
            this.lblTooltype.Text = "label2";
            // 
            // lblShipdate
            // 
            this.lblShipdate.AutoSize = true;
            this.lblShipdate.Location = new System.Drawing.Point(448, 47);
            this.lblShipdate.Name = "lblShipdate";
            this.lblShipdate.Size = new System.Drawing.Size(35, 13);
            this.lblShipdate.TabIndex = 5;
            this.lblShipdate.Text = "label3";
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(1510, 532);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(113, 23);
            this.btnAddComment.TabIndex = 6;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnDates
            // 
            this.btnDates.Location = new System.Drawing.Point(1422, 281);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(151, 23);
            this.btnDates.TabIndex = 7;
            this.btnDates.Text = "Update Dates";
            this.btnDates.UseVisualStyleBackColor = true;
            this.btnDates.Click += new System.EventHandler(this.btnDates_Click);
            // 
            // dtpFab
            // 
            this.dtpFab.Location = new System.Drawing.Point(1386, 43);
            this.dtpFab.Name = "dtpFab";
            this.dtpFab.Size = new System.Drawing.Size(200, 20);
            this.dtpFab.TabIndex = 8;
            this.dtpFab.Value = new System.DateTime(2017, 3, 13, 0, 0, 0, 0);
            this.dtpFab.ValueChanged += new System.EventHandler(this.dtpFab_changed);
            // 
            // dtpMachineComp
            // 
            this.dtpMachineComp.Location = new System.Drawing.Point(1386, 121);
            this.dtpMachineComp.Name = "dtpMachineComp";
            this.dtpMachineComp.Size = new System.Drawing.Size(200, 20);
            this.dtpMachineComp.TabIndex = 9;
            this.dtpMachineComp.ValueChanged += new System.EventHandler(this.dtpmachcomp_changed);
            // 
            // dtpMachine
            // 
            this.dtpMachine.Location = new System.Drawing.Point(1386, 95);
            this.dtpMachine.Name = "dtpMachine";
            this.dtpMachine.Size = new System.Drawing.Size(200, 20);
            this.dtpMachine.TabIndex = 10;
            this.dtpMachine.ValueChanged += new System.EventHandler(this.dtpsmach_changed);
            // 
            // dtpHt
            // 
            this.dtpHt.Location = new System.Drawing.Point(1386, 69);
            this.dtpHt.Name = "dtpHt";
            this.dtpHt.Size = new System.Drawing.Size(200, 20);
            this.dtpHt.TabIndex = 11;
            this.dtpHt.ValueChanged += new System.EventHandler(this.dtpht_changed);
            // 
            // dtpRdyChk
            // 
            this.dtpRdyChk.Location = new System.Drawing.Point(1386, 173);
            this.dtpRdyChk.Name = "dtpRdyChk";
            this.dtpRdyChk.Size = new System.Drawing.Size(200, 20);
            this.dtpRdyChk.TabIndex = 15;
            this.dtpRdyChk.ValueChanged += new System.EventHandler(this.dtpchk_changed);
            // 
            // dtpSrc
            // 
            this.dtpSrc.Location = new System.Drawing.Point(1386, 199);
            this.dtpSrc.Name = "dtpSrc";
            this.dtpSrc.Size = new System.Drawing.Size(200, 20);
            this.dtpSrc.TabIndex = 14;
            this.dtpSrc.ValueChanged += new System.EventHandler(this.dtpsrc_changed);
            // 
            // dtpDesRel
            // 
            this.dtpDesRel.Location = new System.Drawing.Point(1386, 225);
            this.dtpDesRel.Name = "dtpDesRel";
            this.dtpDesRel.Size = new System.Drawing.Size(200, 20);
            this.dtpDesRel.TabIndex = 13;
            this.dtpDesRel.ValueChanged += new System.EventHandler(this.dtpdesrel_changed);
            // 
            // dtpAssy
            // 
            this.dtpAssy.Location = new System.Drawing.Point(1386, 147);
            this.dtpAssy.Name = "dtpAssy";
            this.dtpAssy.Size = new System.Drawing.Size(200, 20);
            this.dtpAssy.TabIndex = 12;
            this.dtpAssy.ValueChanged += new System.EventHandler(this.dtpassy_changed);
            // 
            // dtpMaterial
            // 
            this.dtpMaterial.Location = new System.Drawing.Point(1386, 17);
            this.dtpMaterial.Name = "dtpMaterial";
            this.dtpMaterial.Size = new System.Drawing.Size(200, 20);
            this.dtpMaterial.TabIndex = 16;
            this.dtpMaterial.Value = new System.DateTime(2017, 3, 13, 0, 0, 0, 0);
            this.dtpMaterial.ValueChanged += new System.EventHandler(this.dtpMaterial_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1268, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Receive Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1268, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start Fabrication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1267, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Start Machining";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1267, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Heat Treat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1267, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Design Release";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1267, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ready For Check";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1267, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ready for Source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1267, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Start Assembly";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1267, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Machine Complete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            // 
            // jobview2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 613);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "jobview2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.jobview2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBatchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbatchesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsComments dsComments;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private dsCommentsTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource jobBatchesBindingSource;
        private JobBatches jobBatches;
        private System.Windows.Forms.BindingSource jobbatchesBindingSource1;
        private JobBatchesTableAdapters.Job_batchesTableAdapter job_batchesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}