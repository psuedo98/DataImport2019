namespace WipViewer
{
    partial class InventoryIn
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
            this.lblJob = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtQuantity = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblPartNumber = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtPartNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSubmit = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(32, 74);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(92, 25);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtQuantity.BeforeTouchSize = new System.Drawing.Size(105, 20);
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.EnableTouchMode = true;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtQuantity.Location = new System.Drawing.Point(145, 66);
            this.txtQuantity.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(243, 40);
            this.txtQuantity.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.txtQuantity.TabIndex = 7;
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartNumber.Location = new System.Drawing.Point(12, 20);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(124, 25);
            this.lblPartNumber.TabIndex = 6;
            this.lblPartNumber.Text = "Bin Number";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtPartNumber.BeforeTouchSize = new System.Drawing.Size(105, 20);
            this.txtPartNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPartNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPartNumber.EnableTouchMode = true;
            this.txtPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtPartNumber.Location = new System.Drawing.Point(145, 12);
            this.txtPartNumber.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(243, 40);
            this.txtPartNumber.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016DarkGray;
            this.txtPartNumber.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleName = "Button";
            this.btnSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(145, 129);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(243, 95);
            this.btnSubmit.Style.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmit.Style.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Receive In";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // InventoryIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 263);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblPartNumber);
            this.Controls.Add(this.txtPartNumber);
            this.Name = "InventoryIn";
            this.Text = "Receive Inventory ";
            this.Load += new System.EventHandler(this.InventoryIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel lblJob;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQuantity;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPartNumber;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPartNumber;
        private Syncfusion.WinForms.Controls.SfButton btnSubmit;
    }
}