namespace fullRealProject
{
    partial class tests
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
            this.testApp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addAppointment = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dealWithTest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationInfoUC1 = new fullRealProject.applicationInfoUC();
            ((System.ComponentModel.ISupportInitialize)(this.testApp)).BeginInit();
            this.dealWithTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "test title";
            // 
            // testApp
            // 
            this.testApp.AllowUserToAddRows = false;
            this.testApp.AllowUserToDeleteRows = false;
            this.testApp.AllowUserToOrderColumns = true;
            this.testApp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.testApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testApp.ContextMenuStrip = this.dealWithTest;
            this.testApp.Location = new System.Drawing.Point(75, 447);
            this.testApp.Name = "testApp";
            this.testApp.ReadOnly = true;
            this.testApp.RowHeadersWidth = 51;
            this.testApp.RowTemplate.Height = 24;
            this.testApp.Size = new System.Drawing.Size(726, 175);
            this.testApp.TabIndex = 2;
            this.testApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.testApp_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointments";
            // 
            // addAppointment
            // 
            this.addAppointment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addAppointment.Location = new System.Drawing.Point(652, 414);
            this.addAppointment.Name = "addAppointment";
            this.addAppointment.Size = new System.Drawing.Size(149, 27);
            this.addAppointment.TabIndex = 4;
            this.addAppointment.Text = "add appointment";
            this.addAppointment.UseVisualStyleBackColor = false;
            this.addAppointment.Click += new System.EventHandler(this.addAppointment_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.close.Location = new System.Drawing.Point(750, 628);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(101, 40);
            this.close.TabIndex = 5;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dealWithTest
            // 
            this.dealWithTest.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dealWithTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeToolStripMenuItem});
            this.dealWithTest.Name = "dealWithTest";
            this.dealWithTest.Size = new System.Drawing.Size(211, 80);
            this.dealWithTest.Opening += new System.ComponentModel.CancelEventHandler(this.dealWithTest_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeToolStripMenuItem
            // 
            this.takeToolStripMenuItem.Name = "takeToolStripMenuItem";
            this.takeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.takeToolStripMenuItem.Text = "take";
            this.takeToolStripMenuItem.Click += new System.EventHandler(this.takeToolStripMenuItem_Click);
            // 
            // applicationInfoUC1
            // 
            this.applicationInfoUC1.Location = new System.Drawing.Point(116, 96);
            this.applicationInfoUC1.Name = "applicationInfoUC1";
            this.applicationInfoUC1.Size = new System.Drawing.Size(638, 284);
            this.applicationInfoUC1.TabIndex = 0;
            // 
            // tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 680);
            this.Controls.Add(this.close);
            this.Controls.Add(this.addAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applicationInfoUC1);
            this.Name = "tests";
            this.Text = "tests";
            this.Load += new System.EventHandler(this.tests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testApp)).EndInit();
            this.dealWithTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private applicationInfoUC applicationInfoUC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView testApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAppointment;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ContextMenuStrip dealWithTest;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeToolStripMenuItem;
    }
}