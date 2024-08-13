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
            this.close = new System.Windows.Forms.Button();
            this.rows = new System.Windows.Forms.Label();
            this.rowsNum = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterBy = new System.Windows.Forms.TextBox();
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
            this.dealWithPerosn.Size = new System.Drawing.Size(165, 76);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
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
            // close
            // 
            this.close.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1041, 564);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(116, 41);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows.Location = new System.Drawing.Point(68, 564);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(74, 16);
            this.rows.TabIndex = 4;
            this.rows.Text = "Records :";
            // 
            // rowsNum
            // 
            this.rowsNum.AutoSize = true;
            this.rowsNum.Location = new System.Drawing.Point(149, 564);
            this.rowsNum.Name = "rowsNum";
            this.rowsNum.Size = new System.Drawing.Size(14, 16);
            this.rowsNum.TabIndex = 5;
            this.rowsNum.Text = "0";
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "personID",
            "nationalNum",
            "firstName",
            "lastName",
            "phone",
            "email"});
            this.filterBox.Location = new System.Drawing.Point(187, 196);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(121, 24);
            this.filterBox.TabIndex = 6;
            this.filterBox.Text = "none";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "filter with :";
            // 
            // filterBy
            // 
            this.filterBy.Location = new System.Drawing.Point(314, 196);
            this.filterBy.Name = "filterBy";
            this.filterBy.Size = new System.Drawing.Size(110, 22);
            this.filterBy.TabIndex = 8;
            // 
            // managePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.filterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.close);
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
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Label rowsNum;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filterBy;
    }
}