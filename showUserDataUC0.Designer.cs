namespace fullRealProject
{
    partial class showUserDataUC0
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
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.userInfoUC1 = new fullRealProject.userInfoUC();
            this.SuspendLayout();
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personInfoUC1.Location = new System.Drawing.Point(3, 3);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(961, 393);
            this.personInfoUC1.TabIndex = 0;
            // 
            // userInfoUC1
            // 
            this.userInfoUC1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userInfoUC1.Location = new System.Drawing.Point(148, 402);
            this.userInfoUC1.Name = "userInfoUC1";
            this.userInfoUC1.Size = new System.Drawing.Size(645, 88);
            this.userInfoUC1.TabIndex = 1;
            // 
            // showUserDataUC0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userInfoUC1);
            this.Controls.Add(this.personInfoUC1);
            this.Name = "showUserDataUC0";
            this.Size = new System.Drawing.Size(973, 500);
            this.Load += new System.EventHandler(this.showUserDataUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private personInfoUC personInfoUC1;
        private userInfoUC userInfoUC1;
    }
}
