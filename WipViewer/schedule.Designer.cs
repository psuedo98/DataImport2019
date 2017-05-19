namespace WipViewer
{
    partial class schedule
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
            this.lblheader1 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblfinsih = new System.Windows.Forms.Label();
            this.lblhrs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheader1
            // 
            this.lblheader1.AutoSize = true;
            this.lblheader1.Location = new System.Drawing.Point(12, 9);
            this.lblheader1.Name = "lblheader1";
            this.lblheader1.Size = new System.Drawing.Size(34, 13);
            this.lblheader1.TabIndex = 0;
            this.lblheader1.Text = "Job #";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(127, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(29, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Start";
            // 
            // lblfinsih
            // 
            this.lblfinsih.AutoSize = true;
            this.lblfinsih.Location = new System.Drawing.Point(237, 9);
            this.lblfinsih.Name = "lblfinsih";
            this.lblfinsih.Size = new System.Drawing.Size(29, 13);
            this.lblfinsih.TabIndex = 2;
            this.lblfinsih.Text = "Start";
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Location = new System.Drawing.Point(353, 9);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(76, 13);
            this.lblhrs.TabIndex = 3;
            this.lblhrs.Text = "Hrs Remaining";
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 653);
            this.Controls.Add(this.lblhrs);
            this.Controls.Add(this.lblfinsih);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblheader1);
            this.Name = "schedule";
            this.Text = "schedule";
            this.Load += new System.EventHandler(this.schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblfinsih;
        private System.Windows.Forms.Label lblhrs;
    }
}