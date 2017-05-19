namespace WipViewer
{
    partial class Comment_report_grid
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
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_Comments = new WipViewer.ds_Comments();
            this.commentsTableAdapter = new WipViewer.ds_CommentsTableAdapters.commentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrid
            // 
            this.dgvGrid.AutoGenerateColumns = false;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.baseidDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvGrid.DataSource = this.commentsBindingSource;
            this.dgvGrid.Location = new System.Drawing.Point(12, 12);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(696, 435);
            this.dgvGrid.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // baseidDataGridViewTextBoxColumn
            // 
            this.baseidDataGridViewTextBoxColumn.DataPropertyName = "baseid";
            this.baseidDataGridViewTextBoxColumn.HeaderText = "Job #";
            this.baseidDataGridViewTextBoxColumn.Name = "baseidDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 400;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "comments";
            this.commentsBindingSource.DataSource = this.ds_Comments;
            // 
            // ds_Comments
            // 
            this.ds_Comments.DataSetName = "ds_Comments";
            this.ds_Comments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // Comment_report_grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 506);
            this.Controls.Add(this.dgvGrid);
            this.Name = "Comment_report_grid";
            this.Text = "Comment_report_grid";
            this.Load += new System.EventHandler(this.Comment_report_grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_Comments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrid;
        private ds_Comments ds_Comments;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private ds_CommentsTableAdapters.commentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}