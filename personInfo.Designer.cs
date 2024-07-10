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
            this.label1 = new System.Windows.Forms.Label();
            this.editPerson = new System.Windows.Forms.LinkLabel();
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(486, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Information";
            // 
            // editPerson
            // 
            this.editPerson.AutoSize = true;
            this.editPerson.Location = new System.Drawing.Point(903, 101);
            this.editPerson.Name = "editPerson";
            this.editPerson.Size = new System.Drawing.Size(75, 16);
            this.editPerson.TabIndex = 2;
            this.editPerson.TabStop = true;
            this.editPerson.Text = "Edit person";
            this.editPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editPerson_LinkClicked);
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.Location = new System.Drawing.Point(139, 141);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(961, 393);
            this.personInfoUC1.TabIndex = 0;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(1009, 565);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // personInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 609);
            this.Controls.Add(this.close);
            this.Controls.Add(this.editPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personInfoUC1);
            this.Name = "personInfo";
            this.Text = "showPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private personInfoUC personInfoUC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel editPerson;
        private System.Windows.Forms.Button close;
    }
}