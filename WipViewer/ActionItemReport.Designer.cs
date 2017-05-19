namespace WipViewer
{
    partial class ActionItemReport
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
            this.dgvActionItems = new System.Windows.Forms.DataGridView();
            this.ds_ActionItems = new WipViewer.ds_ActionItems();
            this.dsActionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionItemsTableAdapter = new WipViewer.ds_ActionItemsTableAdapters.ActionItemsTableAdapter();
            this.baseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asigneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ActionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActionItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActionItems
            // 
            this.dgvActionItems.AllowUserToAddRows = false;
            this.dgvActionItems.AllowUserToDeleteRows = false;
            this.dgvActionItems.AutoGenerateColumns = false;
            this.dgvActionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baseDataGridViewTextBoxColumn,
            this.asigneeDataGridViewTextBoxColumn,
            this.actionRequiredDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.submitterDataGridViewTextBoxColumn,
            this.criticalDataGridViewTextBoxColumn});
            this.dgvActionItems.DataSource = this.actionItemsBindingSource;
            this.dgvActionItems.Location = new System.Drawing.Point(12, 12);
            this.dgvActionItems.Name = "dgvActionItems";
            this.dgvActionItems.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActionItems.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActionItems.Size = new System.Drawing.Size(957, 547);
            this.dgvActionItems.TabIndex = 0;
            // 
            // ds_ActionItems
            // 
            this.ds_ActionItems.DataSetName = "ds_ActionItems";
            this.ds_ActionItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsActionItemsBindingSource
            // 
            this.dsActionItemsBindingSource.DataSource = this.ds_ActionItems;
            this.dsActionItemsBindingSource.Position = 0;
            // 
            // actionItemsBindingSource
            // 
            this.actionItemsBindingSource.DataMember = "ActionItems";
            this.actionItemsBindingSource.DataSource = this.dsActionItemsBindingSource;
            // 
            // actionItemsTableAdapter
            // 
            this.actionItemsTableAdapter.ClearBeforeFill = true;
            // 
            // baseDataGridViewTextBoxColumn
            // 
            this.baseDataGridViewTextBoxColumn.DataPropertyName = "Base";
            this.baseDataGridViewTextBoxColumn.HeaderText = "Base";
            this.baseDataGridViewTextBoxColumn.Name = "baseDataGridViewTextBoxColumn";
            this.baseDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseDataGridViewTextBoxColumn.Width = 175;
            // 
            // asigneeDataGridViewTextBoxColumn
            // 
            this.asigneeDataGridViewTextBoxColumn.DataPropertyName = "Asignee";
            this.asigneeDataGridViewTextBoxColumn.HeaderText = "Asignee";
            this.asigneeDataGridViewTextBoxColumn.Name = "asigneeDataGridViewTextBoxColumn";
            this.asigneeDataGridViewTextBoxColumn.ReadOnly = true;
            this.asigneeDataGridViewTextBoxColumn.Width = 225;
            // 
            // actionRequiredDataGridViewTextBoxColumn
            // 
            this.actionRequiredDataGridViewTextBoxColumn.DataPropertyName = "ActionRequired";
            this.actionRequiredDataGridViewTextBoxColumn.HeaderText = "ActionRequired";
            this.actionRequiredDataGridViewTextBoxColumn.Name = "actionRequiredDataGridViewTextBoxColumn";
            this.actionRequiredDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionRequiredDataGridViewTextBoxColumn.Width = 275;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // submitterDataGridViewTextBoxColumn
            // 
            this.submitterDataGridViewTextBoxColumn.DataPropertyName = "Submitter";
            this.submitterDataGridViewTextBoxColumn.HeaderText = "Submitter";
            this.submitterDataGridViewTextBoxColumn.Name = "submitterDataGridViewTextBoxColumn";
            this.submitterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criticalDataGridViewTextBoxColumn
            // 
            this.criticalDataGridViewTextBoxColumn.DataPropertyName = "critical";
            this.criticalDataGridViewTextBoxColumn.HeaderText = "critical";
            this.criticalDataGridViewTextBoxColumn.Name = "criticalDataGridViewTextBoxColumn";
            this.criticalDataGridViewTextBoxColumn.ReadOnly = true;
            this.criticalDataGridViewTextBoxColumn.Visible = false;
            // 
            // ActionItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 578);
            this.Controls.Add(this.dgvActionItems);
            this.Name = "ActionItemReport";
            this.Text = "ActionItemReport";
            this.Load += new System.EventHandler(this.ActionItemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ActionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActionItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActionItems;
        private System.Windows.Forms.BindingSource dsActionItemsBindingSource;
        private ds_ActionItems ds_ActionItems;
        private System.Windows.Forms.BindingSource actionItemsBindingSource;
        private ds_ActionItemsTableAdapters.ActionItemsTableAdapter actionItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asigneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticalDataGridViewTextBoxColumn;
    }
}