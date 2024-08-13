namespace fullRealProject
{
    partial class filterLicenseWithID
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
            this.search = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Label();
            this.licenseInfo1 = new fullRealProject.licenseInfo();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(330, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 15;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(189, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 14;
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.filter.Location = new System.Drawing.Point(9, 23);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(162, 20);
            this.filter.TabIndex = 13;
            this.filter.Text = "filter with licenseID :";
            // 
            // licenseInfo1
            // 
            this.licenseInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licenseInfo1.Location = new System.Drawing.Point(13, 57);
            this.licenseInfo1.Name = "licenseInfo1";
            this.licenseInfo1.Size = new System.Drawing.Size(935, 349);
            this.licenseInfo1.TabIndex = 16;
            // 
            // filterLicenseWithID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.licenseInfo1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.id);
            this.Controls.Add(this.filter);
            this.Name = "filterLicenseWithID";
            this.Size = new System.Drawing.Size(960, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label filter;
        private licenseInfo licenseInfo1;
    }
}
