namespace WipViewer
{
    partial class FolderSet
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
            this.lblPM = new System.Windows.Forms.Label();
            this.dtpPM = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpProcessor = new System.Windows.Forms.DateTimePicker();
            this.dtpWeld = new System.Windows.Forms.DateTimePicker();
            this.dtpMachine = new System.Windows.Forms.DateTimePicker();
            this.dtpBuild = new System.Windows.Forms.DateTimePicker();
            this.lblFolderReceive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Location = new System.Drawing.Point(67, 34);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(55, 13);
            this.lblPM.TabIndex = 0;
            this.lblPM.Text = "PM Folder";
            // 
            // dtpPM
            // 
            this.dtpPM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPM.Location = new System.Drawing.Point(128, 31);
            this.dtpPM.Name = "dtpPM";
            this.dtpPM.Size = new System.Drawing.Size(98, 20);
            this.dtpPM.TabIndex = 1;
            this.dtpPM.ValueChanged += new System.EventHandler(this.dtpPM_changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Processing Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weld Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Machine Folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Build Folder";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(151, 160);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 20);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpProcessor
            // 
            this.dtpProcessor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProcessor.Location = new System.Drawing.Point(128, 57);
            this.dtpProcessor.Name = "dtpProcessor";
            this.dtpProcessor.Size = new System.Drawing.Size(98, 20);
            this.dtpProcessor.TabIndex = 11;
            this.dtpProcessor.ValueChanged += new System.EventHandler(this.dtpProcessing_changed);
            // 
            // dtpWeld
            // 
            this.dtpWeld.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeld.Location = new System.Drawing.Point(128, 83);
            this.dtpWeld.Name = "dtpWeld";
            this.dtpWeld.Size = new System.Drawing.Size(98, 20);
            this.dtpWeld.TabIndex = 12;
            this.dtpWeld.ValueChanged += new System.EventHandler(this.dtpWeld_changed);
            // 
            // dtpMachine
            // 
            this.dtpMachine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMachine.Location = new System.Drawing.Point(128, 108);
            this.dtpMachine.Name = "dtpMachine";
            this.dtpMachine.Size = new System.Drawing.Size(98, 20);
            this.dtpMachine.TabIndex = 13;
            this.dtpMachine.ValueChanged += new System.EventHandler(this.dtpMachine_changed);
            // 
            // dtpBuild
            // 
            this.dtpBuild.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuild.Location = new System.Drawing.Point(128, 134);
            this.dtpBuild.Name = "dtpBuild";
            this.dtpBuild.Size = new System.Drawing.Size(98, 20);
            this.dtpBuild.TabIndex = 14;
            this.dtpBuild.ValueChanged += new System.EventHandler(this.dtpBuild_changed);
            // 
            // lblFolderReceive
            // 
            this.lblFolderReceive.AutoSize = true;
            this.lblFolderReceive.Location = new System.Drawing.Point(21, 9);
            this.lblFolderReceive.Name = "lblFolderReceive";
            this.lblFolderReceive.Size = new System.Drawing.Size(105, 13);
            this.lblFolderReceive.TabIndex = 15;
            this.lblFolderReceive.Text = "Folder Receive Date";
            // 
            // FolderSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 191);
            this.Controls.Add(this.lblFolderReceive);
            this.Controls.Add(this.dtpBuild);
            this.Controls.Add(this.dtpMachine);
            this.Controls.Add(this.dtpWeld);
            this.Controls.Add(this.dtpProcessor);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpPM);
            this.Controls.Add(this.lblPM);
            this.Name = "FolderSet";
            this.Text = "FolderSet";
            this.Load += new System.EventHandler(this.FolderSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.DateTimePicker dtpPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpProcessor;
        private System.Windows.Forms.DateTimePicker dtpWeld;
        private System.Windows.Forms.DateTimePicker dtpMachine;
        private System.Windows.Forms.DateTimePicker dtpBuild;
        private System.Windows.Forms.Label lblFolderReceive;
    }
}