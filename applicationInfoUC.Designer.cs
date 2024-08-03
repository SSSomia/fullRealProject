namespace fullRealProject
{
    partial class applicationInfoUC
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
            this.appBasicInfoUC1 = new fullRealProject.appBasicInfoUC();
            this.drivingLicenseApplicationInfoUC1 = new fullRealProject.drivingLicenseApplicationInfoUC();
            this.SuspendLayout();
            // 
            // appBasicInfoUC1
            // 
            this.appBasicInfoUC1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.appBasicInfoUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appBasicInfoUC1.Location = new System.Drawing.Point(3, 95);
            this.appBasicInfoUC1.Name = "appBasicInfoUC1";
            this.appBasicInfoUC1.Size = new System.Drawing.Size(631, 186);
            this.appBasicInfoUC1.TabIndex = 0;
            // 
            // drivingLicenseApplicationInfoUC1
            // 
            this.drivingLicenseApplicationInfoUC1.BackColor = System.Drawing.SystemColors.Window;
            this.drivingLicenseApplicationInfoUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivingLicenseApplicationInfoUC1.Location = new System.Drawing.Point(30, 3);
            this.drivingLicenseApplicationInfoUC1.Name = "drivingLicenseApplicationInfoUC1";
            this.drivingLicenseApplicationInfoUC1.Size = new System.Drawing.Size(576, 86);
            this.drivingLicenseApplicationInfoUC1.TabIndex = 1;
            // 
            // applicationInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drivingLicenseApplicationInfoUC1);
            this.Controls.Add(this.appBasicInfoUC1);
            this.Name = "applicationInfoUC";
            this.Size = new System.Drawing.Size(638, 284);
            this.Load += new System.EventHandler(this.applicationInfoUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private appBasicInfoUC appBasicInfoUC1;
        private drivingLicenseApplicationInfoUC drivingLicenseApplicationInfoUC1;
    }
}
