namespace fullRealProject
{
    partial class drivingLicenseApplicationInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passTest = new System.Windows.Forms.Label();
            this.license = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passTest
            // 
            this.passTest.AutoSize = true;
            this.passTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTest.Location = new System.Drawing.Point(181, 45);
            this.passTest.Name = "passTest";
            this.passTest.Size = new System.Drawing.Size(23, 18);
            this.passTest.TabIndex = 7;
            this.passTest.Text = "---";
            // 
            // license
            // 
            this.license.AutoSize = true;
            this.license.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license.Location = new System.Drawing.Point(181, 10);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(23, 18);
            this.license.TabIndex = 6;
            this.license.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "passed tests: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "applied for license:";
            // 
            // drivingLicenseApplicationInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.passTest);
            this.Controls.Add(this.license);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "drivingLicenseApplicationInfoUC";
            this.Size = new System.Drawing.Size(576, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passTest;
        private System.Windows.Forms.Label license;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
