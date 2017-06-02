namespace WipViewer
{
    partial class team2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPM = new System.Windows.Forms.ComboBox();
            this.cmbProcessor = new System.Windows.Forms.ComboBox();
            this.cmbBl = new System.Windows.Forms.ComboBox();
            this.dtpPoDate = new System.Windows.Forms.DateTimePicker();
            this.dtpKickoff = new System.Windows.Forms.DateTimePicker();
            this.dtpDataRelease = new System.Windows.Forms.DateTimePicker();
            this.dtpFolderReceived = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkKickoff = new System.Windows.Forms.CheckBox();
            this.chkDataRelease = new System.Windows.Forms.CheckBox();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Processor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Build Leader";
            // 
            // cmbPM
            // 
            this.cmbPM.FormattingEnabled = true;
            this.cmbPM.Items.AddRange(new object[] {
            "Tony D\'Agostino",
            "Dean Conrad",
            "Bob Dobleske",
            "Josh Zander",
            "Peter Thoel"});
            this.cmbPM.Location = new System.Drawing.Point(110, 7);
            this.cmbPM.Name = "cmbPM";
            this.cmbPM.Size = new System.Drawing.Size(121, 21);
            this.cmbPM.TabIndex = 3;
            this.cmbPM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbProcessor
            // 
            this.cmbProcessor.FormattingEnabled = true;
            this.cmbProcessor.Items.AddRange(new object[] {
            "Chris Scandalis",
            "Jerry Thoel",
            "Jakob Hallett",
            "Zak Hallett",
            "Jamie Hopp",
            "Brian Kotas"});
            this.cmbProcessor.Location = new System.Drawing.Point(110, 35);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(121, 21);
            this.cmbProcessor.TabIndex = 4;
            // 
            // cmbBl
            // 
            this.cmbBl.FormattingEnabled = true;
            this.cmbBl.Items.AddRange(new object[] {
            "Dave Terrell",
            "Dennis Nucci",
            "Greg Sullivan",
            "Gary Kirby",
            "John Barnes",
            "Ken Riehle",
            "John Thoel"});
            this.cmbBl.Location = new System.Drawing.Point(110, 63);
            this.cmbBl.Name = "cmbBl";
            this.cmbBl.Size = new System.Drawing.Size(121, 21);
            this.cmbBl.TabIndex = 5;
            // 
            // dtpPoDate
            // 
            this.dtpPoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPoDate.Location = new System.Drawing.Point(135, 122);
            this.dtpPoDate.Name = "dtpPoDate";
            this.dtpPoDate.Size = new System.Drawing.Size(96, 20);
            this.dtpPoDate.TabIndex = 6;
            // 
            // dtpKickoff
            // 
            this.dtpKickoff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKickoff.Location = new System.Drawing.Point(135, 148);
            this.dtpKickoff.Name = "dtpKickoff";
            this.dtpKickoff.Size = new System.Drawing.Size(96, 20);
            this.dtpKickoff.TabIndex = 7;
            // 
            // dtpDataRelease
            // 
            this.dtpDataRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRelease.Location = new System.Drawing.Point(135, 174);
            this.dtpDataRelease.Name = "dtpDataRelease";
            this.dtpDataRelease.Size = new System.Drawing.Size(96, 20);
            this.dtpDataRelease.TabIndex = 8;
            // 
            // dtpFolderReceived
            // 
            this.dtpFolderReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFolderReceived.Location = new System.Drawing.Point(135, 200);
            this.dtpFolderReceived.Name = "dtpFolderReceived";
            this.dtpFolderReceived.Size = new System.Drawing.Size(96, 20);
            this.dtpFolderReceived.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PO Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kick Off";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Release";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Folder Received";
            // 
            // chkKickoff
            // 
            this.chkKickoff.AutoSize = true;
            this.chkKickoff.Location = new System.Drawing.Point(237, 154);
            this.chkKickoff.Name = "chkKickoff";
            this.chkKickoff.Size = new System.Drawing.Size(85, 17);
            this.chkKickoff.TabIndex = 14;
            this.chkKickoff.Text = "Kicked Off? ";
            this.chkKickoff.UseVisualStyleBackColor = true;
            // 
            // chkDataRelease
            // 
            this.chkDataRelease.AutoSize = true;
            this.chkDataRelease.Location = new System.Drawing.Point(237, 178);
            this.chkDataRelease.Name = "chkDataRelease";
            this.chkDataRelease.Size = new System.Drawing.Size(103, 17);
            this.chkDataRelease.TabIndex = 15;
            this.chkDataRelease.Text = "Data Released?";
            this.chkDataRelease.UseVisualStyleBackColor = true;
            // 
            // chkFolder
            // 
            this.chkFolder.AutoSize = true;
            this.chkFolder.Location = new System.Drawing.Point(237, 203);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(113, 17);
            this.chkFolder.TabIndex = 16;
            this.chkFolder.Text = "Folder Received? ";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(81, 228);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 35);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit Team";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // team2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 275);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkFolder);
            this.Controls.Add(this.chkDataRelease);
            this.Controls.Add(this.chkKickoff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFolderReceived);
            this.Controls.Add(this.dtpDataRelease);
            this.Controls.Add(this.dtpKickoff);
            this.Controls.Add(this.dtpPoDate);
            this.Controls.Add(this.cmbBl);
            this.Controls.Add(this.cmbProcessor);
            this.Controls.Add(this.cmbPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "team2";
            this.Text = "team2";
            this.Load += new System.EventHandler(this.team2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPM;
        private System.Windows.Forms.ComboBox cmbProcessor;
        private System.Windows.Forms.DateTimePicker dtpPoDate;
        private System.Windows.Forms.DateTimePicker dtpKickoff;
        private System.Windows.Forms.DateTimePicker dtpDataRelease;
        private System.Windows.Forms.DateTimePicker dtpFolderReceived;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkKickoff;
        private System.Windows.Forms.CheckBox chkDataRelease;
        private System.Windows.Forms.CheckBox chkFolder;
        public System.Windows.Forms.ComboBox cmbBl;
        private System.Windows.Forms.Button btnSubmit;
    }
}