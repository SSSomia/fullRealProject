namespace fullRealProject
{
    partial class manageUsers
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
            this.addNewUser = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rowsNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewUser
            // 
            this.addNewUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewUser.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUser.Location = new System.Drawing.Point(938, 161);
            this.addNewUser.Name = "addNewUser";
            this.addNewUser.Size = new System.Drawing.Size(216, 60);
            this.addNewUser.TabIndex = 11;
            this.addNewUser.Text = "Add New User";
            this.addNewUser.UseVisualStyleBackColor = false;
            this.addNewUser.Click += new System.EventHandler(this.addNewUser_Click);
            // 
            // listUsers
            // 
            this.listUsers.AllowUserToAddRows = false;
            this.listUsers.AllowUserToDeleteRows = false;
            this.listUsers.AllowUserToOrderColumns = true;
            this.listUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUsers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.listUsers.Location = new System.Drawing.Point(68, 240);
            this.listUsers.Name = "listUsers";
            this.listUsers.ReadOnly = true;
            this.listUsers.RowHeadersWidth = 51;
            this.listUsers.RowTemplate.Height = 24;
            this.listUsers.Size = new System.Drawing.Size(1086, 312);
            this.listUsers.TabIndex = 10;
            this.listUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPeople_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(388, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Records :";
            // 
            // rowsNum
            // 
            this.rowsNum.AutoSize = true;
            this.rowsNum.Location = new System.Drawing.Point(149, 586);
            this.rowsNum.Name = "rowsNum";
            this.rowsNum.Size = new System.Drawing.Size(0, 16);
            this.rowsNum.TabIndex = 13;
            // 
            // manageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 614);
            this.Controls.Add(this.rowsNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNewUser);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.label1);
            this.Name = "manageUsers";
            this.Text = "manageUsers";
            this.Load += new System.EventHandler(this.manageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewUser;
        private System.Windows.Forms.DataGridView listUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rowsNum;
    }
}