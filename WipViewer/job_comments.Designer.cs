namespace WipViewer
{
    partial class job_comments
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
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.dsComments = new WipViewer.dsComments();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new WipViewer.dsCommentsTableAdapters.commentsTableAdapter();
            this.baseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Comments = new WipViewer.ds_Comments();
            this.commentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter1 = new WipViewer.ds_CommentsTableAdapters.commentsTableAdapter();
            this.commentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComments
            // 
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AutoGenerateColumns = false;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseidDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.commenterDataGridViewTextBoxColumn});
            this.dgvComments.DataSource = this.commentsBindingSource2;
            this.dgvComments.Location = new System.Drawing.Point(12, 12);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.ReadOnly = true;
            this.dgvComments.Size = new System.Drawing.Size(1113, 437);
            this.dgvComments.TabIndex = 0;
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
            // commenterDataGridViewTextBoxColumn
            // 
            this.commenterDataGridViewTextBoxColumn.DataPropertyName = "commenter";
            this.commenterDataGridViewTextBoxColumn.HeaderText = "commenter";
            this.commenterDataGridViewTextBoxColumn.Name = "commenterDataGridViewTextBoxColumn";
            this.commenterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ds_Comments
            // 
            this.ds_Comments.DataSetName = "ds_Comments";
            this.ds_Comments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentsBindingSource1
            // 
            this.commentsBindingSource1.DataMember = "comments";
            this.commentsBindingSource1.DataSource = this.ds_Comments;
            // 
            // commentsTableAdapter1
            // 
            this.commentsTableAdapter1.ClearBeforeFill = true;
            // 
            // commentsBindingSource2
            // 
            this.commentsBindingSource2.DataMember = "comments";
            this.commentsBindingSource2.DataSource = this.dsComments;
            // 
            // job_comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 461);
            this.Controls.Add(this.dgvComments);
            this.Name = "job_comments";
            this.Text = "job_comments";
            this.Load += new System.EventHandler(this.job_comments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComments;
        private dsComments dsComments;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private dsCommentsTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commenterDataGridViewTextBoxColumn;
        private ds_Comments ds_Comments;
        private System.Windows.Forms.BindingSource commentsBindingSource1;
        private ds_CommentsTableAdapters.commentsTableAdapter commentsTableAdapter1;
        private System.Windows.Forms.BindingSource commentsBindingSource2;
    }
}