namespace MessageExport
{
    partial class info
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkAttach = new System.Windows.Forms.CheckBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.cmbJobNumber = new System.Windows.Forms.ComboBox();
            this.activeJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeJobs_JobNumbers = new MessageExport.ActiveJobs_JobNumbers();
            this.activeJobsTableAdapter = new MessageExport.ActiveJobs_JobNumbersTableAdapters.ActiveJobsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobs_JobNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(79, 44);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(439, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(24, 46);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(49, 13);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "Filename";
            this.lblFilename.Click += new System.EventHandler(this.lblFilename_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(443, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkAttach
            // 
            this.chkAttach.AutoSize = true;
            this.chkAttach.Location = new System.Drawing.Point(296, 70);
            this.chkAttach.Name = "chkAttach";
            this.chkAttach.Size = new System.Drawing.Size(141, 17);
            this.chkAttach.TabIndex = 3;
            this.chkAttach.Text = "Include Attatchements? ";
            this.chkAttach.UseVisualStyleBackColor = true;
            this.chkAttach.CheckedChanged += new System.EventHandler(this.chkAttach_CheckedChanged);
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(9, 23);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(64, 13);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Job Number";
            this.lblJob.Click += new System.EventHandler(this.lblJob_Click);
            // 
            // cmbJobNumber
            // 
            this.cmbJobNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJobNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJobNumber.DataSource = this.activeJobsBindingSource;
            this.cmbJobNumber.DisplayMember = "BaseID";
            this.cmbJobNumber.FormattingEnabled = true;
            this.cmbJobNumber.Location = new System.Drawing.Point(79, 20);
            this.cmbJobNumber.Name = "cmbJobNumber";
            this.cmbJobNumber.Size = new System.Drawing.Size(439, 21);
            this.cmbJobNumber.TabIndex = 6;
            this.cmbJobNumber.ValueMember = "BaseID";
            this.cmbJobNumber.SelectedIndexChanged += new System.EventHandler(this.cmbJobNumber_SelectedIndexChanged);
            // 
            // activeJobsBindingSource
            // 
            this.activeJobsBindingSource.DataMember = "ActiveJobs";
            this.activeJobsBindingSource.DataSource = this.activeJobs_JobNumbers;
            // 
            // activeJobs_JobNumbers
            // 
            this.activeJobs_JobNumbers.DataSetName = "ActiveJobs_JobNumbers";
            this.activeJobs_JobNumbers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeJobsTableAdapter
            // 
            this.activeJobsTableAdapter.ClearBeforeFill = true;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 95);
            this.Controls.Add(this.cmbJobNumber);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.chkAttach);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtFileName);
            this.Name = "info";
            this.Text = "Import Email to Wipviewer";
            this.Load += new System.EventHandler(this.info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobs_JobNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkAttach;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cmbJobNumber;
        private ActiveJobs_JobNumbers activeJobs_JobNumbers;
        private System.Windows.Forms.BindingSource activeJobsBindingSource;
        private ActiveJobs_JobNumbersTableAdapters.ActiveJobsTableAdapter activeJobsTableAdapter;
    }
}