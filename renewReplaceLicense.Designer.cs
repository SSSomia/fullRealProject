namespace fullRealProject
{
    partial class renewReplaceLicense
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
            this.renew = new System.Windows.Forms.RadioButton();
            this.damage = new System.Windows.Forms.RadioButton();
            this.lose = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newLicense = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createdBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalFees = new System.Windows.Forms.Label();
            this.filterLicenseWithID1 = new fullRealProject.filterLicenseWithID();
            this.issue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renew
            // 
            this.renew.AutoSize = true;
            this.renew.Location = new System.Drawing.Point(25, 49);
            this.renew.Name = "renew";
            this.renew.Size = new System.Drawing.Size(110, 20);
            this.renew.TabIndex = 1;
            this.renew.TabStop = true;
            this.renew.Text = "renew license";
            this.renew.UseVisualStyleBackColor = true;
            this.renew.Click += new System.EventHandler(this.renew_Click);
            // 
            // damage
            // 
            this.damage.AutoSize = true;
            this.damage.Location = new System.Drawing.Point(159, 49);
            this.damage.Name = "damage";
            this.damage.Size = new System.Drawing.Size(146, 20);
            this.damage.TabIndex = 2;
            this.damage.TabStop = true;
            this.damage.Text = "replace for damage";
            this.damage.UseVisualStyleBackColor = true;
            this.damage.Click += new System.EventHandler(this.damage_Click);
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Location = new System.Drawing.Point(328, 49);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(121, 20);
            this.lose.TabIndex = 3;
            this.lose.TabStop = true;
            this.lose.Text = "replace for lose";
            this.lose.UseVisualStyleBackColor = true;
            this.lose.Click += new System.EventHandler(this.lose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.renew);
            this.groupBox1.Controls.Add(this.lose);
            this.groupBox1.Controls.Add(this.damage);
            this.groupBox1.Location = new System.Drawing.Point(551, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "new license to";
            // 
            // newLicense
            // 
            this.newLicense.AutoSize = true;
            this.newLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLicense.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newLicense.Location = new System.Drawing.Point(151, 47);
            this.newLicense.Name = "newLicense";
            this.newLicense.Size = new System.Drawing.Size(259, 51);
            this.newLicense.TabIndex = 5;
            this.newLicense.Text = "new license";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "created by:";
            // 
            // createdBy
            // 
            this.createdBy.AutoSize = true;
            this.createdBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdBy.Location = new System.Drawing.Point(187, 601);
            this.createdBy.Name = "createdBy";
            this.createdBy.Size = new System.Drawing.Size(27, 20);
            this.createdBy.TabIndex = 8;
            this.createdBy.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "total fees:";
            // 
            // totalFees
            // 
            this.totalFees.AutoSize = true;
            this.totalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFees.Location = new System.Drawing.Point(607, 601);
            this.totalFees.Name = "totalFees";
            this.totalFees.Size = new System.Drawing.Size(27, 20);
            this.totalFees.TabIndex = 10;
            this.totalFees.Text = "---";
            // 
            // filterLicenseWithID1
            // 
            this.filterLicenseWithID1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterLicenseWithID1.Location = new System.Drawing.Point(63, 136);
            this.filterLicenseWithID1.Name = "filterLicenseWithID1";
            this.filterLicenseWithID1.Size = new System.Drawing.Size(960, 423);
            this.filterLicenseWithID1.TabIndex = 0;
            // 
            // issue
            // 
            this.issue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.issue.Location = new System.Drawing.Point(888, 651);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(135, 34);
            this.issue.TabIndex = 11;
            this.issue.Text = "issue license";
            this.issue.UseVisualStyleBackColor = false;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // renewReplaceLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 804);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.totalFees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createdBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newLicense);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filterLicenseWithID1);
            this.Name = "renewReplaceLicense";
            this.Text = "renewReplaceLicense";
            this.Load += new System.EventHandler(this.renewReplaceLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private filterLicenseWithID filterLicenseWithID1;
        private System.Windows.Forms.RadioButton renew;
        private System.Windows.Forms.RadioButton damage;
        private System.Windows.Forms.RadioButton lose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label newLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label createdBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalFees;
        private System.Windows.Forms.Button issue;
    }
}