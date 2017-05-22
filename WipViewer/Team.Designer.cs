namespace WipViewer
{
    partial class Team
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpKickoff = new System.Windows.Forms.DateTimePicker();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.dtpFolder = new System.Windows.Forms.DateTimePicker();
            this.cmbPM = new System.Windows.Forms.ComboBox();
            this.cmdLeader = new System.Windows.Forms.ComboBox();
            this.cmbProcessor = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkKickoff = new System.Windows.Forms.CheckBox();
            this.chkRelease = new System.Windows.Forms.CheckBox();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.dtpPO = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Build Leader";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Processor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kick Off";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Folder Received";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Release";
            // 
            // dtpKickoff
            // 
            this.dtpKickoff.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKickoff.Location = new System.Drawing.Point(148, 138);
            this.dtpKickoff.Name = "dtpKickoff";
            this.dtpKickoff.Size = new System.Drawing.Size(105, 20);
            this.dtpKickoff.TabIndex = 5;
            // 
            // dtpRelease
            // 
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRelease.Location = new System.Drawing.Point(148, 163);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(105, 20);
            this.dtpRelease.TabIndex = 6;
            // 
            // dtpFolder
            // 
            this.dtpFolder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFolder.Location = new System.Drawing.Point(148, 190);
            this.dtpFolder.Name = "dtpFolder";
            this.dtpFolder.Size = new System.Drawing.Size(105, 20);
            this.dtpFolder.TabIndex = 7;
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
            this.cmbPM.Location = new System.Drawing.Point(135, 6);
            this.cmbPM.Name = "cmbPM";
            this.cmbPM.Size = new System.Drawing.Size(121, 21);
            this.cmbPM.TabIndex = 1;
            this.cmbPM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmdLeader
            // 
            this.cmdLeader.AutoCompleteCustomSource.AddRange(new string[] {
            "Gary Kirby",
            "John Barnes",
            "David Terrell",
            "Ken Riehle"});
            this.cmdLeader.FormattingEnabled = true;
            this.cmdLeader.ItemHeight = 13;
            this.cmdLeader.Items.AddRange(new object[] {
            "Dave Terrell",
            "Dennis Nucci",
            "Greg Sullivan",
            "Gary Kirby",
            "John Barnes",
            "Ken Riehle",
            "John Thoel "});
            this.cmdLeader.Location = new System.Drawing.Point(135, 67);
            this.cmdLeader.Name = "cmdLeader";
            this.cmdLeader.Size = new System.Drawing.Size(121, 21);
            this.cmdLeader.TabIndex = 10;
            this.cmdLeader.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            this.cmbProcessor.Location = new System.Drawing.Point(135, 36);
            this.cmbProcessor.Name = "cmbProcessor";
            this.cmbProcessor.Size = new System.Drawing.Size(121, 21);
            this.cmbProcessor.TabIndex = 2;
            this.cmbProcessor.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(178, 228);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkKickoff
            // 
            this.chkKickoff.AutoSize = true;
            this.chkKickoff.Location = new System.Drawing.Point(259, 141);
            this.chkKickoff.Name = "chkKickoff";
            this.chkKickoff.Size = new System.Drawing.Size(85, 17);
            this.chkKickoff.TabIndex = 13;
            this.chkKickoff.Text = "Kicked Off? ";
            this.chkKickoff.UseVisualStyleBackColor = true;
            // 
            // chkRelease
            // 
            this.chkRelease.AutoSize = true;
            this.chkRelease.Location = new System.Drawing.Point(259, 166);
            this.chkRelease.Name = "chkRelease";
            this.chkRelease.Size = new System.Drawing.Size(106, 17);
            this.chkRelease.TabIndex = 14;
            this.chkRelease.Text = "Data Released? ";
            this.chkRelease.UseVisualStyleBackColor = true;
            // 
            // chkFolder
            // 
            this.chkFolder.AutoSize = true;
            this.chkFolder.Location = new System.Drawing.Point(259, 194);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(113, 17);
            this.chkFolder.TabIndex = 15;
            this.chkFolder.Text = "Folder Received? ";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // dtpPO
            // 
            this.dtpPO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPO.Location = new System.Drawing.Point(148, 112);
            this.dtpPO.Name = "dtpPO";
            this.dtpPO.Size = new System.Drawing.Size(105, 20);
            this.dtpPO.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "PO Date";
            // 
            // Team
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(413, 280);
            //this.Controls.Add(this.dtpPO);
            //this.Controls.Add(this.label5);
            //this.Controls.Add(this.chkFolder);
            //this.Controls.Add(this.chkRelease);
            //this.Controls.Add(this.chkKickoff);
            //this.Controls.Add(this.btnSubmit);
            //this.Controls.Add(this.cmbProcessor);
            //this.Controls.Add(this.cmdLeader);
            //this.Controls.Add(this.cmbPM);
            //this.Controls.Add(this.dtpFolder);
            //this.Controls.Add(this.dtpRelease);
            //this.Controls.Add(this.dtpKickoff);
            //this.Controls.Add(this.label6);
            //this.Controls.Add(this.label7);
            //this.Controls.Add(this.label4);
            //this.Controls.Add(this.label3);
            //this.Controls.Add(this.label2);
            //this.Controls.Add(this.label1);
            //this.Name = "Team";
            //this.ShowInTaskbar = false;
            //this.Text = "Team";
            //this.Load += new System.EventHandler(this.Team_Load);
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpKickoff;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.DateTimePicker dtpFolder;
        private System.Windows.Forms.ComboBox cmbPM;
        private System.Windows.Forms.ComboBox cmdLeader;
        private System.Windows.Forms.ComboBox cmbProcessor;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkKickoff;
        private System.Windows.Forms.CheckBox chkRelease;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.DateTimePicker dtpPO;
        private System.Windows.Forms.Label label5;
    }
}