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
            this.dgvActiveJobs = new System.Windows.Forms.DataGridView();
            this.baseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_activejobs = new WipViewer.ds_activejobs();
            this.btnJobView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnseven = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblViews = new System.Windows.Forms.Label();
            this.btnLate = new System.Windows.Forms.Button();
            this.bthThisMonth = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.activeJobsTableAdapter = new WipViewer.ds_activejobsTableAdapters.ActiveJobsTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.RealDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.shipDateDataGridViewTextBoxColumn,
            this.machineDataGridViewTextBoxColumn,
            this.buildDataGridViewTextBoxColumn,
            this.weldDataGridViewTextBoxColumn,
            this.designDataGridViewTextBoxColumn,
            this.trackerDataGridViewTextBoxColumn,
            this.RealDate});
            this.dgvActiveJobs.DataSource = this.activeJobsBindingSource;
            this.dgvActiveJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActiveJobs.Location = new System.Drawing.Point(0, 0);
            this.dgvActiveJobs.Name = "dgvActiveJobs";
            this.dgvActiveJobs.ReadOnly = true;
            this.dgvActiveJobs.Size = new System.Drawing.Size(1618, 761);
            this.dgvActiveJobs.TabIndex = 0;
            this.dgvActiveJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveJobs_CellContentClick);
            // 
            // baseIDDataGridViewTextBoxColumn
            // 
            this.baseIDDataGridViewTextBoxColumn.DataPropertyName = "BaseID";
            this.baseIDDataGridViewTextBoxColumn.HeaderText = "Job #";
            this.baseIDDataGridViewTextBoxColumn.Name = "baseIDDataGridViewTextBoxColumn";
            this.baseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseIDDataGridViewTextBoxColumn.Width = 110;
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
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "Ship Date";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            this.shipDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // weldDataGridViewTextBoxColumn
            // 
            this.weldDataGridViewTextBoxColumn.DataPropertyName = "Weld";
            this.weldDataGridViewTextBoxColumn.HeaderText = "Weld";
            this.weldDataGridViewTextBoxColumn.Name = "weldDataGridViewTextBoxColumn";
            this.weldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designDataGridViewTextBoxColumn
            // 
            this.designDataGridViewTextBoxColumn.DataPropertyName = "Design";
            this.designDataGridViewTextBoxColumn.HeaderText = "Design";
            this.designDataGridViewTextBoxColumn.Name = "designDataGridViewTextBoxColumn";
            this.designDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackerDataGridViewTextBoxColumn
            // 
            this.trackerDataGridViewTextBoxColumn.DataPropertyName = "Tracker";
            this.trackerDataGridViewTextBoxColumn.HeaderText = "Tracker";
            this.trackerDataGridViewTextBoxColumn.Name = "trackerDataGridViewTextBoxColumn";
            this.trackerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnJobView
            // 
            this.btnJobView.Location = new System.Drawing.Point(6, 4);
            this.btnJobView.Name = "btnJobView";
            this.btnJobView.Size = new System.Drawing.Size(75, 23);
            this.btnJobView.TabIndex = 1;
            this.btnJobView.Text = "Open Job";
            this.btnJobView.UseVisualStyleBackColor = true;
            this.btnJobView.Click += new System.EventHandler(this.btnJobView_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJobView);
            this.panel1.Location = new System.Drawing.Point(1471, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 31);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnseven);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.lblViews);
            this.panel2.Controls.Add(this.btnLate);
            this.panel2.Controls.Add(this.bthThisMonth);
            this.panel2.Controls.Add(this.btn90);
            this.panel2.Location = new System.Drawing.Point(1430, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 129);
            this.panel2.TabIndex = 3;
            // 
            // btnseven
            // 
            this.btnseven.Location = new System.Drawing.Point(92, 41);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(75, 23);
            this.btnseven.TabIndex = 5;
            this.btnseven.Text = "Next 7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(11, 83);
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
            this.btnLate.Location = new System.Drawing.Point(92, 99);
            this.btnLate.Name = "btnLate";
            this.btnLate.Size = new System.Drawing.Size(75, 23);
            this.btnLate.TabIndex = 2;
            this.btnLate.Text = "Late!";
            this.btnLate.UseVisualStyleBackColor = true;
            this.btnLate.Click += new System.EventHandler(this.btnLate_Click);
            // 
            // bthThisMonth
            // 
            this.bthThisMonth.Location = new System.Drawing.Point(11, 54);
            this.bthThisMonth.Name = "bthThisMonth";
            this.bthThisMonth.Size = new System.Drawing.Size(75, 23);
            this.bthThisMonth.TabIndex = 1;
            this.bthThisMonth.Text = "This Month";
            this.bthThisMonth.UseVisualStyleBackColor = true;
            this.bthThisMonth.Click += new System.EventHandler(this.bthThisMonth_Click);
            // 
            // btn90
            // 
            this.btn90.Location = new System.Drawing.Point(92, 70);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(75, 23);
            this.btn90.TabIndex = 0;
            this.btn90.Text = "Next 90";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // activeJobsTableAdapter
            // 
            this.activeJobsTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.panel3.Location = new System.Drawing.Point(1430, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 168);
            this.panel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hours";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(7, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "label6";
            this.lblTotal.UseCompatibleTextRendering = true;
            this.lblTotal.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "View Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trackers";
            // 
            // lblTrackerhrs
            // 
            this.lblTrackerhrs.AutoSize = true;
            this.lblTrackerhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackerhrs.ForeColor = System.Drawing.Color.White;
            this.lblTrackerhrs.Location = new System.Drawing.Point(93, 88);
            this.lblTrackerhrs.Name = "lblTrackerhrs";
            this.lblTrackerhrs.Size = new System.Drawing.Size(35, 13);
            this.lblTrackerhrs.TabIndex = 8;
            this.lblTrackerhrs.Text = "label1";
            this.lblTrackerhrs.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Design";
            // 
            // lblDesignhrs
            // 
            this.lblDesignhrs.AutoSize = true;
            this.lblDesignhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignhrs.ForeColor = System.Drawing.Color.White;
            this.lblDesignhrs.Location = new System.Drawing.Point(93, 75);
            this.lblDesignhrs.Name = "lblDesignhrs";
            this.lblDesignhrs.Size = new System.Drawing.Size(35, 13);
            this.lblDesignhrs.TabIndex = 6;
            this.lblDesignhrs.Text = "label1";
            this.lblDesignhrs.Visible = false;
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuild.ForeColor = System.Drawing.Color.White;
            this.lblBuild.Location = new System.Drawing.Point(8, 62);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(30, 13);
            this.lblBuild.TabIndex = 5;
            this.lblBuild.Text = "Build";
            // 
            // lblBuildhrs
            // 
            this.lblBuildhrs.AutoSize = true;
            this.lblBuildhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildhrs.ForeColor = System.Drawing.Color.White;
            this.lblBuildhrs.Location = new System.Drawing.Point(93, 62);
            this.lblBuildhrs.Name = "lblBuildhrs";
            this.lblBuildhrs.Size = new System.Drawing.Size(35, 13);
            this.lblBuildhrs.TabIndex = 4;
            this.lblBuildhrs.Text = "label1";
            this.lblBuildhrs.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weld";
            // 
            // lblWeldhrs
            // 
            this.lblWeldhrs.AutoSize = true;
            this.lblWeldhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeldhrs.ForeColor = System.Drawing.Color.White;
            this.lblWeldhrs.Location = new System.Drawing.Point(93, 47);
            this.lblWeldhrs.Name = "lblWeldhrs";
            this.lblWeldhrs.Size = new System.Drawing.Size(35, 13);
            this.lblWeldhrs.TabIndex = 2;
            this.lblWeldhrs.Text = "label1";
            this.lblWeldhrs.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Machine";
            // 
            // lblMachinehrs
            // 
            this.lblMachinehrs.AutoSize = true;
            this.lblMachinehrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachinehrs.ForeColor = System.Drawing.Color.White;
            this.lblMachinehrs.Location = new System.Drawing.Point(93, 32);
            this.lblMachinehrs.Name = "lblMachinehrs";
            this.lblMachinehrs.Size = new System.Drawing.Size(35, 13);
            this.lblMachinehrs.TabIndex = 0;
            this.lblMachinehrs.Text = "label1";
            this.lblMachinehrs.Visible = false;
            // 
            // RealDate
            // 
            this.RealDate.HeaderText = "RealDate";
            this.RealDate.Name = "RealDate";
            this.RealDate.ReadOnly = true;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 761);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvActiveJobs);
            this.Name = "DataView";
            this.Text = "DataView";
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActiveJobs;
        private ds_activejobs ds_activejobs;
        private System.Windows.Forms.BindingSource activeJobsBindingSource;
        private ds_activejobsTableAdapters.ActiveJobsTableAdapter activeJobsTableAdapter;
        private System.Windows.Forms.Button btnJobView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn RealDate;
    }
}