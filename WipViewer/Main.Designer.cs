namespace WipViewer
{
    partial class Main
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
            this.lblWip = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllActiveJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWip
            // 
            this.lblWip.AutoSize = true;
            this.lblWip.BackColor = System.Drawing.Color.Transparent;
            this.lblWip.Font = new System.Drawing.Font("Futura PT Heavy", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWip.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWip.Location = new System.Drawing.Point(12, 39);
            this.lblWip.Name = "lblWip";
            this.lblWip.Size = new System.Drawing.Size(500, 103);
            this.lblWip.TabIndex = 0;
            this.lblWip.Text = "WIP VIEWER";
            this.lblWip.Click += new System.EventHandler(this.lblWip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJobToolStripMenuItem,
            this.viewAllActiveJobsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openJobToolStripMenuItem.Text = "Open Job";
            this.openJobToolStripMenuItem.Click += new System.EventHandler(this.openJobToolStripMenuItem_Click);
            // 
            // viewAllActiveJobsToolStripMenuItem
            // 
            this.viewAllActiveJobsToolStripMenuItem.Name = "viewAllActiveJobsToolStripMenuItem";
            this.viewAllActiveJobsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewAllActiveJobsToolStripMenuItem.Text = "View All Active Jobs";
            this.viewAllActiveJobsToolStripMenuItem.Click += new System.EventHandler(this.viewAllActiveJobsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(555, 169);
            this.Controls.Add(this.lblWip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllActiveJobsToolStripMenuItem;
    }
}

