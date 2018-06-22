namespace WipViewer.ScheduleForms
{
    partial class MachSchedule
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
            this.crp1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp1
            // 
            this.crp1.ActiveViewIndex = 0;
            this.crp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp1.Location = new System.Drawing.Point(0, 0);
            this.crp1.Name = "crp1";
            this.crp1.ReportSource = "R:\\wipviewer2017\\MachineSchedule.rpt";
            this.crp1.Size = new System.Drawing.Size(720, 467);
            this.crp1.TabIndex = 0;
            this.crp1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // MachSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 467);
            this.Controls.Add(this.crp1);
            this.Name = "MachSchedule";
            this.Text = "MachSchedule";
            this.Load += new System.EventHandler(this.MachSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp1;
    }
}