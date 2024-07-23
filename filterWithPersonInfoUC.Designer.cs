namespace fullRealProject
{
    partial class filterWithPersonInfoUC
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
            this.addNewPerson = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.nationalNumber = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Label();
            this.personInfoUC1 = new fullRealProject.personInfoUC();
            this.SuspendLayout();
            // 
            // addNewPerson
            // 
            this.addNewPerson.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewPerson.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPerson.Location = new System.Drawing.Point(756, 16);
            this.addNewPerson.Name = "addNewPerson";
            this.addNewPerson.Size = new System.Drawing.Size(216, 60);
            this.addNewPerson.TabIndex = 10;
            this.addNewPerson.Text = "Add New Person";
            this.addNewPerson.UseVisualStyleBackColor = false;
            this.addNewPerson.Click += new System.EventHandler(this.addNewPerson_Click_1);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(404, 35);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // nationalNumber
            // 
            this.nationalNumber.Location = new System.Drawing.Point(263, 35);
            this.nationalNumber.Name = "nationalNumber";
            this.nationalNumber.Size = new System.Drawing.Size(100, 22);
            this.nationalNumber.TabIndex = 8;
            this.nationalNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nationalNumber_KeyPress_1);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.filter.Location = new System.Drawing.Point(30, 35);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(211, 20);
            this.filter.TabIndex = 7;
            this.filter.Text = "filter with national number :";
            // 
            // personInfoUC1
            // 
            this.personInfoUC1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personInfoUC1.Location = new System.Drawing.Point(34, 98);
            this.personInfoUC1.Name = "personInfoUC1";
            this.personInfoUC1.Size = new System.Drawing.Size(938, 378);
            this.personInfoUC1.TabIndex = 11;
            // 
            // filterWithPersonInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.personInfoUC1);
            this.Controls.Add(this.addNewPerson);
            this.Controls.Add(this.search);
            this.Controls.Add(this.nationalNumber);
            this.Controls.Add(this.filter);
            this.Name = "filterWithPersonInfoUC";
            this.Size = new System.Drawing.Size(996, 503);
            this.Load += new System.EventHandler(this.filterWithPersonInfoUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewPerson;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox nationalNumber;
        private System.Windows.Forms.Label filter;
        private personInfoUC personInfoUC1;
    }
}
