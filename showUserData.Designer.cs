namespace fullRealProject
{
    partial class showUserData
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
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.label1 = new System.Windows.Forms.Label();
            this.userInfoUC1 = new fullRealProject.userInfoUC();
            this.SuspendLayout();
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personInfoUC1.Location = new System.Drawing.Point(42, 78);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(961, 393);
            this.personInfoUC1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(462, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Data";
            // 
            // userInfoUC1
            // 
            this.userInfoUC1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userInfoUC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfoUC1.Location = new System.Drawing.Point(165, 477);
            this.userInfoUC1.Name = "userInfoUC1";
            this.userInfoUC1.Size = new System.Drawing.Size(645, 88);
            this.userInfoUC1.TabIndex = 2;
            // 
            // showUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 626);
            this.Controls.Add(this.userInfoUC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personInfoUC1);
            this.Name = "showUserData";
            this.Text = "showUserData";
            this.Load += new System.EventHandler(this.showUserData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private personInfoUC personInfoUC1;
        private System.Windows.Forms.Label label1;
        private userInfoUC userInfoUC1;
    }
}