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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Dave Terrell",
            "Dennis Nucci",
            "Greg Sullivan",
            "Gary Kirby",
            "John Barnes",
            "Ken Riehle",
            "John Thoel"});
            this.comboBox3.Location = new System.Drawing.Point(110, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // team2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 275);
            this.Controls.Add(this.comboBox3);
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
        private System.Windows.Forms.ComboBox comboBox3;
    }
}