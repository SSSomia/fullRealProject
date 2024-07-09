namespace fullRealProject
{
    partial class managePerson
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
            this.listPeople = new System.Windows.Forms.DataGridView();
            this.dealWithPerosn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listPeople)).BeginInit();
            this.dealWithPerosn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(391, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Person";
            // 
            // listPeople
            // 
            this.listPeople.AllowUserToAddRows = false;
            this.listPeople.AllowUserToDeleteRows = false;
            this.listPeople.AllowUserToOrderColumns = true;
            this.listPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPeople.ContextMenuStrip = this.dealWithPerosn;
            this.listPeople.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.listPeople.Location = new System.Drawing.Point(71, 226);
            this.listPeople.Name = "listPeople";
            this.listPeople.ReadOnly = true;
            this.listPeople.RowHeadersWidth = 51;
            this.listPeople.RowTemplate.Height = 24;
            this.listPeople.Size = new System.Drawing.Size(1086, 312);
            this.listPeople.TabIndex = 1;
            // 
            // dealWithPerosn
            // 
            this.dealWithPerosn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dealWithPerosn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.dealWithPerosn.Name = "dealWithPerosn";
            this.dealWithPerosn.Size = new System.Drawing.Size(211, 104);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addNewPerson
            // 
            this.addNewPerson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPerson.Location = new System.Drawing.Point(941, 147);
            this.addNewPerson.Name = "addNewPerson";
            this.addNewPerson.Size = new System.Drawing.Size(216, 60);
            this.addNewPerson.TabIndex = 2;
            this.addNewPerson.Text = "Add New Person";
            this.addNewPerson.UseVisualStyleBackColor = false;
            this.addNewPerson.Click += new System.EventHandler(this.addNewPerson_Click);
            // 
            // managePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.addNewPerson);
            this.Controls.Add(this.listPeople);
            this.Controls.Add(this.label1);
            this.Name = "managePerson";
            this.Text = "managePerson";
            this.Load += new System.EventHandler(this.managePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPeople)).EndInit();
            this.dealWithPerosn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listPeople;
        private System.Windows.Forms.Button addNewPerson;
        private System.Windows.Forms.ContextMenuStrip dealWithPerosn;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}