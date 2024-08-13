namespace fullRealProject
{
    partial class testTypes
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
            this.listTestTypes = new System.Windows.Forms.DataGridView();
            this.editTestType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsNum = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listTestTypes)).BeginInit();
            this.editTestType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(439, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Test Types";
            // 
            // listTestTypes
            // 
            this.listTestTypes.AllowUserToAddRows = false;
            this.listTestTypes.AllowUserToDeleteRows = false;
            this.listTestTypes.AllowUserToOrderColumns = true;
            this.listTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTestTypes.ContextMenuStrip = this.editTestType;
            this.listTestTypes.Location = new System.Drawing.Point(132, 134);
            this.listTestTypes.Name = "listTestTypes";
            this.listTestTypes.ReadOnly = true;
            this.listTestTypes.RowHeadersWidth = 51;
            this.listTestTypes.RowTemplate.Height = 24;
            this.listTestTypes.Size = new System.Drawing.Size(939, 356);
            this.listTestTypes.TabIndex = 1;
            // 
            // editTestType
            // 
            this.editTestType.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.editTestType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.editTestType.Name = "dealWithPerosn";
            this.editTestType.Size = new System.Drawing.Size(211, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            // testTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 556);
            this.Controls.Add(this.close);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.listTestTypes);
            this.Controls.Add(this.label1);
            this.Name = "testTypes";
            this.Text = "testTypes";
            this.Load += new System.EventHandler(this.testTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTestTypes)).EndInit();
            this.editTestType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listTestTypes;
        private System.Windows.Forms.Label rowsNum;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ContextMenuStrip editTestType;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}