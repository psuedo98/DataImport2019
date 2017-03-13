namespace WipViewer
{
    partial class JobView
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
            this.SuspendLayout();
            // 
            // JobView
            // 
            this.ClientSize = new System.Drawing.Size(1137, 493);
            this.Name = "JobView";
            this.Load += new System.EventHandler(this.JobView_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblTooltype;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jobDataFullBindingSource;
        private JobDataFull jobDataFull;
        private System.Windows.Forms.BindingSource jobHoursBindingSource;
        private JobDataFullTableAdapters.JobHoursTableAdapter jobHoursTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource jobBatchesBindingSource;
        private JobBatches jobBatches;
        private System.Windows.Forms.BindingSource jobbatchesBindingSource1;
        private JobBatchesTableAdapters.Job_batchesTableAdapter job_batchesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddComment;
        private dsComments dsComments;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private dsCommentsTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblShipdate;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.DateTimePicker dtpMaterial;
        private System.Windows.Forms.DateTimePicker dtpFab;
        private System.Windows.Forms.DateTimePicker dtpMachine;
        private System.Windows.Forms.DateTimePicker dtpHt;
        private System.Windows.Forms.DateTimePicker dtpAssy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpRdyChk;
        private System.Windows.Forms.DateTimePicker dtpMachineComp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDesRel;
        private System.Windows.Forms.DateTimePicker dtpSrc;
        private System.Windows.Forms.DataGridView dgvDates;
        private System.Windows.Forms.BindingSource importantDatesBindingSource;
        private ImportantDates importantDates;
        private System.Windows.Forms.BindingSource importantDatesBindingSource1;
        private ImportantDatesTableAdapters.ImportantDatesTableAdapter importantDatesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recvMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startFabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatTreatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startMachiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startAssyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machCompDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdyChkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdySrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desRelDataGridViewTextBoxColumn;
    }
}