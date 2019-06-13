namespace WipViewer
{
    partial class LaborTickets
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
            this.lABORTICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIS712DataSet = new WipViewer.VIS712DataSet();
            this.lABOR_TICKETTableAdapter = new WipViewer.VIS712DataSetTableAdapters.LABOR_TICKETTableAdapter();
            this.wipLaborTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wipLaborTicketTableAdapter = new WipViewer.VIS712DataSetTableAdapters.wipLaborTicketTableAdapter();
            this.FIRST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOURSWORKEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORTICKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIS712DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wipLaborTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIRST_NAME,
            this.LAST_NAME,
            this.hOURSWORKEDDataGridViewTextBoxColumn,
            this.sHIFTDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wipLaborTicketBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lABORTICKETBindingSource
            // 
            this.lABORTICKETBindingSource.DataMember = "LABOR_TICKET";
            this.lABORTICKETBindingSource.DataSource = this.vIS712DataSet;
            // 
            // vIS712DataSet
            // 
            this.vIS712DataSet.DataSetName = "VIS712DataSet";
            this.vIS712DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lABOR_TICKETTableAdapter
            // 
            this.lABOR_TICKETTableAdapter.ClearBeforeFill = true;
            // 
            // wipLaborTicketBindingSource
            // 
            this.wipLaborTicketBindingSource.DataMember = "wipLaborTicket";
            this.wipLaborTicketBindingSource.DataSource = this.vIS712DataSet;
            // 
            // wipLaborTicketTableAdapter
            // 
            this.wipLaborTicketTableAdapter.ClearBeforeFill = true;
            // 
            // FIRST_NAME
            // 
            this.FIRST_NAME.DataPropertyName = "FIRST_NAME";
            this.FIRST_NAME.HeaderText = "FIRST_NAME";
            this.FIRST_NAME.Name = "FIRST_NAME";
            this.FIRST_NAME.ReadOnly = true;
            // 
            // LAST_NAME
            // 
            this.LAST_NAME.DataPropertyName = "LAST_NAME";
            this.LAST_NAME.HeaderText = "LAST_NAME";
            this.LAST_NAME.Name = "LAST_NAME";
            this.LAST_NAME.ReadOnly = true;
            // 
            // hOURSWORKEDDataGridViewTextBoxColumn
            // 
            this.hOURSWORKEDDataGridViewTextBoxColumn.DataPropertyName = "HOURS_WORKED";
            this.hOURSWORKEDDataGridViewTextBoxColumn.HeaderText = "HOURS_WORKED";
            this.hOURSWORKEDDataGridViewTextBoxColumn.Name = "hOURSWORKEDDataGridViewTextBoxColumn";
            this.hOURSWORKEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHIFTDATEDataGridViewTextBoxColumn
            // 
            this.sHIFTDATEDataGridViewTextBoxColumn.DataPropertyName = "SHIFT_DATE";
            this.sHIFTDATEDataGridViewTextBoxColumn.HeaderText = "SHIFT_DATE";
            this.sHIFTDATEDataGridViewTextBoxColumn.Name = "sHIFTDATEDataGridViewTextBoxColumn";
            this.sHIFTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LaborTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LaborTickets";
            this.Text = "LaborTickets";
            this.Load += new System.EventHandler(this.LaborTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lABORTICKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIS712DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wipLaborTicketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VIS712DataSet vIS712DataSet;
        private System.Windows.Forms.BindingSource lABORTICKETBindingSource;
        private VIS712DataSetTableAdapters.LABOR_TICKETTableAdapter lABOR_TICKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOURSWORKEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wipLaborTicketBindingSource;
        private VIS712DataSetTableAdapters.wipLaborTicketTableAdapter wipLaborTicketTableAdapter;
    }
}