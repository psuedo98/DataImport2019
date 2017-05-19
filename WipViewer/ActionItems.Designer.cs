namespace WipViewer
{
    partial class ActionItems
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
            this.lblAction = new System.Windows.Forms.Label();
            this.txtActionReq = new System.Windows.Forms.TextBox();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.txtAssignedto = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateRequired = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkCritical = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(11, 38);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(86, 13);
            this.lblAction.TabIndex = 99;
            this.lblAction.Text = "Action Required:";
            // 
            // txtActionReq
            // 
            this.txtActionReq.Location = new System.Drawing.Point(103, 38);
            this.txtActionReq.Multiline = true;
            this.txtActionReq.Name = "txtActionReq";
            this.txtActionReq.Size = new System.Drawing.Size(296, 93);
            this.txtActionReq.TabIndex = 2;
            this.txtActionReq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.Location = new System.Drawing.Point(11, 12);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(68, 13);
            this.lblAssigned.TabIndex = 99;
            this.lblAssigned.Text = "Assigned to: ";
            // 
            // txtAssignedto
            // 
            this.txtAssignedto.Location = new System.Drawing.Point(103, 12);
            this.txtAssignedto.Name = "txtAssignedto";
            this.txtAssignedto.Size = new System.Drawing.Size(152, 20);
            this.txtAssignedto.TabIndex = 1;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(299, 137);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDueDate.TabIndex = 4;
            // 
            // lblDateRequired
            // 
            this.lblDateRequired.AutoSize = true;
            this.lblDateRequired.Location = new System.Drawing.Point(214, 141);
            this.lblDateRequired.Name = "lblDateRequired";
            this.lblDateRequired.Size = new System.Drawing.Size(79, 13);
            this.lblDateRequired.TabIndex = 5;
            this.lblDateRequired.Text = "Date Required:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(324, 163);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkCritical
            // 
            this.chkCritical.AutoSize = true;
            this.chkCritical.Location = new System.Drawing.Point(145, 139);
            this.chkCritical.Name = "chkCritical";
            this.chkCritical.Size = new System.Drawing.Size(63, 17);
            this.chkCritical.TabIndex = 3;
            this.chkCritical.Text = "Critical?";
            this.chkCritical.UseVisualStyleBackColor = true;
            // 
            // ActionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 196);
            this.Controls.Add(this.chkCritical);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDateRequired);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.txtAssignedto);
            this.Controls.Add(this.lblAssigned);
            this.Controls.Add(this.txtActionReq);
            this.Controls.Add(this.lblAction);
            this.Name = "ActionItems";
            this.Text = "ActionItems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmActionItems_FormClosing);
            this.Load += new System.EventHandler(this.ActionItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtActionReq;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.TextBox txtAssignedto;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDateRequired;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkCritical;
    }
}