namespace fullRealProject
{
    partial class showDrivers
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
            this.drivers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drivers)).BeginInit();
            this.SuspendLayout();
            // 
            // drivers
            // 
            this.drivers.AllowUserToAddRows = false;
            this.drivers.AllowUserToDeleteRows = false;
            this.drivers.AllowUserToOrderColumns = true;
            this.drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drivers.Location = new System.Drawing.Point(66, 95);
            this.drivers.Name = "drivers";
            this.drivers.ReadOnly = true;
            this.drivers.RowHeadersWidth = 51;
            this.drivers.RowTemplate.Height = 24;
            this.drivers.Size = new System.Drawing.Size(939, 356);
            this.drivers.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(458, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drivers";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(930, 471);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // showDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 517);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drivers);
            this.Name = "showDrivers";
            this.Text = "showDrivers";
            this.Load += new System.EventHandler(this.showDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drivers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
    }
}