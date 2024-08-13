namespace fullRealProject
{
    partial class applicationTypes
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
            this.listAppTypes = new System.Windows.Forms.DataGridView();
            this.rowsNum = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.dealWithPerosn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.listAppTypes)).BeginInit();
            this.dealWithPerosn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(376, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Application Types";
            // 
            // listAppTypes
            // 
            this.listAppTypes.AllowUserToAddRows = false;
            this.listAppTypes.AllowUserToDeleteRows = false;
            this.listAppTypes.AllowUserToOrderColumns = true;
            this.listAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAppTypes.ContextMenuStrip = this.dealWithPerosn;
            this.listAppTypes.Location = new System.Drawing.Point(132, 134);
            this.listAppTypes.Name = "listAppTypes";
            this.listAppTypes.ReadOnly = true;
            this.listAppTypes.RowHeadersWidth = 51;
            this.listAppTypes.RowTemplate.Height = 24;
            this.listAppTypes.Size = new System.Drawing.Size(939, 356);
            this.listAppTypes.TabIndex = 1;
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
            // dealWithPerosn
            // 
            this.dealWithPerosn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dealWithPerosn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.dealWithPerosn.Name = "dealWithPerosn";
            this.dealWithPerosn.Size = new System.Drawing.Size(105, 28);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // applicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 556);
            this.Controls.Add(this.close);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.listAppTypes);
            this.Controls.Add(this.label1);
            this.Name = "applicationTypes";
            this.Text = "applicationTypes";
            this.Load += new System.EventHandler(this.applicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAppTypes)).EndInit();
            this.dealWithPerosn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listAppTypes;
        private System.Windows.Forms.Label rowsNum;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ContextMenuStrip dealWithPerosn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}