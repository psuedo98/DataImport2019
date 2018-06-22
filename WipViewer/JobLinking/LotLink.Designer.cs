namespace WipViewer.JobLinking
{
    partial class LotLink
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
            this.txtBaseId = new System.Windows.Forms.TextBox();
            this.lblBaseId = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // txtBaseId
            // 
            this.txtBaseId.Location = new System.Drawing.Point(63, 15);
            this.txtBaseId.Name = "txtBaseId";
            this.txtBaseId.Size = new System.Drawing.Size(100, 20);
            this.txtBaseId.TabIndex = 0;
            this.txtBaseId.TextChanged += new System.EventHandler(this.txtBaseId_TextChanged);
            // 
            // lblBaseId
            // 
            this.lblBaseId.AutoSize = true;
            this.lblBaseId.Location = new System.Drawing.Point(12, 18);
            this.lblBaseId.Name = "lblBaseId";
            this.lblBaseId.Size = new System.Drawing.Size(45, 13);
            this.lblBaseId.TabIndex = 1;
            this.lblBaseId.Text = "Base ID";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(169, 13);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 23);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Look Up";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(250, 13);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(75, 23);
            this.btnLink.TabIndex = 3;
            this.btnLink.Text = "Link";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // LotLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 442);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.lblBaseId);
            this.Controls.Add(this.txtBaseId);
            this.Name = "LotLink";
            this.Text = "LotLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaseId;
        private System.Windows.Forms.Label lblBaseId;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}