namespace fullRealProject
{
    partial class drivingLicenseApp
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.localDrivingLicenseApps = new System.Windows.Forms.DataGridView();
            this.dealWithLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sechualTests = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicalTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsNum = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.localDrivingLicenseApps)).BeginInit();
            this.dealWithLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(376, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Driving License Applications";
            // 
            // localDrivingLicenseApps
            // 
            this.localDrivingLicenseApps.AllowUserToAddRows = false;
            this.localDrivingLicenseApps.AllowUserToDeleteRows = false;
            this.localDrivingLicenseApps.AllowUserToOrderColumns = true;
            this.localDrivingLicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localDrivingLicenseApps.ContextMenuStrip = this.dealWithLicense;
            this.localDrivingLicenseApps.Location = new System.Drawing.Point(132, 134);
            this.localDrivingLicenseApps.Name = "localDrivingLicenseApps";
            this.localDrivingLicenseApps.ReadOnly = true;
            this.localDrivingLicenseApps.RowHeadersWidth = 51;
            this.localDrivingLicenseApps.RowTemplate.Height = 24;
            this.localDrivingLicenseApps.Size = new System.Drawing.Size(939, 356);
            this.localDrivingLicenseApps.TabIndex = 1;
            // 
            // dealWithLicense
            // 
            this.dealWithLicense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dealWithLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechualTests,
            this.cancelApplicationToolStripMenuItem,
            this.issueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.dealWithLicense.Name = "dealWithPerosn";
            this.dealWithLicense.Size = new System.Drawing.Size(259, 152);
            this.dealWithLicense.Opening += new System.ComponentModel.CancelEventHandler(this.dealWithLicense_Opening);
            // 
            // sechualTests
            // 
            this.sechualTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.practicalTestToolStripMenuItem});
            this.sechualTests.Name = "sechualTests";
            this.sechualTests.Size = new System.Drawing.Size(258, 24);
            this.sechualTests.Text = "sechdule tests";
            this.sechualTests.Click += new System.EventHandler(this.sechualTests_Click);
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.visionTestToolStripMenuItem.Text = "vision test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.writtenTestToolStripMenuItem.Text = "written test";
            this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
            // 
            // practicalTestToolStripMenuItem
            // 
            this.practicalTestToolStripMenuItem.Name = "practicalTestToolStripMenuItem";
            this.practicalTestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.practicalTestToolStripMenuItem.Text = "practical test";
            this.practicalTestToolStripMenuItem.Click += new System.EventHandler(this.practicalTestToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.cancelApplicationToolStripMenuItem.Text = "cancel application";
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.issueDrivingLicenseToolStripMenuItem.Text = "issue driving license";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.showLicenseToolStripMenuItem.Text = "show license";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "show person license history";
            // 
            // rowsNum
            // 
            this.rowsNum.AutoSize = true;
            this.rowsNum.Location = new System.Drawing.Point(210, 508);
            this.rowsNum.Name = "rowsNum";
            this.rowsNum.Size = new System.Drawing.Size(14, 16);
            this.rowsNum.TabIndex = 7;
            this.rowsNum.Text = "0";
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows.Location = new System.Drawing.Point(129, 508);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(74, 16);
            this.rows.TabIndex = 6;
            this.rows.Text = "Records :";
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(955, 508);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(116, 41);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // drivingLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 556);
            this.Controls.Add(this.close);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.localDrivingLicenseApps);
            this.Controls.Add(this.label1);
            this.Name = "drivingLicenseApp";
            this.Text = "drivingLicenseApp";
            this.Load += new System.EventHandler(this.drivingLicenseApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localDrivingLicenseApps)).EndInit();
            this.dealWithLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView localDrivingLicenseApps;
        private System.Windows.Forms.Label rowsNum;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ContextMenuStrip dealWithLicense;
        private System.Windows.Forms.ToolStripMenuItem sechualTests;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicalTestToolStripMenuItem;
    }
}