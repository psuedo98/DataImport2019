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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvActionItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asigneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionRequiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criticalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsActionItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ActionItems = new WipViewer.ds_ActionItems();
            this.actionItemsTableAdapter = new WipViewer.ds_ActionItemsTableAdapters.ActionItemsTableAdapter();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClosed = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActionItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ActionItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActionItems
            // 
            this.dgvActionItems.AllowUserToAddRows = false;
            this.dgvActionItems.AllowUserToDeleteRows = false;
            this.dgvActionItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActionItems.AutoGenerateColumns = false;
            this.dgvActionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.baseDataGridViewTextBoxColumn,
            this.asigneeDataGridViewTextBoxColumn,
            this.actionRequiredDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.submitterDataGridViewTextBoxColumn,
            this.criticalDataGridViewTextBoxColumn,
            this.openitem});
            this.dgvActionItems.DataSource = this.actionItemsBindingSource;
            this.dgvActionItems.Location = new System.Drawing.Point(12, 12);
            this.dgvActionItems.Name = "dgvActionItems";
            this.dgvActionItems.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvActionItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActionItems.Size = new System.Drawing.Size(957, 547);
            this.dgvActionItems.TabIndex = 0;
            this.dgvActionItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActionItems_CellClick1);
            this.dgvActionItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActionItems_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // openitem
            // 
            this.openitem.DataPropertyName = "openitem";
            this.openitem.HeaderText = "openitem";
            this.openitem.Name = "openitem";
            this.openitem.ReadOnly = true;
            // 
            // actionItemsBindingSource
            // 
            this.actionItemsBindingSource.DataMember = "ActionItems";
            this.actionItemsBindingSource.DataSource = this.dsActionItemsBindingSource;
            // 
            // dsActionItemsBindingSource
            // 
            this.dsActionItemsBindingSource.DataSource = this.ds_ActionItems;
            this.dsActionItemsBindingSource.Position = 0;
            // 
            // ds_ActionItems
            // 
            this.ds_ActionItems.DataSetName = "ds_ActionItems";
            this.ds_ActionItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionItemsTableAdapter
            // 
            this.actionItemsTableAdapter.ClearBeforeFill = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 565);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Location = new System.Drawing.Point(93, 565);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(75, 23);
            this.btnClosed.TabIndex = 2;
            this.btnClosed.Text = "Closed";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(174, 565);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Both";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // ActionItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 621);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dgvActionItems);
            this.Name = "ActionItemReport";
            this.Text = "ActionItemReport";
            this.Load += new System.EventHandler(this.ActionItemReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsActionItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ActionItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActionItems;
        private System.Windows.Forms.BindingSource dsActionItemsBindingSource;
        private ds_ActionItems ds_ActionItems;
        private System.Windows.Forms.BindingSource actionItemsBindingSource;
        private ds_ActionItemsTableAdapters.ActionItemsTableAdapter actionItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asigneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionRequiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criticalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openitem;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Button btnAll;
    }
}