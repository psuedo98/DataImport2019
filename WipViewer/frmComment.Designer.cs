namespace WipViewer
{
    partial class frmComment
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(109, 12);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(624, 31);
            this.txtComment.TabIndex = 0;
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment_KeyDown);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(2, 15);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(103, 25);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = "Comment";
            // 
            // btnComment
            // 
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(495, 49);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(238, 46);
            this.btnComment.TabIndex = 2;
            this.btnComment.Text = "Add Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // frmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 106);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Name = "frmComment";
            this.Text = "frmComment";
            this.Load += new System.EventHandler(this.frmComment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnComment;
    }
}