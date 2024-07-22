namespace fullRealProject
{
    partial class showUserDataFm
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
            this.showUserDataUC01 = new fullRealProject.showUserDataUC0();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showUserDataUC01
            // 
            this.showUserDataUC01.Location = new System.Drawing.Point(107, 70);
            this.showUserDataUC01.Name = "showUserDataUC01";
            this.showUserDataUC01.Size = new System.Drawing.Size(973, 500);
            this.showUserDataUC01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(486, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Data";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1015, 502);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(96, 40);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // showUserDataFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 577);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showUserDataUC01);
            this.Name = "showUserDataFm";
            this.Text = "showUserDataFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private showUserDataUC0 showUserDataUC01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
    }
}