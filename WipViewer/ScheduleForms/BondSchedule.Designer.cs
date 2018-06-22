namespace WipViewer.ScheduleForms
{
    partial class BondSchedule
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
            this.dtpDataRls = new System.Windows.Forms.DateTimePicker();
            this.lblDataRelease = new System.Windows.Forms.Label();
            this.lblReceiveMaterial = new System.Windows.Forms.Label();
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.lblStartFab = new System.Windows.Forms.Label();
            this.dtpFab = new System.Windows.Forms.DateTimePicker();
            this.lblMachineComplete = new System.Windows.Forms.Label();
            this.dtpMachComp = new System.Windows.Forms.DateTimePicker();
            this.lblStartMachining = new System.Windows.Forms.Label();
            this.dtpMach = new System.Windows.Forms.DateTimePicker();
            this.lblHeatTreat = new System.Windows.Forms.Label();
            this.dtpHt = new System.Windows.Forms.DateTimePicker();
            this.lblReadySource = new System.Windows.Forms.Label();
            this.dtpRdySrc = new System.Windows.Forms.DateTimePicker();
            this.lblReadyCheck = new System.Windows.Forms.Label();
            this.dtpRdyChk = new System.Windows.Forms.DateTimePicker();
            this.lblStartAssembly = new System.Windows.Forms.Label();
            this.dtpAssy = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chklistbox = new System.Windows.Forms.CheckedListBox();
            this.dgvBaseline = new System.Windows.Forms.DataGridView();
            this.dgvActuals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.btnActual = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuals)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataRls
            // 
            this.dtpDataRls.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRls.Location = new System.Drawing.Point(20, 257);
            this.dtpDataRls.Name = "dtpDataRls";
            this.dtpDataRls.Size = new System.Drawing.Size(103, 20);
            this.dtpDataRls.TabIndex = 0;
            this.dtpDataRls.ValueChanged += new System.EventHandler(this.dtpdesrel_changed);
            // 
            // lblDataRelease
            // 
            this.lblDataRelease.AutoSize = true;
            this.lblDataRelease.Location = new System.Drawing.Point(26, 236);
            this.lblDataRelease.Name = "lblDataRelease";
            this.lblDataRelease.Size = new System.Drawing.Size(90, 13);
            this.lblDataRelease.TabIndex = 1;
            this.lblDataRelease.Text = "Data Rls To MFG";
            // 
            // lblReceiveMaterial
            // 
            this.lblReceiveMaterial.AutoSize = true;
            this.lblReceiveMaterial.Location = new System.Drawing.Point(147, 236);
            this.lblReceiveMaterial.Name = "lblReceiveMaterial";
            this.lblReceiveMaterial.Size = new System.Drawing.Size(87, 13);
            this.lblReceiveMaterial.TabIndex = 3;
            this.lblReceiveMaterial.Text = "Receive Material";
            // 
            // dtpReceive
            // 
            this.dtpReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceive.Location = new System.Drawing.Point(139, 257);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(103, 20);
            this.dtpReceive.TabIndex = 1;
            this.dtpReceive.ValueChanged += new System.EventHandler(this.dtpMaterial_changed);
            // 
            // lblStartFab
            // 
            this.lblStartFab.AutoSize = true;
            this.lblStartFab.Location = new System.Drawing.Point(286, 236);
            this.lblStartFab.Name = "lblStartFab";
            this.lblStartFab.Size = new System.Drawing.Size(50, 13);
            this.lblStartFab.TabIndex = 5;
            this.lblStartFab.Text = "Start Fab";
            // 
            // dtpFab
            // 
            this.dtpFab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFab.Location = new System.Drawing.Point(260, 257);
            this.dtpFab.Name = "dtpFab";
            this.dtpFab.Size = new System.Drawing.Size(103, 20);
            this.dtpFab.TabIndex = 2;
            this.dtpFab.ValueChanged += new System.EventHandler(this.dtpFab_changed);
            // 
            // lblMachineComplete
            // 
            this.lblMachineComplete.AutoSize = true;
            this.lblMachineComplete.Location = new System.Drawing.Point(635, 236);
            this.lblMachineComplete.Name = "lblMachineComplete";
            this.lblMachineComplete.Size = new System.Drawing.Size(95, 13);
            this.lblMachineComplete.TabIndex = 11;
            this.lblMachineComplete.Text = "Machine Complete";
            // 
            // dtpMachComp
            // 
            this.dtpMachComp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMachComp.Location = new System.Drawing.Point(631, 257);
            this.dtpMachComp.Name = "dtpMachComp";
            this.dtpMachComp.Size = new System.Drawing.Size(103, 20);
            this.dtpMachComp.TabIndex = 5;
            this.dtpMachComp.ValueChanged += new System.EventHandler(this.dtpmachcomp_changed);
            // 
            // lblStartMachining
            // 
            this.lblStartMachining.AutoSize = true;
            this.lblStartMachining.Location = new System.Drawing.Point(516, 236);
            this.lblStartMachining.Name = "lblStartMachining";
            this.lblStartMachining.Size = new System.Drawing.Size(81, 13);
            this.lblStartMachining.TabIndex = 9;
            this.lblStartMachining.Text = "Start Machining";
            // 
            // dtpMach
            // 
            this.dtpMach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMach.Location = new System.Drawing.Point(505, 257);
            this.dtpMach.Name = "dtpMach";
            this.dtpMach.Size = new System.Drawing.Size(103, 20);
            this.dtpMach.TabIndex = 4;
            this.dtpMach.ValueChanged += new System.EventHandler(this.dtpsmach_changed);
            // 
            // lblHeatTreat
            // 
            this.lblHeatTreat.AutoSize = true;
            this.lblHeatTreat.Location = new System.Drawing.Point(403, 236);
            this.lblHeatTreat.Name = "lblHeatTreat";
            this.lblHeatTreat.Size = new System.Drawing.Size(58, 13);
            this.lblHeatTreat.TabIndex = 7;
            this.lblHeatTreat.Text = "Heat Treat";
            // 
            // dtpHt
            // 
            this.dtpHt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHt.Location = new System.Drawing.Point(381, 257);
            this.dtpHt.Name = "dtpHt";
            this.dtpHt.Size = new System.Drawing.Size(100, 20);
            this.dtpHt.TabIndex = 3;
            this.dtpHt.ValueChanged += new System.EventHandler(this.dtpht_changed);
            // 
            // lblReadySource
            // 
            this.lblReadySource.AutoSize = true;
            this.lblReadySource.Location = new System.Drawing.Point(1016, 236);
            this.lblReadySource.Name = "lblReadySource";
            this.lblReadySource.Size = new System.Drawing.Size(90, 13);
            this.lblReadySource.TabIndex = 17;
            this.lblReadySource.Text = "Ready for Source";
            // 
            // dtpRdySrc
            // 
            this.dtpRdySrc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRdySrc.Location = new System.Drawing.Point(1010, 257);
            this.dtpRdySrc.Name = "dtpRdySrc";
            this.dtpRdySrc.Size = new System.Drawing.Size(103, 20);
            this.dtpRdySrc.TabIndex = 8;
            this.dtpRdySrc.ValueChanged += new System.EventHandler(this.dtpsrc_changed);
            // 
            // lblReadyCheck
            // 
            this.lblReadyCheck.AutoSize = true;
            this.lblReadyCheck.Location = new System.Drawing.Point(891, 236);
            this.lblReadyCheck.Name = "lblReadyCheck";
            this.lblReadyCheck.Size = new System.Drawing.Size(87, 13);
            this.lblReadyCheck.TabIndex = 15;
            this.lblReadyCheck.Text = "Ready for Check";
            // 
            // dtpRdyChk
            // 
            this.dtpRdyChk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRdyChk.Location = new System.Drawing.Point(883, 257);
            this.dtpRdyChk.Name = "dtpRdyChk";
            this.dtpRdyChk.Size = new System.Drawing.Size(103, 20);
            this.dtpRdyChk.TabIndex = 7;
            this.dtpRdyChk.ValueChanged += new System.EventHandler(this.dtpchk_changed);
            // 
            // lblStartAssembly
            // 
            this.lblStartAssembly.AutoSize = true;
            this.lblStartAssembly.Location = new System.Drawing.Point(769, 236);
            this.lblStartAssembly.Name = "lblStartAssembly";
            this.lblStartAssembly.Size = new System.Drawing.Size(76, 13);
            this.lblStartAssembly.TabIndex = 13;
            this.lblStartAssembly.Text = "Start Assembly";
            // 
            // dtpAssy
            // 
            this.dtpAssy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAssy.Location = new System.Drawing.Point(756, 257);
            this.dtpAssy.Name = "dtpAssy";
            this.dtpAssy.Size = new System.Drawing.Size(103, 20);
            this.dtpAssy.TabIndex = 6;
            this.dtpAssy.ValueChanged += new System.EventHandler(this.dtpassy_changed);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1168, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Set/Change Baseline";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chklistbox
            // 
            this.chklistbox.FormattingEnabled = true;
            this.chklistbox.Location = new System.Drawing.Point(1168, 294);
            this.chklistbox.Name = "chklistbox";
            this.chklistbox.Size = new System.Drawing.Size(120, 94);
            this.chklistbox.TabIndex = 18;
            // 
            // dgvBaseline
            // 
            this.dgvBaseline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseline.Location = new System.Drawing.Point(12, 29);
            this.dgvBaseline.Name = "dgvBaseline";
            this.dgvBaseline.Size = new System.Drawing.Size(1279, 72);
            this.dgvBaseline.TabIndex = 19;
            this.dgvBaseline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaseline_CellContentClick);
            // 
            // dgvActuals
            // 
            this.dgvActuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActuals.Location = new System.Drawing.Point(12, 135);
            this.dgvActuals.Name = "dgvActuals";
            this.dgvActuals.Size = new System.Drawing.Size(1279, 85);
            this.dgvActuals.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Baseline Schedule";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(12, 119);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(85, 13);
            this.lblActual.TabIndex = 22;
            this.lblActual.Text = "Actual Schedule";
            // 
            // btnActual
            // 
            this.btnActual.Location = new System.Drawing.Point(1168, 265);
            this.btnActual.Name = "btnActual";
            this.btnActual.Size = new System.Drawing.Size(123, 23);
            this.btnActual.TabIndex = 23;
            this.btnActual.Text = "Submit Actuals";
            this.btnActual.UseVisualStyleBackColor = true;
            this.btnActual.Click += new System.EventHandler(this.btnActual_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1060, 365);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(102, 23);
            this.btnCopy.TabIndex = 24;
            this.btnCopy.Text = "Copy Schedule";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // BondSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1307, 403);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnActual);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvActuals);
            this.Controls.Add(this.dgvBaseline);
            this.Controls.Add(this.chklistbox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblReadySource);
            this.Controls.Add(this.dtpRdySrc);
            this.Controls.Add(this.lblReadyCheck);
            this.Controls.Add(this.dtpRdyChk);
            this.Controls.Add(this.lblStartAssembly);
            this.Controls.Add(this.dtpAssy);
            this.Controls.Add(this.lblMachineComplete);
            this.Controls.Add(this.dtpMachComp);
            this.Controls.Add(this.lblStartMachining);
            this.Controls.Add(this.dtpMach);
            this.Controls.Add(this.lblHeatTreat);
            this.Controls.Add(this.dtpHt);
            this.Controls.Add(this.lblStartFab);
            this.Controls.Add(this.dtpFab);
            this.Controls.Add(this.lblReceiveMaterial);
            this.Controls.Add(this.dtpReceive);
            this.Controls.Add(this.lblDataRelease);
            this.Controls.Add(this.dtpDataRls);
            this.Name = "BondSchedule";
            this.Text = "BondSchedule";
            this.Load += new System.EventHandler(this.BondSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataRls;
        private System.Windows.Forms.Label lblDataRelease;
        private System.Windows.Forms.Label lblReceiveMaterial;
        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.Label lblStartFab;
        private System.Windows.Forms.DateTimePicker dtpFab;
        private System.Windows.Forms.Label lblMachineComplete;
        private System.Windows.Forms.DateTimePicker dtpMachComp;
        private System.Windows.Forms.Label lblStartMachining;
        private System.Windows.Forms.DateTimePicker dtpMach;
        private System.Windows.Forms.Label lblHeatTreat;
        private System.Windows.Forms.DateTimePicker dtpHt;
        private System.Windows.Forms.Label lblReadySource;
        private System.Windows.Forms.DateTimePicker dtpRdySrc;
        private System.Windows.Forms.Label lblReadyCheck;
        private System.Windows.Forms.DateTimePicker dtpRdyChk;
        private System.Windows.Forms.Label lblStartAssembly;
        private System.Windows.Forms.DateTimePicker dtpAssy;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckedListBox chklistbox;
        private System.Windows.Forms.DataGridView dgvBaseline;
        private System.Windows.Forms.DataGridView dgvActuals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.Button btnActual;
        private System.Windows.Forms.Button btnCopy;
    }
}