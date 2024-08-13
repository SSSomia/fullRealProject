namespace fullRealProject
{
    partial class issueDrivingLicense
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
            this.applicationInfoUC1 = new fullRealProject.applicationInfoUC();
            this.issue = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // applicationInfoUC1
            // 
            this.applicationInfoUC1.Location = new System.Drawing.Point(65, 34);
            this.applicationInfoUC1.Name = "applicationInfoUC1";
            this.applicationInfoUC1.Size = new System.Drawing.Size(638, 284);
            this.applicationInfoUC1.TabIndex = 0;
            // 
            // issue
            // 
            this.issue.Location = new System.Drawing.Point(632, 353);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(75, 23);
            this.issue.TabIndex = 1;
            this.issue.Text = "Issue";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(516, 353);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // issueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.applicationInfoUC1);
            this.Name = "issueDrivingLicense";
            this.Text = "issueDrivingLicense";
            this.Load += new System.EventHandler(this.issueDrivingLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private applicationInfoUC applicationInfoUC1;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.Button cancel;
    }
}