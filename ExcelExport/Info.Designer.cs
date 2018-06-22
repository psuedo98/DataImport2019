namespace ExcelExport
{
    partial class Info
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
            this.cmbJobNumber = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.dataSet1 = new ExcelExport.DataSet1();
            this.activeJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeJobsTableAdapter = new ExcelExport.DataSet1TableAdapters.ActiveJobsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbJobNumber
            // 
            this.cmbJobNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJobNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJobNumber.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.activeJobsBindingSource, "BaseID", true));
            this.cmbJobNumber.DataSource = this.activeJobsBindingSource;
            this.cmbJobNumber.DisplayMember = "BaseID";
            this.cmbJobNumber.FormattingEnabled = true;
            this.cmbJobNumber.Location = new System.Drawing.Point(80, 12);
            this.cmbJobNumber.Name = "cmbJobNumber";
            this.cmbJobNumber.Size = new System.Drawing.Size(439, 21);
            this.cmbJobNumber.TabIndex = 12;
            this.cmbJobNumber.ValueMember = "BaseID";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(10, 15);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(64, 13);
            this.lblJob.TabIndex = 11;
            this.lblJob.Text = "Job Number";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(444, 92);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 25);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(25, 68);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(49, 13);
            this.lblFilename.TabIndex = 8;
            this.lblFilename.Text = "Filename";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(80, 66);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(439, 20);
            this.txtFileName.TabIndex = 7;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Sales",
            "Build",
            "Design",
            "Shipping",
            "Quality",
            "Misc"});
            this.cmbDept.Location = new System.Drawing.Point(80, 39);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(439, 21);
            this.cmbDept.TabIndex = 13;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(10, 42);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 14;
            this.lblDept.Text = "Department";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeJobsBindingSource
            // 
            this.activeJobsBindingSource.DataMember = "ActiveJobs";
            this.activeJobsBindingSource.DataSource = this.dataSet1;
            // 
            // activeJobsTableAdapter
            // 
            this.activeJobsTableAdapter.ClearBeforeFill = true;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 122);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.cmbJobNumber);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtFileName);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeJobsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJobNumber;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDept;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource activeJobsBindingSource;
        private DataSet1TableAdapters.ActiveJobsTableAdapter activeJobsTableAdapter;
    }
}