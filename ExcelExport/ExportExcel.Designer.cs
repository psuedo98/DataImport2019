namespace ExcelExport
{
    partial class ExportExcel : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ExportExcel()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnImport = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnImpRA = this.Factory.CreateRibbonButton();
            this.btnAqp = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnImport);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // btnImport
            // 
            this.btnImport.Label = "Import to WIP";
            this.btnImport.Name = "btnImport";
            this.btnImport.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnImport_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnImpRA);
            this.group2.Items.Add(this.btnAqp);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // btnImpRA
            // 
            this.btnImpRA.Label = "Import Risk Assessment";
            this.btnImpRA.Name = "btnImpRA";
            this.btnImpRA.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnImpRA_Click);
            // 
            // btnAqp
            // 
            this.btnAqp.Label = "Import AQP";
            this.btnAqp.Name = "btnAqp";
            this.btnAqp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAqp_Click);
            // 
            // ExportExcel
            // 
            this.Name = "ExportExcel";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ExportExcel_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnImport;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnImpRA;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAqp;
    }

    partial class ThisRibbonCollection
    {
        internal ExportExcel ExportExcel
        {
            get { return this.GetRibbon<ExportExcel>(); }
        }
    }
}
