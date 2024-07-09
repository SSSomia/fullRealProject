namespace fullRealProject
{
    partial class personInfo
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
            this.SuspendLayout();
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.Location = new System.Drawing.Point(139, 141);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(961, 393);
            this.personInfoUC1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(486, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Information";
            // 
            // showPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personInfoUC1);
            this.Name = "showPersonDetails";
            this.Text = "showPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private personInfoUC personInfoUC1;
        private System.Windows.Forms.Label label1;
    }
}