namespace WipViewer
{
    partial class JobMaterial
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
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.vIS712DataSet = new WipViewer.VIS712DataSet();
            this.materialWIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material_WIPTableAdapter = new WipViewer.VIS712DataSetTableAdapters.Material_WIPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIS712DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialWIPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataMember = null;
            this.gridGroupingControl1.DataSource = this.materialWIPBindingSource;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(800, 450);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "16.3460.0.21";
            this.gridGroupingControl1.TableControlCellClick += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlCellClickEventHandler(this.gridGroupingControl1_TableControlCellClick);
            // 
            // vIS712DataSet
            // 
            this.vIS712DataSet.DataSetName = "VIS712DataSet";
            this.vIS712DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialWIPBindingSource
            // 
            this.materialWIPBindingSource.DataMember = "Material_WIP";
            this.materialWIPBindingSource.DataSource = this.vIS712DataSet;
            // 
            // material_WIPTableAdapter
            // 
            this.material_WIPTableAdapter.ClearBeforeFill = true;
            // 
            // JobMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridGroupingControl1);
            this.Name = "JobMaterial";
            this.Text = "JobMaterial";
            this.Load += new System.EventHandler(this.JobMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIS712DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialWIPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private VIS712DataSet vIS712DataSet;
        private System.Windows.Forms.BindingSource materialWIPBindingSource;
        private VIS712DataSetTableAdapters.Material_WIPTableAdapter material_WIPTableAdapter;
    }
}