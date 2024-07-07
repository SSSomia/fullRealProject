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
            this.label1 = new System.Windows.Forms.Label();
            this.listPerson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listPerson)).BeginInit();
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
            // listPerson
            // 
            this.listPerson.AllowUserToAddRows = false;
            this.listPerson.AllowUserToDeleteRows = false;
            this.listPerson.AllowUserToOrderColumns = true;
            this.listPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPerson.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.listPerson.Location = new System.Drawing.Point(71, 226);
            this.listPerson.Name = "listPerson";
            this.listPerson.ReadOnly = true;
            this.listPerson.RowHeadersWidth = 51;
            this.listPerson.RowTemplate.Height = 24;
            this.listPerson.Size = new System.Drawing.Size(1086, 362);
            this.listPerson.TabIndex = 1;
            // 
            // managePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.listPerson);
            this.Controls.Add(this.label1);
            this.Name = "managePerson";
            this.Text = "managePerson";
            this.Load += new System.EventHandler(this.managePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listPerson;
    }
}