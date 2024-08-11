namespace fullRealProject
{
    partial class showDriverLicenses
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
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.label2 = new System.Windows.Forms.Label();
            this.driverLicense = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driverLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Licenses";
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.Location = new System.Drawing.Point(45, 64);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(954, 383);
            this.personInfoUC1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "driver licenses";
            // 
            // driverLicense
            // 
            this.driverLicense.AllowUserToAddRows = false;
            this.driverLicense.AllowUserToDeleteRows = false;
            this.driverLicense.AllowUserToOrderColumns = true;
            this.driverLicense.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driverLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverLicense.Location = new System.Drawing.Point(48, 502);
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.ReadOnly = true;
            this.driverLicense.RowHeadersWidth = 51;
            this.driverLicense.RowTemplate.Height = 24;
            this.driverLicense.Size = new System.Drawing.Size(920, 211);
            this.driverLicense.TabIndex = 3;
            this.driverLicense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driverLicense_CellContentClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(893, 740);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // showDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 795);
            this.Controls.Add(this.close);
            this.Controls.Add(this.driverLicense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personInfoUC1);
            this.Controls.Add(this.label1);
            this.Name = "showDriverLicenses";
            this.Text = "showDriverLicenses";
            this.Load += new System.EventHandler(this.showDriverLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private personInfoUC personInfoUC1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView driverLicense;
        private System.Windows.Forms.Button close;
    }
}